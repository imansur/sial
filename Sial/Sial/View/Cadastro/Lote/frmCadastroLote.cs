using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Sial.Uteis.Enumeradores;

namespace Sial.View.Cadastro.Lote
{
    public partial class frmCadastroLote : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroLote));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdLote = 0;

        public frmCadastroLote(Enumeradores.Modo modo, int idLote)
        {
            InitializeComponent();

            AplicarEventos(txtOrcamento);
            AplicarEventos(txtProposta);

            SialSession = new SialSession();

            BindEdital();
            BindEmpresa();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Lote";
                CarregarDadosLote(idLote);
                IdLote = idLote;
            }

            else
            {
                lblTipo.Text = "Novo Lote";
            }
        }

        private void CarregarDadosLote(int idLote)
        {
            var lote = SialSession.Lote.BuscarPorId(idLote);

            if (lote != null)
            {
                cbEdital.SelectedValue = lote.IdEdital;
                cbEdital.Enabled = false;
                txtNumeroLote.Text = lote.NumeroLote;
                txtDescricao.Text = lote.Descricao;
                txtPrazoExecucao.Text = lote.PrazoExecucao.ToString();
                txtOrcamento.Text = Convert.ToDouble(lote.Orcamento ?? 0).ToString("C2");
                chkVencedor.Checked = lote.Vencedor;
                CarregarGridLoteEmpresa(lote.LoteEmpresa.ToList());

            }
        }

        private void CarregarGridLoteEmpresa(IList<LoteEmpresa> lstLoteEmpresa)
        {
            foreach (LoteEmpresa loteEmpresa in lstLoteEmpresa)
            {
                Double proposta = Convert.ToDouble(loteEmpresa.Proposta ?? 0);
                dgvLoteEmpresa.Rows.Add(loteEmpresa.IdEmpresa, loteEmpresa.Empresa.Nome, proposta.ToString("C2"));
            }
        }

        private void BindEmpresa()
        {
            cbEmpresa.ValueMember = "IdEmpresa";
            cbEmpresa.DisplayMember = "Nome";
            cbEmpresa.DataSource = SialSession.Empresa.BuscarTodos();
        }

        private void BindEdital()
        {
            ICollection<Repositorio.Entidades.Entidades.Sial.Edital> editais = SialSession.Edital.BuscarTodos();

            var editaisQuery = editais.Select(edital => new { IdEdital = edital.IdEdital, DisplayText = edital.NumeroEdital + " - " + edital.Apelido });

            cbEdital.ValueMember = "IdEdital";
            cbEdital.DisplayMember = "DisplayText";
            cbEdital.DataSource = editaisQuery.ToList();
        }
        
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(txt.Text != "")
            { 
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$ ", "").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtProposta.Text != "")
            {
                dgvLoteEmpresa.Rows.Add(cbEmpresa.SelectedValue.ToString(), cbEmpresa.Text, txtProposta.Text);
                txtProposta.Clear();
            }
            else
            {
                MessageBox.Show("O Campo Proposta é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.dgvLoteEmpresa.SelectedRows.Count > 0)
            {
                DialogResult dr =  MessageBox.Show("Deseja excluir Empresa do Lote ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    if (ModoOperacao.Equals(Modo.Update))
                    {
                        int index = this.dgvLoteEmpresa.SelectedRows[0].Index;
                        int idEmpresa = Convert.ToInt32(dgvLoteEmpresa.Rows[index].Cells[0].Value.ToString());

                        LoteEmpresa loteEmpresa = SialSession.LoteEmpresa.BuscarPorIdLoteIdEmpresa(IdLote, idEmpresa);
                        SialSession.LoteEmpresa.Exluir(loteEmpresa);
                        SialSession.Salvar();
                        dgvLoteEmpresa.Rows.RemoveAt(index);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ModoOperacao.Equals(Modo.Insert))
            {
                Novo();
            }
            else
            {
                Atualizar();
            }
        }

        private void Novo()
        {
            try
            {
                var rowsProp = from row in dgvLoteEmpresa.Rows.Cast<DataGridViewRow>()
                               select row;

                var lote = SialSession.Lote.Inserir(new Repositorio.Entidades.Entidades.Sial.Lote
                {
                    IdEdital = int.Parse(cbEdital.SelectedValue.ToString()),
                    NumeroLote = txtNumeroLote.Text,
                    Descricao = txtDescricao.Text,
                    PrazoExecucao = int.Parse(txtPrazoExecucao.Text),
                    Orcamento = Convert.ToDecimal(txtOrcamento.Text.Replace("R$ ", "")),
                    Vencedor = chkVencedor.Checked,
                    LoteEmpresa = GetLoteEmpresa()
                });

                if (SialSession.Salvar())
                {
                    MessageBox.Show("Cadastro de Lote salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        public void Atualizar()
        {
            var lote = SialSession.Lote.BuscarPorId(IdLote);

            try
            {
                lote.IdEdital = int.Parse(cbEdital.SelectedValue.ToString());
                lote.NumeroLote = txtNumeroLote.Text;
                lote.Descricao = txtDescricao.Text;
                lote.PrazoExecucao = int.Parse(txtPrazoExecucao.Text);
                lote.Orcamento = Convert.ToDecimal(txtOrcamento.Text.Replace("R$ ", ""));
                lote.Vencedor = chkVencedor.Checked;
                SialSession.Salvar();
                InsereLoteEmpresaNovo();

                MessageBox.Show("Cadastro de Lote salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Lote." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InsereLoteEmpresaNovo()
        {
            foreach (DataGridViewRow row in dgvLoteEmpresa.Rows)
            {
                int idEmpresa = Convert.ToInt32(row.Cells[0].Value.ToString());

                LoteEmpresa loteEmpresa = SialSession.LoteEmpresa.BuscarPorIdLoteIdEmpresa(IdLote, idEmpresa);

                if (loteEmpresa == null)
                {
                    loteEmpresa = new LoteEmpresa();
                    loteEmpresa.IdLote = IdLote;
                    loteEmpresa.IdEmpresa = idEmpresa;
                    loteEmpresa.Proposta = Convert.ToDecimal(row.Cells[2].Value.ToString().Replace("R$ ",""));

                    try
                    {
                        SialSession.LoteEmpresa.Inserir(loteEmpresa);
                        SialSession.Salvar();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex.Message);
                    }
                }
            }
        }

        private List<LoteEmpresa> GetLoteEmpresa()
        {
            List<LoteEmpresa> lstLoteEmpresa = new List<LoteEmpresa>();
            foreach (DataGridViewRow row in dgvLoteEmpresa.Rows)
            {
                LoteEmpresa loteEmpresa = new LoteEmpresa();
                loteEmpresa.IdEmpresa = Convert.ToInt32(row.Cells[0].Value.ToString());
                loteEmpresa.Proposta = Convert.ToDecimal(row.Cells[2].Value.ToString().Replace("R$ ", ""));
                lstLoteEmpresa.Add(loteEmpresa);
            }

            return lstLoteEmpresa;
        }
    }
}
