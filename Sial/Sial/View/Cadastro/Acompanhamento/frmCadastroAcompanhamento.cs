using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using static Sial.Uteis.Enumeradores;

namespace Sial.View.Cadastro.Acompanhamento
{
    public partial class frmCadastroAcompanhamento : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroAcompanhamento));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdAcmpanhamento = 0;
        public frmCadastroAcompanhamento(Enumeradores.Modo modo, int idAcompanhamento)
        {
            InitializeComponent();

            SialSession = new SialSession();

            BindEdital();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Acompanhamento";
                CarregarDadosAcompanhamento(idAcompanhamento);
                IdAcmpanhamento = idAcompanhamento;
            }

            else
            {
                lblTipo.Text = "Novo Acompanhamento";
            }
        }

        private void CarregarDadosAcompanhamento(int idAcompanhamento)
        {
            var acompanhamento = SialSession.Acompanhemento.BuscarPorId(idAcompanhamento);

            if (acompanhamento != null)
            {
                cbEdital.SelectedValue = acompanhamento.IdEdital;
                cbEdital.Enabled = false;
                txtData.Text = acompanhamento.Data.ToString("dd/MM/yyyy");
                txtEvento.Text = acompanhamento.Evento;
                txtObservacao.Text = acompanhamento.Observacao;
            }
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

        private void Atualizar()
        {
            var acompanhamento = SialSession.Acompanhemento.BuscarPorId(IdAcmpanhamento);

            try
            {
                acompanhamento.IdEdital = int.Parse(cbEdital.SelectedValue.ToString());
                acompanhamento.Data = Convert.ToDateTime(txtData.Text);
                acompanhamento.Evento = txtEvento.Text;
                acompanhamento.Observacao = txtObservacao.Text;
                SialSession.Salvar();
                MessageBox.Show("Cadastro de Acompanhamento salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Acompanhamento." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void Novo()
        {
            try
            {
                var acompanhamento = SialSession.Acompanhemento.Inserir(new Repositorio.Entidades.Entidades.Sial.Acompanhamento
                {
                    IdEdital = int.Parse(cbEdital.SelectedValue.ToString()),
                    Data = Convert.ToDateTime(txtData.Text),
                    Evento = txtEvento.Text,
                    Observacao = txtObservacao.Text
                });

                if (SialSession.Salvar())
                {
                    MessageBox.Show("Cadastro de Acompanhamento salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Acompanhamento." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
