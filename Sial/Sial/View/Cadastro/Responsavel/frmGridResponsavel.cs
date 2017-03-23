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

namespace Sial.View.Cadastro.Responsavel
{
    public partial class frmGridResponsavel : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridResponsavel));
        private readonly ISialSession SialSession;

        public frmGridResponsavel()
        {
            InitializeComponent();
            SialSession = new SialSession();
            BindResponsavel();

        }

        private void BindResponsavel()
        {
            dgvResp.AutoGenerateColumns = false;
            dgvResp.DataSource = SialSession.Responsavel.Buscar(txtPesquisa.Text);
            dgvResp.Refresh();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroResponsavel frmCadastroResponsavel = new frmCadastroResponsavel(Enumeradores.Modo.Insert, 0);
            frmCadastroResponsavel.ShowDialog();
            BindResponsavel();
        }

        private void dgvResp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdOrgao = int.Parse(dgvResp[0, e.RowIndex].Value.ToString());
            frmCadastroResponsavel frmCadastroResponsavel = new frmCadastroResponsavel(Enumeradores.Modo.Update, IdOrgao);
            frmCadastroResponsavel.ShowDialog();
            BindResponsavel();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindResponsavel();
        }
    }
}
