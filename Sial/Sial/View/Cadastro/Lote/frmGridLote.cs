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

namespace Sial.View.Cadastro.Lote
{
    public partial class frmGridLote : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridLote));
        private readonly ISialSession SialSession;

        public frmGridLote()
        {
            InitializeComponent();
            SialSession = new SialSession();
            BindLote();
        }

        private void BindLote()
        {
            dgvLote.AutoGenerateColumns = false;
            dgvLote.DataSource = SialSession.Lote.Buscar(txtPesquisa.Text, chkEncerrado.Checked);
            dgvLote.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindLote();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroLote frmCadastroLote = new frmCadastroLote(Enumeradores.Modo.Insert, 0);
            frmCadastroLote.ShowDialog();
            BindLote();
        }

        private void dgvLote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdLote = int.Parse(dgvLote[2, e.RowIndex].Value.ToString());
            frmCadastroLote frmCadastroLote = new frmCadastroLote(Enumeradores.Modo.Update, IdLote);
            frmCadastroLote.ShowDialog();
            BindLote();
        }

        private void dgvLote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Repositorio.Entidades.Entidades.Sial.Lote lote = dgvLote.Rows[e.RowIndex].DataBoundItem as Repositorio.Entidades.Entidades.Sial.Lote;
            dgvLote.Rows[e.RowIndex].Cells["IdEdital"].Value = lote.Edital.IdEdital;
            dgvLote.Rows[e.RowIndex].Cells["Apelido"].Value = lote.Edital.Apelido;
        }
    }
}
