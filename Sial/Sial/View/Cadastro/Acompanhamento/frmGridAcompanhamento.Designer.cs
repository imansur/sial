namespace Sial.View.Cadastro.Acompanhamento
{
    partial class frmGridAcompanhamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAcompanhamento = new System.Windows.Forms.DataGridView();
            this.chkEncerrado = new System.Windows.Forms.CheckBox();
            this.lblPesquisaLote = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.IdEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAcompanhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcompanhamento
            // 
            this.dgvAcompanhamento.AllowUserToAddRows = false;
            this.dgvAcompanhamento.AllowUserToDeleteRows = false;
            this.dgvAcompanhamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcompanhamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEdital,
            this.NumeroEdital,
            this.Apelido,
            this.IdAcompanhamento,
            this.Evento,
            this.Data});
            this.dgvAcompanhamento.Location = new System.Drawing.Point(16, 123);
            this.dgvAcompanhamento.MultiSelect = false;
            this.dgvAcompanhamento.Name = "dgvAcompanhamento";
            this.dgvAcompanhamento.ReadOnly = true;
            this.dgvAcompanhamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcompanhamento.ShowCellErrors = false;
            this.dgvAcompanhamento.ShowCellToolTips = false;
            this.dgvAcompanhamento.ShowEditingIcon = false;
            this.dgvAcompanhamento.ShowRowErrors = false;
            this.dgvAcompanhamento.Size = new System.Drawing.Size(964, 289);
            this.dgvAcompanhamento.TabIndex = 17;
            this.dgvAcompanhamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcompanhamento_CellDoubleClick);
            this.dgvAcompanhamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAcompanhamento_CellFormatting);
            // 
            // chkEncerrado
            // 
            this.chkEncerrado.AutoSize = true;
            this.chkEncerrado.Location = new System.Drawing.Point(785, 70);
            this.chkEncerrado.Name = "chkEncerrado";
            this.chkEncerrado.Size = new System.Drawing.Size(80, 17);
            this.chkEncerrado.TabIndex = 19;
            this.chkEncerrado.Text = "Encerrados";
            this.chkEncerrado.UseVisualStyleBackColor = true;
            // 
            // lblPesquisaLote
            // 
            this.lblPesquisaLote.AutoSize = true;
            this.lblPesquisaLote.Location = new System.Drawing.Point(13, 51);
            this.lblPesquisaLote.Name = "lblPesquisaLote";
            this.lblPesquisaLote.Size = new System.Drawing.Size(139, 13);
            this.lblPesquisaLote.TabIndex = 16;
            this.lblPesquisaLote.Text = "Pesquisa Acompanhamento";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(871, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 67);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(763, 20);
            this.txtPesquisa.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 24);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Acompanhamento";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(16, 94);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(136, 23);
            this.BtnNovo.TabIndex = 18;
            this.BtnNovo.Text = "Novo Acompanhamento";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // IdEdital
            // 
            this.IdEdital.HeaderText = "Id. Edital";
            this.IdEdital.Name = "IdEdital";
            this.IdEdital.ReadOnly = true;
            this.IdEdital.Width = 90;
            // 
            // NumeroEdital
            // 
            this.NumeroEdital.HeaderText = "Núm. Edital";
            this.NumeroEdital.Name = "NumeroEdital";
            this.NumeroEdital.ReadOnly = true;
            this.NumeroEdital.Width = 120;
            // 
            // Apelido
            // 
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            this.Apelido.Width = 260;
            // 
            // IdAcompanhamento
            // 
            this.IdAcompanhamento.DataPropertyName = "IdAcompanhamento";
            this.IdAcompanhamento.HeaderText = "Id Acomp.";
            this.IdAcompanhamento.Name = "IdAcompanhamento";
            this.IdAcompanhamento.ReadOnly = true;
            // 
            // Evento
            // 
            this.Evento.DataPropertyName = "Evento";
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            this.Evento.Width = 250;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle5;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // frmGridAcompanhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 422);
            this.Controls.Add(this.dgvAcompanhamento);
            this.Controls.Add(this.chkEncerrado);
            this.Controls.Add(this.lblPesquisaLote);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridAcompanhamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Grid Acompanhamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcompanhamento;
        private System.Windows.Forms.CheckBox chkEncerrado;
        private System.Windows.Forms.Label lblPesquisaLote;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAcompanhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}