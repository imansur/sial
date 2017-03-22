using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace Sial.View.Cadastro.Empresa
{
    public partial class frmGridEmpresa : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmGridEmpresa));
        private readonly ISialSession SialSession;

        public frmGridEmpresa()
        {
            InitializeComponent();

            SialSession = new SialSession();
            BindEmpresa();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa frmCadastroEmpresa = new frmCadastroEmpresa(Enumeradores.Modo.Insert, 0);
            frmCadastroEmpresa.ShowDialog();
            BindEmpresa();
        }

        private void BindEmpresa()
        {
            dgvEmpresa.AutoGenerateColumns = false;
            dgvEmpresa.DataSource = SialSession.Empresa.Buscar(txtPesquisa.Text);
            dgvEmpresa.Refresh();
        }

        private void dgvEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdEmpresa = int.Parse(dgvEmpresa[0, e.RowIndex].Value.ToString());
            frmCadastroEmpresa frmCadastroEmpresa = new frmCadastroEmpresa(Enumeradores.Modo.Update, IdEmpresa);
            frmCadastroEmpresa.ShowDialog();
            BindEmpresa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindEmpresa();
        }
    }
}
