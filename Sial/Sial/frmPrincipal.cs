﻿using System;
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

        private void responsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastro.Responsavel.frmGridResponsavel frmGridResponsavel = new View.Cadastro.Responsavel.frmGridResponsavel();
            frmGridResponsavel.ShowDialog();
        }

        private void editalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastro.Edital.frmGridEdital frmGridEdital = new View.Cadastro.Edital.frmGridEdital();
            frmGridEdital.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastro.Lote.frmGridLote frmGridLote = new View.Cadastro.Lote.frmGridLote();
            frmGridLote.ShowDialog();
        }

        private void acompanhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastro.Acompanhamento.frmGridAcompanhamento frmGridAcompanhamento = new View.Cadastro.Acompanhamento.frmGridAcompanhamento();
            frmGridAcompanhamento.ShowDialog();
        }

        private void padraoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Relatorio.Padrao.frmGridRelatorio frmGridRelatorio = new View.Relatorio.Padrao.frmGridRelatorio();
            frmGridRelatorio.ShowDialog();
        }

        private void licitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Relatorio.Licitacao.frmLicitacao frmLicitacao = new View.Relatorio.Licitacao.frmLicitacao();
            frmLicitacao.ShowDialog();
        }
    }
}
