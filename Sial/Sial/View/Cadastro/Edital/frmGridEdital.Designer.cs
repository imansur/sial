namespace Sial.View.Cadastro.Edital
{
    partial class frmGridEdital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEdital = new System.Windows.Forms.DataGridView();
            this.lblPesquisaEmpresas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.chkEncerrado = new System.Windows.Forms.CheckBox();
            this.IdEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contratante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdital)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEdital
            // 
            this.dgvEdital.AllowUserToAddRows = false;
            this.dgvEdital.AllowUserToDeleteRows = false;
            this.dgvEdital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdital.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEdital,
            this.numeroEdital,
            this.Contratante,
            this.Apelido,
            this.DataEntrega});
            this.dgvEdital.Location = new System.Drawing.Point(16, 123);
            this.dgvEdital.MultiSelect = false;
            this.dgvEdital.Name = "dgvEdital";
            this.dgvEdital.ReadOnly = true;
            this.dgvEdital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdital.ShowCellErrors = false;
            this.dgvEdital.ShowCellToolTips = false;
            this.dgvEdital.ShowEditingIcon = false;
            this.dgvEdital.ShowRowErrors = false;
            this.dgvEdital.Size = new System.Drawing.Size(982, 289);
            this.dgvEdital.TabIndex = 10;
            this.dgvEdital.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdital_CellDoubleClick);
            this.dgvEdital.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEdital_CellFormatting);
            // 
            // lblPesquisaEmpresas
            // 
            this.lblPesquisaEmpresas.AutoSize = true;
            this.lblPesquisaEmpresas.Location = new System.Drawing.Point(13, 51);
            this.lblPesquisaEmpresas.Name = "lblPesquisaEmpresas";
            this.lblPesquisaEmpresas.Size = new System.Drawing.Size(79, 13);
            this.lblPesquisaEmpresas.TabIndex = 9;
            this.lblPesquisaEmpresas.Text = "Pesquisa Edital";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(889, 65);
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
            this.txtPesquisa.Size = new System.Drawing.Size(781, 20);
            this.txtPesquisa.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Edital";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(16, 94);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(96, 23);
            this.BtnNovo.TabIndex = 11;
            this.BtnNovo.Text = "Novo Edital";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // chkEncerrado
            // 
            this.chkEncerrado.AutoSize = true;
            this.chkEncerrado.Location = new System.Drawing.Point(803, 69);
            this.chkEncerrado.Name = "chkEncerrado";
            this.chkEncerrado.Size = new System.Drawing.Size(80, 17);
            this.chkEncerrado.TabIndex = 12;
            this.chkEncerrado.Text = "Encerrados";
            this.chkEncerrado.UseVisualStyleBackColor = true;
            // 
            // IdEdital
            // 
            this.IdEdital.DataPropertyName = "IdEdital";
            this.IdEdital.HeaderText = "Id. Edital";
            this.IdEdital.Name = "IdEdital";
            this.IdEdital.ReadOnly = true;
            this.IdEdital.Width = 80;
            // 
            // numeroEdital
            // 
            this.numeroEdital.DataPropertyName = "NumeroEdital";
            this.numeroEdital.HeaderText = "Núm. Edital";
            this.numeroEdital.Name = "numeroEdital";
            this.numeroEdital.ReadOnly = true;
            this.numeroEdital.Width = 150;
            // 
            // Contratante
            // 
            this.Contratante.DataPropertyName = "Orgao.Nome";
            this.Contratante.HeaderText = "Contratante";
            this.Contratante.Name = "Contratante";
            this.Contratante.ReadOnly = true;
            this.Contratante.Width = 300;
            // 
            // Apelido
            // 
            this.Apelido.DataPropertyName = "Apelido";
            dataGridViewCellStyle1.NullValue = null;
            this.Apelido.DefaultCellStyle = dataGridViewCellStyle1;
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            this.Apelido.Width = 300;
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataHoraEntrega";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataEntrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataEntrega.HeaderText = "Data Entrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            // 
            // frmGridEdital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 422);
            this.Controls.Add(this.chkEncerrado);
            this.Controls.Add(this.dgvEdital);
            this.Controls.Add(this.lblPesquisaEmpresas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridEdital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Grid Edital";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEdital;
        private System.Windows.Forms.Label lblPesquisaEmpresas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.CheckBox chkEncerrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contratante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
    }
}