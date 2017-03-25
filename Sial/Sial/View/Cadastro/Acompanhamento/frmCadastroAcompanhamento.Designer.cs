namespace Sial.View.Cadastro.Acompanhamento
{
    partial class frmCadastroAcompanhamento
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
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cbEdital = new System.Windows.Forms.ComboBox();
            this.lblEdital = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(495, 85);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(400, 20);
            this.txtEvento.TabIndex = 74;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(492, 68);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(41, 13);
            this.lblEvento.TabIndex = 85;
            this.lblEvento.Text = "Evento";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(323, 67);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 84;
            this.lblData.Text = "Data";
            // 
            // cbEdital
            // 
            this.cbEdital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEdital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEdital.FormattingEnabled = true;
            this.cbEdital.Location = new System.Drawing.Point(19, 84);
            this.cbEdital.Name = "cbEdital";
            this.cbEdital.Size = new System.Drawing.Size(297, 21);
            this.cbEdital.TabIndex = 72;
            // 
            // lblEdital
            // 
            this.lblEdital.AutoSize = true;
            this.lblEdital.Location = new System.Drawing.Point(16, 67);
            this.lblEdital.Name = "lblEdital";
            this.lblEdital.Size = new System.Drawing.Size(33, 13);
            this.lblEdital.TabIndex = 83;
            this.lblEdital.Text = "Edital";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 24);
            this.lblTitulo.TabIndex = 81;
            this.lblTitulo.Text = "Cadastro Acompanhamento";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(820, 258);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 80;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(739, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 79;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(13, 36);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 18);
            this.lblTipo.TabIndex = 82;
            this.lblTipo.Text = "lblTipo";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(326, 84);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(163, 20);
            this.txtData.TabIndex = 86;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 108);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(65, 13);
            this.lblObs.TabIndex = 87;
            this.lblObs.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(19, 125);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(875, 127);
            this.txtObservacao.TabIndex = 88;
            // 
            // frmCadastroAcompanhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 294);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbEdital);
            this.Controls.Add(this.lblEdital);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroAcompanhamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroAcompanhamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbEdital;
        private System.Windows.Forms.Label lblEdital;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}