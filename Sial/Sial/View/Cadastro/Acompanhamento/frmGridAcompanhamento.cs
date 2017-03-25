using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Windows.Forms;

namespace Sial.View.Cadastro.Acompanhamento
{
    public partial class frmGridAcompanhamento : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridAcompanhamento));
        private readonly ISialSession SialSession;

        public frmGridAcompanhamento()
        {
            InitializeComponent();
            SialSession = new SialSession();
            BindAcompanhamento();
        }

        private void BindAcompanhamento()
        {
            dgvAcompanhamento.AutoGenerateColumns = false;
            dgvAcompanhamento.DataSource = SialSession.Acompanhemento.Buscar(txtPesquisa.Text, chkEncerrado.Checked);
            dgvAcompanhamento.Refresh();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroAcompanhamento frmCadastroAcompanhamento = new frmCadastroAcompanhamento(Enumeradores.Modo.Insert, 0);
            frmCadastroAcompanhamento.ShowDialog();
            BindAcompanhamento();
        }

        private void dgvAcompanhamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdAcompanhamento = int.Parse(dgvAcompanhamento[3, e.RowIndex].Value.ToString());
            frmCadastroAcompanhamento frmCadastroAcompanhamento = new frmCadastroAcompanhamento(Enumeradores.Modo.Update, IdAcompanhamento);
            frmCadastroAcompanhamento.ShowDialog();
            BindAcompanhamento();
        }

        private void dgvAcompanhamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Repositorio.Entidades.Entidades.Sial.Acompanhamento acompanhamento = dgvAcompanhamento.Rows[e.RowIndex].DataBoundItem as Repositorio.Entidades.Entidades.Sial.Acompanhamento;
            dgvAcompanhamento.Rows[e.RowIndex].Cells["IdEdital"].Value = acompanhamento.Edital.IdEdital;
            dgvAcompanhamento.Rows[e.RowIndex].Cells["NumeroEdital"].Value = acompanhamento.Edital.NumeroEdital;
            dgvAcompanhamento.Rows[e.RowIndex].Cells["Apelido"].Value = acompanhamento.Edital.Apelido;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindAcompanhamento();
        }
    }
}
