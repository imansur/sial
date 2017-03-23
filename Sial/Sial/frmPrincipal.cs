using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastro.Empresa.frmGridEmpresa frmGridEmpresa = new View.Cadastro.Empresa.frmGridEmpresa();
            frmGridEmpresa.ShowDialog();
        }

        private void orgãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastro.Orgao.frmGridOrgao frmGridOrgao = new View.Cadastro.Orgao.frmGridOrgao();
            frmGridOrgao.ShowDialog();
        }
    }
}
