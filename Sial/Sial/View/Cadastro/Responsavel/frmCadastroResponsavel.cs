using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Windows.Forms;

namespace Sial.View.Cadastro.Responsavel
{
    public partial class frmCadastroResponsavel : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroResponsavel));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdResponsavel = 0;
        public frmCadastroResponsavel(Enumeradores.Modo modo, int idResponsavel)
        {
            InitializeComponent();

            SialSession = new SialSession();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Orgão";
                CarregarDadosResponsavel(idResponsavel);
                IdResponsavel = idResponsavel;
            }
            else
            {
                lblTipo.Text = "Novo Orgão";
            }
        }

        private void CarregarDadosResponsavel(int idResponsavel)
        {
            var Responsavel = SialSession.Responsavel.BuscarPorId(idResponsavel);

            if (Responsavel != null)
            {
                txtNome.Text = Responsavel.Nome;
            }
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
                var responsavel = SialSession.Responsavel.Inserir(new Repositorio.Entidades.Entidades.Sial.Responsavel
                {
                    Nome = txtNome.Text,
                });

                if (SialSession.Salvar())
                {
                    MessageBox.Show("Cadastro de Responsável salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Responsável." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void Atualizar()
        {
            var responsavel = SialSession.Responsavel.BuscarPorId(IdResponsavel);

            try
            {
                responsavel.Nome = txtNome.Text;
                SialSession.Salvar();
                MessageBox.Show("Cadastro de Responsável salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Responsável." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
