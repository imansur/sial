namespace Sial.View.Cadastro.Lote
{
    partial class frmCadastroLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEdital = new System.Windows.Forms.Label();
            this.cbEdital = new System.Windows.Forms.ComboBox();
            this.lblNumLote = new System.Windows.Forms.Label();
            this.txtNumeroLote = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtPrazoExecucao = new System.Windows.Forms.TextBox();
            this.lblPrazoExec = new System.Windows.Forms.Label();
            this.lblOrçamento = new System.Windows.Forms.Label();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.chkVencedor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvLoteEmpresa = new System.Windows.Forms.DataGridView();
            this.IdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtProposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoteEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 36);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 18);
            this.lblTipo.TabIndex = 62;
            this.lblTipo.Text = "lblTipo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 24);
            this.lblTitulo.TabIndex = 61;
            this.lblTitulo.Text = "Cadastro Lote";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(819, 393);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(738, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblEdital
            // 
            this.lblEdital.AutoSize = true;
            this.lblEdital.Location = new System.Drawing.Point(15, 67);
            this.lblEdital.Name = "lblEdital";
            this.lblEdital.Size = new System.Drawing.Size(33, 13);
            this.lblEdital.TabIndex = 63;
            this.lblEdital.Text = "Edital";
            // 
            // cbEdital
            // 
            this.cbEdital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEdital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEdital.FormattingEnabled = true;
            this.cbEdital.Location = new System.Drawing.Point(18, 84);
            this.cbEdital.Name = "cbEdital";
            this.cbEdital.Size = new System.Drawing.Size(297, 21);
            this.cbEdital.TabIndex = 0;
            // 
            // lblNumLote
            // 
            this.lblNumLote.AutoSize = true;
            this.lblNumLote.Location = new System.Drawing.Point(322, 67);
            this.lblNumLote.Name = "lblNumLote";
            this.lblNumLote.Size = new System.Drawing.Size(68, 13);
            this.lblNumLote.TabIndex = 65;
            this.lblNumLote.Text = "Número Lote";
            // 
            // txtNumeroLote
            // 
            this.txtNumeroLote.Location = new System.Drawing.Point(325, 84);
            this.txtNumeroLote.Name = "txtNumeroLote";
            this.txtNumeroLote.Size = new System.Drawing.Size(163, 20);
            this.txtNumeroLote.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(494, 85);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(400, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(491, 68);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 67;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtPrazoExecucao
            // 
            this.txtPrazoExecucao.Location = new System.Drawing.Point(18, 124);
            this.txtPrazoExecucao.Name = "txtPrazoExecucao";
            this.txtPrazoExecucao.Size = new System.Drawing.Size(231, 20);
            this.txtPrazoExecucao.TabIndex = 3;
            // 
            // lblPrazoExec
            // 
            this.lblPrazoExec.AutoSize = true;
            this.lblPrazoExec.Location = new System.Drawing.Point(15, 108);
            this.lblPrazoExec.Name = "lblPrazoExec";
            this.lblPrazoExec.Size = new System.Drawing.Size(130, 13);
            this.lblPrazoExec.TabIndex = 69;
            this.lblPrazoExec.Text = "Prazo Execução(Em Dias)";
            // 
            // lblOrçamento
            // 
            this.lblOrçamento.AutoSize = true;
            this.lblOrçamento.Location = new System.Drawing.Point(255, 108);
            this.lblOrçamento.Name = "lblOrçamento";
            this.lblOrçamento.Size = new System.Drawing.Size(59, 13);
            this.lblOrçamento.TabIndex = 71;
            this.lblOrçamento.Text = "Orçamento";
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Location = new System.Drawing.Point(258, 124);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Size = new System.Drawing.Size(230, 20);
            this.txtOrcamento.TabIndex = 4;
            this.txtOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkVencedor
            // 
            this.chkVencedor.AutoSize = true;
            this.chkVencedor.Location = new System.Drawing.Point(495, 126);
            this.chkVencedor.Name = "chkVencedor";
            this.chkVencedor.Size = new System.Drawing.Size(72, 17);
            this.chkVencedor.TabIndex = 5;
            this.chkVencedor.Text = "Vencedor";
            this.chkVencedor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.dgvLoteEmpresa);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtProposta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 236);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propostas";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(778, 67);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvLoteEmpresa
            // 
            this.dgvLoteEmpresa.AllowUserToAddRows = false;
            this.dgvLoteEmpresa.AllowUserToDeleteRows = false;
            this.dgvLoteEmpresa.AllowUserToOrderColumns = true;
            this.dgvLoteEmpresa.AllowUserToResizeColumns = false;
            this.dgvLoteEmpresa.AllowUserToResizeRows = false;
            this.dgvLoteEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoteEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpresa,
            this.Nome,
            this.Proposta});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoteEmpresa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLoteEmpresa.Location = new System.Drawing.Point(6, 65);
            this.dgvLoteEmpresa.Name = "dgvLoteEmpresa";
            this.dgvLoteEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoteEmpresa.Size = new System.Drawing.Size(765, 150);
            this.dgvLoteEmpresa.TabIndex = 78;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.HeaderText = "Id. Empresa";
            this.IdEmpresa.Name = "IdEmpresa";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 400;
            // 
            // Proposta
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Proposta.DefaultCellStyle = dataGridViewCellStyle5;
            this.Proposta.HeaderText = "Proposta";
            this.Proposta.Name = "Proposta";
            this.Proposta.Width = 220;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(777, 37);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtProposta
            // 
            this.txtProposta.Location = new System.Drawing.Point(541, 39);
            this.txtProposta.Name = "txtProposta";
            this.txtProposta.Size = new System.Drawing.Size(230, 20);
            this.txtProposta.TabIndex = 1;
            this.txtProposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Proposta";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(6, 39);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(529, 21);
            this.cbEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Empresa";
            // 
            // frmCadastroLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkVencedor);
            this.Controls.Add(this.txtOrcamento);
            this.Controls.Add(this.lblOrçamento);
            this.Controls.Add(this.txtPrazoExecucao);
            this.Controls.Add(this.lblPrazoExec);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNumeroLote);
            this.Controls.Add(this.lblNumLote);
            this.Controls.Add(this.cbEdital);
            this.Controls.Add(this.lblEdital);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastroLote";
            this.Text = "Sial - Cadastro Lote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoteEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEdital;
        private System.Windows.Forms.ComboBox cbEdital;
        private System.Windows.Forms.Label lblNumLote;
        private System.Windows.Forms.TextBox txtNumeroLote;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtPrazoExecucao;
        private System.Windows.Forms.Label lblPrazoExec;
        private System.Windows.Forms.Label lblOrçamento;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.CheckBox chkVencedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvLoteEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proposta;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtProposta;
        private System.Windows.Forms.Label label2;
    }
}