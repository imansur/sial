using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Windows.Forms;

namespace Sial.View.Cadastro.Edital
{
    public partial class frmGridEdital : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridEdital));
        private readonly ISialSession SialSession;
        public frmGridEdital()
        {
            InitializeComponent();
            SialSession = new SialSession();
            BindEdital();
        }

        private void BindEdital()
        {
            dgvEdital.AutoGenerateColumns = false;
            dgvEdital.DataSource = SialSession.Edital.Buscar(txtPesquisa.Text,chkEncerrado.Checked);
            dgvEdital.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindEdital();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroEdital frmCadastroEdital = new frmCadastroEdital(Enumeradores.Modo.Insert, 0);
            frmCadastroEdital.ShowDialog();
            BindEdital();
        }

        private void dgvEdital_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdEdital = int.Parse(dgvEdital[0, e.RowIndex].Value.ToString());
            frmCadastroEdital frmCadastroEdital = new frmCadastroEdital(Enumeradores.Modo.Update, IdEdital);
            frmCadastroEdital.ShowDialog();
            BindEdital();
        }
    }
}
