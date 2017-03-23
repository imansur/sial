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
    public partial class frmGridOrgao : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridOrgao));
        private readonly ISialSession SialSession;

        public frmGridOrgao()
        {
            InitializeComponent();
            SialSession = new SialSession();
        }

        private void BindOrgao()
        {
            dgvOrgao.AutoGenerateColumns = false;
            dgvOrgao.DataSource = SialSession.Orgao.Buscar(txtPesquisa.Text);
            dgvOrgao.Refresh();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindOrgao();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroOrgao frmCadastroOrgao = new frmCadastroOrgao(Enumeradores.Modo.Insert, 0);
            frmCadastroOrgao.ShowDialog();
            BindOrgao();
        }

        private void dgvOrgao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdOrgao = int.Parse(dgvOrgao[0, e.RowIndex].Value.ToString());
            frmCadastroOrgao frmCadastroOrgao = new frmCadastroOrgao(Enumeradores.Modo.Update, IdOrgao);
            frmCadastroOrgao.ShowDialog();
            BindOrgao();
        }
    }
}
