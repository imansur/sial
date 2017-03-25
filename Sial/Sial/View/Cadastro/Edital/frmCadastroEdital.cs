using Repositorio.Service.Session;
using Repositorio.Service.Session.Interface;
using Sial.Uteis;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Linq;
using static Sial.Uteis.Enumeradores;

namespace Sial.View.Cadastro.Edital
{
    public partial class frmCadastroEdital : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(frmCadastroEdital));
        private readonly ISialSession SialSession;

        Enumeradores.Modo ModoOperacao = 0;
        int IdEdital = 0;

        public frmCadastroEdital(Enumeradores.Modo modo, int idEdital)
        {
            InitializeComponent();

            SialSession = new SialSession();

            BindContratante();
            BindResponsavel();

            ModoOperacao = modo;
            if (ModoOperacao == Enumeradores.Modo.Update)
            {
                lblTipo.Text = "Editar Edital";
                CarregarDadosEdital(idEdital);
                IdEdital = idEdital;
            }

            else
            {
                lblTipo.Text = "Novo Edital";
            }
        }

        private void BindResponsavel()
        {
            cbResponsavel.ValueMember = "IdResponsavel";
            cbResponsavel.DisplayMember = "Nome";
            cbResponsavel.DataSource = SialSession.Responsavel.BuscarTodos();
        }
        private void BindContratante()
        {
            cbContratante.ValueMember = "IdOrgao";
            cbContratante.DisplayMember = "Nome";
            cbContratante.DataSource = SialSession.Orgao.BuscarTodos();
        }

        private void CarregarDadosEdital(int idEdital)
        {
            var edital = SialSession.Edital.BuscarPorId(idEdital);

            if (edital != null)
            {
                txtNumIdentificacao.Text = edital.IdEdital.ToString();
                txtNumEdital.Text = edital.NumeroEdital;
                txtApelido.Text = edital.Apelido;
                cbContratante.SelectedValue = edital.IdOrgao;
                cbResponsavel.SelectedValue = edital.IdResponsavel;
                txtDataEntrega.Text = edital.DataHoraEntrega.ToString();
                txtObjeto.Text = edital.Objeto;
                txtObservacao.Text = edital.Observacao;
                SetDestino(edital.Destino);
                txtLocal.Text = edital.Local;
                txtDataDescarte.Text = edital.DataDescarte.ToString();

                dgvLote.DataSource = edital.Lote.ToList();

                dgvAcompanhamento.DataSource = edital.Acompanhamento.OrderBy(acomp => acomp.Data).ToList();

            }
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
            var edital = SialSession.Edital.BuscarPorId(IdEdital);

            try
            {
                edital.NumeroEdital = txtNumEdital.Text;
                edital.Apelido = txtApelido.Text;
                edital.IdOrgao = int.Parse(cbContratante.SelectedValue.ToString());
                edital.IdResponsavel = int.Parse(cbResponsavel.SelectedValue.ToString());
                edital.DataHoraEntrega = Convert.ToDateTime(txtDataEntrega.Text);
                edital.Objeto = txtObjeto.Text;
                edital.Observacao = txtObservacao.Text;
                edital.Destino = GetDestino();
                edital.Local = txtLocal.Text;
                edital.DataDescarte = !String.IsNullOrWhiteSpace(txtDataDescarte.Text) ? Convert.ToDateTime(txtDataDescarte.Text) : (DateTime?)null;
                SialSession.Salvar();

                MessageBox.Show("Cadastro de Edital salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show("Erro ao salvar Edital." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Novo()
        {
            try
            {
                var Edital = SialSession.Edital.Inserir(new Repositorio.Entidades.Entidades.Sial.Edital
                {
                    NumeroEdital = txtNumEdital.Text,
                    Apelido = txtApelido.Text,
                    IdOrgao = int.Parse(cbContratante.SelectedValue.ToString()),
                    IdResponsavel = int.Parse(cbResponsavel.SelectedValue.ToString()),
                    DataHoraEntrega = Convert.ToDateTime(txtDataEntrega.Text),
                    Objeto = txtObjeto.Text,
                    Observacao = txtObservacao.Text,
                    Destino = GetDestino(),
                    Local = txtLocal.Text,
                    DataDescarte = !String.IsNullOrWhiteSpace(txtDataDescarte.Text) ? Convert.ToDateTime(txtDataDescarte.Text) : (DateTime?)null
                });

                if (SialSession.Salvar())
                {
                    MessageBox.Show("Cadastro de Edital salvo com sucesso!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        private int GetDestino()
        {
            RadioButton rdDestino = gbDestino.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return int.Parse(rdDestino.Tag.ToString());
        }

        private void SetDestino(int ? tag)
        {
            if (tag != null)
            {
                RadioButton rdDestino = gbDestino.Controls.OfType<RadioButton>().FirstOrDefault(r => int.Parse(r.Tag.ToString()) == tag);
                rdDestino.Checked = true;
            }
        }

        private void txtDataDescarte_ValueChanged(object sender, EventArgs e)
        {
            txtDataDescarte.Format = DateTimePickerFormat.Short;
        }

        private void txtDataDescarte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                txtDataDescarte.Format = DateTimePickerFormat.Custom;
                txtDataDescarte.CustomFormat = " ";
            }
        }
    }
}
