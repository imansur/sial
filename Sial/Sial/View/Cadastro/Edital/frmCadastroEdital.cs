using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Sial.View.Cadastro.Edital
{
    public partial class frmCadastroEdital : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroEdital));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdEdital = 0;

        public frmCadastroEdital(Enumeradores.Modo modo, int idEdital)
        {
            InitializeComponent();

            SialSession = new SialSession();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Edital";
                CarregarDadosEdital(idEdital);
                IdEdital = idEdital;
            }

            else
            {
                lblTipo.Text = "Novo Edital";
            }

            BindContratante();
            BindResponsavel();
        }

        private void BindResponsavel()
        {
            cbResponsavel.ValueMember = "IdResponsavel";
            cbResponsavel.DisplayMember = "Nome";
            cbResponsavel.DataSource = SialSession.Responsavel.BuscarTodos();
        }
        private void BindContratante()
        {
            cbContratante.ValueMember = "IdOrgao";
            cbContratante.DisplayMember = "Nome";
            cbContratante.DataSource = SialSession.Orgao.BuscarTodos();
        }

        private void CarregarDadosEdital(int idEdital)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
