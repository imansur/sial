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

namespace Sial.View.Relatorio.Licitacao
{
    public partial class frmLicitacao : Form
    {
        public frmLicitacao()
        {
            InitializeComponent();
        }

        private int GetDestino()
        {
            RadioButton rdDestino = gbDestino.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return int.Parse(rdDestino.Tag.ToString());
        }

        private void btnGerarRel_Click(object sender, EventArgs e)
        {
            DateTime dataDe = Convert.ToDateTime(txtDataDe.Text);
            DateTime dataAte = Convert.ToDateTime(txtDataAte.Text);

            frmRelatorio frmRelatorio = new frmRelatorio(dataDe, dataAte, GetDestino(), Enumeradores.Relatorio.Licitacao);
            frmRelatorio.ShowDialog();
        }
    }
}
