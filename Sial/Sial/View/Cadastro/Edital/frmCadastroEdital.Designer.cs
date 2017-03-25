namespace Sial.View.Cadastro.Edital
{
    partial class frmCadastroEdital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.txtNumIdentificacao = new System.Windows.Forms.TextBox();
            this.txtNumEdital = new System.Windows.Forms.TextBox();
            this.lblNumEdital = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblContratante = new System.Windows.Forms.Label();
            this.cbContratante = new System.Windows.Forms.ComboBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblDataHoraEntrega = new System.Windows.Forms.Label();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.numeroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoExecucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLotes = new System.Windows.Forms.Label();
            this.lblAcompanhamento = new System.Windows.Forms.Label();
            this.dgvAcompanhamento = new System.Windows.Forms.DataGridView();
            this.idAcompanhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.rbEncerrado = new System.Windows.Forms.RadioButton();
            this.rbDescarte = new System.Windows.Forms.RadioButton();
            this.rbArqMorto = new System.Windows.Forms.RadioButton();
            this.rbAndamento = new System.Windows.Forms.RadioButton();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblDataDescarte = new System.Windows.Forms.Label();
            this.txtDataDescarte = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhamento)).BeginInit();
            this.gbDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(9, 38);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 18);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "lblTipo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Cadastro Edital";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(648, 628);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(567, 628);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Location = new System.Drawing.Point(9, 70);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(82, 13);
            this.lblIdentificacao.TabIndex = 20;
            this.lblIdentificacao.Text = "N. Identificação";
            // 
            // txtNumIdentificacao
            // 
            this.txtNumIdentificacao.Enabled = false;
            this.txtNumIdentificacao.Location = new System.Drawing.Point(12, 86);
            this.txtNumIdentificacao.Name = "txtNumIdentificacao";
            this.txtNumIdentificacao.Size = new System.Drawing.Size(111, 20);
            this.txtNumIdentificacao.TabIndex = 0;
            // 
            // txtNumEdital
            // 
            this.txtNumEdital.Location = new System.Drawing.Point(129, 86);
            this.txtNumEdital.Name = "txtNumEdital";
            this.txtNumEdital.Size = new System.Drawing.Size(186, 20);
            this.txtNumEdital.TabIndex = 1;
            // 
            // lblNumEdital
            // 
            this.lblNumEdital.AutoSize = true;
            this.lblNumEdital.Location = new System.Drawing.Point(126, 70);
            this.lblNumEdital.Name = "lblNumEdital";
            this.lblNumEdital.Size = new System.Drawing.Size(61, 13);
            this.lblNumEdital.TabIndex = 22;
            this.lblNumEdital.Text = "Núm. Edital";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(321, 86);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(403, 20);
            this.txtApelido.TabIndex = 2;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(318, 70);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(42, 13);
            this.lblApelido.TabIndex = 24;
            this.lblApelido.Text = "Apelido";
            // 
            // lblContratante
            // 
            this.lblContratante.AutoSize = true;
            this.lblContratante.Location = new System.Drawing.Point(9, 109);
            this.lblContratante.Name = "lblContratante";
            this.lblContratante.Size = new System.Drawing.Size(62, 13);
            this.lblContratante.TabIndex = 26;
            this.lblContratante.Text = "Contratante";
            // 
            // cbContratante
            // 
            this.cbContratante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbContratante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContratante.FormattingEnabled = true;
            this.cbContratante.Location = new System.Drawing.Point(12, 126);
            this.cbContratante.Name = "cbContratante";
            this.cbContratante.Size = new System.Drawing.Size(712, 21);
            this.cbContratante.TabIndex = 3;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(9, 149);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 28;
            this.lblResponsavel.Text = "Responsável";
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbResponsavel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbResponsavel.FormattingEnabled = true;
            this.cbResponsavel.Location = new System.Drawing.Point(12, 165);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(506, 21);
            this.cbResponsavel.TabIndex = 4;
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.CustomFormat = "dd/MM/yyyy hh:mm";
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataEntrega.Location = new System.Drawing.Point(524, 165);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(200, 20);
            this.txtDataEntrega.TabIndex = 5;
            // 
            // lblDataHoraEntrega
            // 
            this.lblDataHoraEntrega.AutoSize = true;
            this.lblDataHoraEntrega.Location = new System.Drawing.Point(521, 149);
            this.lblDataHoraEntrega.Name = "lblDataHoraEntrega";
            this.lblDataHoraEntrega.Size = new System.Drawing.Size(96, 13);
            this.lblDataHoraEntrega.TabIndex = 31;
            this.lblDataHoraEntrega.Text = "Data Hora Entrega";
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Location = new System.Drawing.Point(9, 189);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(38, 13);
            this.lblObjeto.TabIndex = 32;
            this.lblObjeto.Text = "Objeto";
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(11, 206);
            this.txtObjeto.Multiline = true;
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(712, 48);
            this.txtObjeto.TabIndex = 6;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(11, 273);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(712, 48);
            this.txtObservacao.TabIndex = 7;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(9, 257);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 34;
            this.lblObservacao.Text = "Observação";
            // 
            // dgvLote
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroLote,
            this.descricao,
            this.prazoExecucao,
            this.orcamento});
            this.dgvLote.Location = new System.Drawing.Point(11, 340);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(711, 104);
            this.dgvLote.TabIndex = 8;
            // 
            // numeroLote
            // 
            this.numeroLote.DataPropertyName = "NumeroLote";
            this.numeroLote.HeaderText = "Núm. Lote";
            this.numeroLote.Name = "numeroLote";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 240;
            // 
            // prazoExecucao
            // 
            this.prazoExecucao.DataPropertyName = "PrazoExecucao";
            this.prazoExecucao.HeaderText = "Prazo Execução";
            this.prazoExecucao.Name = "prazoExecucao";
            this.prazoExecucao.Width = 130;
            // 
            // orcamento
            // 
            this.orcamento.DataPropertyName = "Orcamento";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.orcamento.DefaultCellStyle = dataGridViewCellStyle11;
            this.orcamento.HeaderText = "Orçamento";
            this.orcamento.Name = "orcamento";
            this.orcamento.Width = 190;
            // 
            // lblLotes
            // 
            this.lblLotes.AutoSize = true;
            this.lblLotes.Location = new System.Drawing.Point(9, 324);
            this.lblLotes.Name = "lblLotes";
            this.lblLotes.Size = new System.Drawing.Size(33, 13);
            this.lblLotes.TabIndex = 37;
            this.lblLotes.Text = "Lotes";
            // 
            // lblAcompanhamento
            // 
            this.lblAcompanhamento.AutoSize = true;
            this.lblAcompanhamento.Location = new System.Drawing.Point(9, 447);
            this.lblAcompanhamento.Name = "lblAcompanhamento";
            this.lblAcompanhamento.Size = new System.Drawing.Size(98, 13);
            this.lblAcompanhamento.TabIndex = 39;
            this.lblAcompanhamento.Text = "Acompanhamentos";
            // 
            // dgvAcompanhamento
            // 
            this.dgvAcompanhamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcompanhamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAcompanhamento,
            this.data,
            this.evento});
            this.dgvAcompanhamento.Location = new System.Drawing.Point(11, 463);
            this.dgvAcompanhamento.Name = "dgvAcompanhamento";
            this.dgvAcompanhamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcompanhamento.Size = new System.Drawing.Size(711, 104);
            this.dgvAcompanhamento.TabIndex = 9;
            // 
            // idAcompanhamento
            // 
            this.idAcompanhamento.DataPropertyName = "IdAcompanhamento";
            this.idAcompanhamento.HeaderText = "Id Acomp.";
            this.idAcompanhamento.Name = "idAcompanhamento";
            // 
            // data
            // 
            this.data.DataPropertyName = "Data";
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle12;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.Width = 130;
            // 
            // evento
            // 
            this.evento.DataPropertyName = "Evento";
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.Width = 430;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.rbEncerrado);
            this.gbDestino.Controls.Add(this.rbDescarte);
            this.gbDestino.Controls.Add(this.rbArqMorto);
            this.gbDestino.Controls.Add(this.rbAndamento);
            this.gbDestino.Location = new System.Drawing.Point(12, 573);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(356, 42);
            this.gbDestino.TabIndex = 10;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Destino";
            // 
            // rbEncerrado
            // 
            this.rbEncerrado.AutoSize = true;
            this.rbEncerrado.Location = new System.Drawing.Point(280, 19);
            this.rbEncerrado.Name = "rbEncerrado";
            this.rbEncerrado.Size = new System.Drawing.Size(74, 17);
            this.rbEncerrado.TabIndex = 3;
            this.rbEncerrado.Tag = "3";
            this.rbEncerrado.Text = "Encerrado";
            this.rbEncerrado.UseVisualStyleBackColor = true;
            // 
            // rbDescarte
            // 
            this.rbDescarte.AutoSize = true;
            this.rbDescarte.Location = new System.Drawing.Point(206, 19);
            this.rbDescarte.Name = "rbDescarte";
            this.rbDescarte.Size = new System.Drawing.Size(68, 17);
            this.rbDescarte.TabIndex = 2;
            this.rbDescarte.Tag = "2";
            this.rbDescarte.Text = "Descarte";
            this.rbDescarte.UseVisualStyleBackColor = true;
            // 
            // rbArqMorto
            // 
            this.rbArqMorto.AutoSize = true;
            this.rbArqMorto.Location = new System.Drawing.Point(109, 19);
            this.rbArqMorto.Name = "rbArqMorto";
            this.rbArqMorto.Size = new System.Drawing.Size(91, 17);
            this.rbArqMorto.TabIndex = 1;
            this.rbArqMorto.Tag = "1";
            this.rbArqMorto.Text = "Arquivo Morto";
            this.rbArqMorto.UseVisualStyleBackColor = true;
            // 
            // rbAndamento
            // 
            this.rbAndamento.AutoSize = true;
            this.rbAndamento.Checked = true;
            this.rbAndamento.Location = new System.Drawing.Point(6, 19);
            this.rbAndamento.Name = "rbAndamento";
            this.rbAndamento.Size = new System.Drawing.Size(97, 17);
            this.rbAndamento.TabIndex = 0;
            this.rbAndamento.TabStop = true;
            this.rbAndamento.Tag = "0";
            this.rbAndamento.Text = "Em Andamento";
            this.rbAndamento.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(372, 591);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(186, 20);
            this.txtLocal.TabIndex = 11;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(369, 575);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 42;
            this.lblDestino.Text = "Destino";
            // 
            // lblDataDescarte
            // 
            this.lblDataDescarte.AutoSize = true;
            this.lblDataDescarte.Location = new System.Drawing.Point(564, 575);
            this.lblDataDescarte.Name = "lblDataDescarte";
            this.lblDataDescarte.Size = new System.Drawing.Size(76, 13);
            this.lblDataDescarte.TabIndex = 45;
            this.lblDataDescarte.Text = "Data Descarte";
            // 
            // txtDataDescarte
            // 
            this.txtDataDescarte.CustomFormat = " ";
            this.txtDataDescarte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataDescarte.Location = new System.Drawing.Point(567, 591);
            this.txtDataDescarte.Name = "txtDataDescarte";
            this.txtDataDescarte.Size = new System.Drawing.Size(156, 20);
            this.txtDataDescarte.TabIndex = 12;
            this.txtDataDescarte.ValueChanged += new System.EventHandler(this.txtDataDescarte_ValueChanged);
            this.txtDataDescarte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataDescarte_KeyDown);
            // 
            // frmCadastroEdital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 661);
            this.Controls.Add(this.lblDataDescarte);
            this.Controls.Add(this.txtDataDescarte);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.lblAcompanhamento);
            this.Controls.Add(this.dgvAcompanhamento);
            this.Controls.Add(this.lblLotes);
            this.Controls.Add(this.dgvLote);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObjeto);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.lblDataHoraEntrega);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.cbResponsavel);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.cbContratante);
            this.Controls.Add(this.lblContratante);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.txtNumEdital);
            this.Controls.Add(this.lblNumEdital);
            this.Controls.Add(this.txtNumIdentificacao);
            this.Controls.Add(this.lblIdentificacao);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroEdital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Cadastro Edital";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhamento)).EndInit();
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.TextBox txtNumIdentificacao;
        private System.Windows.Forms.TextBox txtNumEdital;
        private System.Windows.Forms.Label lblNumEdital;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblContratante;
        private System.Windows.Forms.ComboBox cbContratante;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.ComboBox cbResponsavel;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Label lblDataHoraEntrega;
        private System.Windows.Forms.Label lblObjeto;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.Label lblLotes;
        private System.Windows.Forms.Label lblAcompanhamento;
        private System.Windows.Forms.DataGridView dgvAcompanhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoExecucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn orcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAcompanhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.RadioButton rbEncerrado;
        private System.Windows.Forms.RadioButton rbDescarte;
        private System.Windows.Forms.RadioButton rbArqMorto;
        private System.Windows.Forms.RadioButton rbAndamento;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblDataDescarte;
        private System.Windows.Forms.DateTimePicker txtDataDescarte;
    }
}