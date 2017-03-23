using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sial.View.Cadastro.Orgao
{
    public partial class frmCadastroOrgao : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroOrgao));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdOrgao = 0;
        public frmCadastroOrgao(Enumeradores.Modo modo, int idOrgao)
        {
            InitializeComponent();

            SialSession = new SialSession();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Orgão";
                CarregarDadosOrgao(idOrgao);
                IdOrgao = idOrgao;
            }
            else
            {
                lblTipo.Text = "Novo Orgão";
            }
        }

        private void CarregarDadosOrgao(int idOrgao)
        {
            var Orgao = SialSession.Orgao.BuscarPorId(idOrgao);

            if (Orgao != null)
            {
                txtNome.Text = Orgao.Nome;
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Novo()
        {
            try
            {
                var orgao = SialSession.Orgao.Inserir(new Repositorio.Entidades.Entidades.Sial.Orgao
                {
                    Nome = txtNome.Text,
                });

                if (SialSession.Salvar())
                {
                    MessageBox.Show("Cadastro de Orgão salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Orgão." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void Atualizar()
        {
            var orgao = SialSession.Orgao.BuscarPorId(IdOrgao);

            try
            {
                orgao.Nome = txtNome.Text;
                SialSession.Salvar();
                MessageBox.Show("Cadastro de Orgão salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Orgão." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
