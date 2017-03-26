namespace Sial.View.Relatorio.Padrao
{
    partial class frmGridRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEdital = new System.Windows.Forms.DataGridView();
            this.IdEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contratante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkEncerrado = new System.Windows.Forms.CheckBox();
            this.lblPesquisaEmpresas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRelCapa = new System.Windows.Forms.Button();
            this.btnEtiqueta = new System.Windows.Forms.Button();
            this.btnParticipantes = new System.Windows.Forms.Button();
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
            this.dgvEdital.Location = new System.Drawing.Point(16, 93);
            this.dgvEdital.MultiSelect = false;
            this.dgvEdital.Name = "dgvEdital";
            this.dgvEdital.ReadOnly = true;
            this.dgvEdital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdital.ShowCellErrors = false;
            this.dgvEdital.ShowCellToolTips = false;
            this.dgvEdital.ShowEditingIcon = false;
            this.dgvEdital.ShowRowErrors = false;
            this.dgvEdital.Size = new System.Drawing.Size(867, 289);
            this.dgvEdital.TabIndex = 17;
            this.dgvEdital.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEdital_CellFormatting);
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
            dataGridViewCellStyle5.NullValue = null;
            this.Apelido.DefaultCellStyle = dataGridViewCellStyle5;
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            this.Apelido.Width = 300;
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataHoraEntrega";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.DataEntrega.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataEntrega.HeaderText = "Data Entrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            // 
            // chkEncerrado
            // 
            this.chkEncerrado.AutoSize = true;
            this.chkEncerrado.Location = new System.Drawing.Point(803, 69);
            this.chkEncerrado.Name = "chkEncerrado";
            this.chkEncerrado.Size = new System.Drawing.Size(80, 17);
            this.chkEncerrado.TabIndex = 19;
            this.chkEncerrado.Text = "Encerrados";
            this.chkEncerrado.UseVisualStyleBackColor = true;
            // 
            // lblPesquisaEmpresas
            // 
            this.lblPesquisaEmpresas.AutoSize = true;
            this.lblPesquisaEmpresas.Location = new System.Drawing.Point(13, 51);
            this.lblPesquisaEmpresas.Name = "lblPesquisaEmpresas";
            this.lblPesquisaEmpresas.Size = new System.Drawing.Size(79, 13);
            this.lblPesquisaEmpresas.TabIndex = 16;
            this.lblPesquisaEmpresas.Text = "Pesquisa Edital";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(889, 65);
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
            this.txtPesquisa.Size = new System.Drawing.Size(781, 20);
            this.txtPesquisa.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 24);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Edital";
            // 
            // btnRelCapa
            // 
            this.btnRelCapa.Location = new System.Drawing.Point(889, 94);
            this.btnRelCapa.Name = "btnRelCapa";
            this.btnRelCapa.Size = new System.Drawing.Size(109, 23);
            this.btnRelCapa.TabIndex = 20;
            this.btnRelCapa.Text = "Capa";
            this.btnRelCapa.UseVisualStyleBackColor = true;
            this.btnRelCapa.Click += new System.EventHandler(this.btnRelCapa_Click);
            // 
            // btnEtiqueta
            // 
            this.btnEtiqueta.Location = new System.Drawing.Point(889, 123);
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(109, 23);
            this.btnEtiqueta.TabIndex = 21;
            this.btnEtiqueta.Text = "Etiqueta";
            this.btnEtiqueta.UseVisualStyleBackColor = true;
            this.btnEtiqueta.Click += new System.EventHandler(this.btnEtiqueta_Click);
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.Location = new System.Drawing.Point(889, 152);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(109, 23);
            this.btnParticipantes.TabIndex = 22;
            this.btnParticipantes.Text = "Participantes";
            this.btnParticipantes.UseVisualStyleBackColor = true;
            this.btnParticipantes.Click += new System.EventHandler(this.btnParticipantes_Click);
            // 
            // frmGridRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 392);
            this.Controls.Add(this.btnParticipantes);
            this.Controls.Add(this.btnEtiqueta);
            this.Controls.Add(this.btnRelCapa);
            this.Controls.Add(this.dgvEdital);
            this.Controls.Add(this.chkEncerrado);
            this.Controls.Add(this.lblPesquisaEmpresas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGridRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contratante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
        private System.Windows.Forms.CheckBox chkEncerrado;
        private System.Windows.Forms.Label lblPesquisaEmpresas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRelCapa;
        private System.Windows.Forms.Button btnEtiqueta;
        private System.Windows.Forms.Button btnParticipantes;
    }
}