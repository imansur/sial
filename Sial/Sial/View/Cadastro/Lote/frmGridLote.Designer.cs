namespace Sial.View.Cadastro.Lote
{
    partial class frmGridLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.lblPesquisaLote = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.chkEncerrado = new System.Windows.Forms.CheckBox();
            this.IdEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoExecucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEdital,
            this.Apelido,
            this.IdLote,
            this.NumeroLote,
            this.Descricao,
            this.PrazoExecucao});
            this.dgvLote.Location = new System.Drawing.Point(16, 123);
            this.dgvLote.MultiSelect = false;
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.ShowCellErrors = false;
            this.dgvLote.ShowCellToolTips = false;
            this.dgvLote.ShowEditingIcon = false;
            this.dgvLote.ShowRowErrors = false;
            this.dgvLote.Size = new System.Drawing.Size(964, 289);
            this.dgvLote.TabIndex = 10;
            this.dgvLote.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLote_CellDoubleClick);
            this.dgvLote.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLote_CellFormatting);
            // 
            // lblPesquisaLote
            // 
            this.lblPesquisaLote.AutoSize = true;
            this.lblPesquisaLote.Location = new System.Drawing.Point(13, 51);
            this.lblPesquisaLote.Name = "lblPesquisaLote";
            this.lblPesquisaLote.Size = new System.Drawing.Size(74, 13);
            this.lblPesquisaLote.TabIndex = 9;
            this.lblPesquisaLote.Text = "Pesquisa Lote";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(871, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 67);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(763, 20);
            this.txtPesquisa.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Lote";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(16, 94);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(96, 23);
            this.BtnNovo.TabIndex = 11;
            this.BtnNovo.Text = "Novo Lote";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // chkEncerrado
            // 
            this.chkEncerrado.AutoSize = true;
            this.chkEncerrado.Location = new System.Drawing.Point(785, 70);
            this.chkEncerrado.Name = "chkEncerrado";
            this.chkEncerrado.Size = new System.Drawing.Size(80, 17);
            this.chkEncerrado.TabIndex = 12;
            this.chkEncerrado.Text = "Encerrados";
            this.chkEncerrado.UseVisualStyleBackColor = true;
            // 
            // IdEdital
            // 
            this.IdEdital.HeaderText = "Id. Edital";
            this.IdEdital.Name = "IdEdital";
            this.IdEdital.ReadOnly = true;
            this.IdEdital.Width = 90;
            // 
            // Apelido
            // 
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            this.Apelido.Width = 240;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "Id Lote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            // 
            // NumeroLote
            // 
            this.NumeroLote.DataPropertyName = "NumeroLote";
            this.NumeroLote.HeaderText = "Número Lote";
            this.NumeroLote.Name = "NumeroLote";
            this.NumeroLote.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 240;
            // 
            // PrazoExecucao
            // 
            this.PrazoExecucao.DataPropertyName = "PrazoExecucao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PrazoExecucao.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrazoExecucao.HeaderText = "Prazo Execução(Dias)";
            this.PrazoExecucao.Name = "PrazoExecucao";
            this.PrazoExecucao.ReadOnly = true;
            this.PrazoExecucao.Width = 140;
            // 
            // frmGridLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 422);
            this.Controls.Add(this.chkEncerrado);
            this.Controls.Add(this.dgvLote);
            this.Controls.Add(this.lblPesquisaLote);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Grid Lote";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.Label lblPesquisaLote;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.CheckBox chkEncerrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoExecucao;
    }
}