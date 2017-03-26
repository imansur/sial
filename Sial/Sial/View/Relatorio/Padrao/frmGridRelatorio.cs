using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Windows.Forms;

namespace Sial.View.Relatorio.Padrao
{
    public partial class frmGridRelatorio : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridRelatorio));
        private readonly ISialSession SialSession;

        public frmGridRelatorio()
        {
            InitializeComponent();

            SialSession = new SialSession();
            BindEdital();
        }

        private void BindEdital()
        {
            dgvEdital.AutoGenerateColumns = false;
            dgvEdital.DataSource = SialSession.Edital.Buscar(txtPesquisa.Text, chkEncerrado.Checked);
            dgvEdital.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindEdital();
        }

        private void btnRelCapa_Click(object sender, EventArgs e)
        {

            if (dgvEdital.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvEdital.SelectedRows[0];
                int idEdital = int.Parse(row.Cells["IdEdital"].Value.ToString());
                frmRelatorio frmRelatorio = new frmRelatorio(idEdital, Enumeradores.Relatorio.Capa);
                frmRelatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um item no grid para geração do relatótio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEtiqueta_Click(object sender, EventArgs e)
        {
            if (dgvEdital.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvEdital.SelectedRows[0];
                int idEdital = int.Parse(row.Cells["IdEdital"].Value.ToString());
                frmRelatorio frmRelatorio = new frmRelatorio(idEdital, Enumeradores.Relatorio.Etiqueta);
                frmRelatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um item no grid para geração do relatótio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            if (dgvEdital.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvEdital.SelectedRows[0];
                int idEdital = int.Parse(row.Cells["IdEdital"].Value.ToString());
                frmRelatorio frmRelatorio = new frmRelatorio(idEdital, Enumeradores.Relatorio.Participantes);
                frmRelatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um item no grid para geração do relatótio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvEdital_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Repositorio.Entidades.Entidades.Sial.Edital edital = dgvEdital.Rows[e.RowIndex].DataBoundItem as Repositorio.Entidades.Entidades.Sial.Edital;
            dgvEdital.Rows[e.RowIndex].Cells["Contratante"].Value = edital.Orgao.Nome;
        }
    }
}
