using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Windows.Forms;

namespace Sial.View.Cadastro.Empresa
{
    public partial class frmCadastroEmpresa : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroEmpresa));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdEmpresa = 0;

        public frmCadastroEmpresa(Enumeradores.Modo modo, int idEmpresa)
        {
            InitializeComponent();

            SialSession = new SialSession();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Empresa";
                CarregarDadosEmpresa(idEmpresa);
                IdEmpresa = idEmpresa;
            }
            else
            {
                lblTipo.Text = "Nova Empresa";
            }
            
        }

        private void CarregarDadosEmpresa(int idEmpresa)
        {
            var Empresa = SialSession.Empresa.BuscarPorId(idEmpresa);

            if (Empresa != null)
            {
                txtNome.Text = Empresa.Nome;
                txtFone.Text = Empresa.Telefone;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ModoOperacao.Equals(Enumeradores.Modo.Insert))
            {
                Novo();
            }
            else
            {
                Atualizar();
            }
        }

        public void Novo()
        {
            try
            {
                var empresa = SialSession.Empresa.Inserir(new Repositorio.Entidades.Entidades.Sial.Empresa
                {
                    Nome = txtNome.Text,
                    Telefone = txtFone.Text
                });

                if (SialSession.Salvar())
                {
                    MessageBox.Show("Cadastro de Empresa salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Empresa." + ex.Message,"Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void Atualizar()
        {
            var empresa = SialSession.Empresa.BuscarPorId(IdEmpresa);

            try
            {
                empresa.Nome = txtNome.Text;
                empresa.Telefone = txtFone.Text;
                SialSession.Salvar();
                MessageBox.Show("Cadastro de Empresa salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Empresa." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
