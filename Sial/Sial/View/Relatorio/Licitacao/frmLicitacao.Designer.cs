namespace Sial.View.Relatorio.Licitacao
{
    partial class frmLicitacao
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGerarRel = new System.Windows.Forms.Button();
            this.lblDataDe = new System.Windows.Forms.Label();
            this.lblDataAte = new System.Windows.Forms.Label();
            this.txtDataDe = new System.Windows.Forms.DateTimePicker();
            this.txtDataAte = new System.Windows.Forms.DateTimePicker();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.rbEncerrado = new System.Windows.Forms.RadioButton();
            this.rbDescarte = new System.Windows.Forms.RadioButton();
            this.rbArqMorto = new System.Windows.Forms.RadioButton();
            this.rbAndamento = new System.Windows.Forms.RadioButton();
            this.gbDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Relatório de Licitações";
            // 
            // btnGerarRel
            // 
            this.btnGerarRel.Location = new System.Drawing.Point(523, 80);
            this.btnGerarRel.Name = "btnGerarRel";
            this.btnGerarRel.Size = new System.Drawing.Size(94, 23);
            this.btnGerarRel.TabIndex = 8;
            this.btnGerarRel.Text = "Gerar Relatório";
            this.btnGerarRel.UseVisualStyleBackColor = true;
            this.btnGerarRel.Click += new System.EventHandler(this.btnGerarRel_Click);
            // 
            // lblDataDe
            // 
            this.lblDataDe.AutoSize = true;
            this.lblDataDe.Location = new System.Drawing.Point(16, 37);
            this.lblDataDe.Name = "lblDataDe";
            this.lblDataDe.Size = new System.Drawing.Size(47, 13);
            this.lblDataDe.TabIndex = 9;
            this.lblDataDe.Text = "Data De";
            // 
            // lblDataAte
            // 
            this.lblDataAte.AutoSize = true;
            this.lblDataAte.Location = new System.Drawing.Point(138, 38);
            this.lblDataAte.Name = "lblDataAte";
            this.lblDataAte.Size = new System.Drawing.Size(49, 13);
            this.lblDataAte.TabIndex = 10;
            this.lblDataAte.Text = "Data Até";
            // 
            // txtDataDe
            // 
            this.txtDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataDe.Location = new System.Drawing.Point(19, 54);
            this.txtDataDe.Name = "txtDataDe";
            this.txtDataDe.Size = new System.Drawing.Size(116, 20);
            this.txtDataDe.TabIndex = 11;
            // 
            // txtDataAte
            // 
            this.txtDataAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataAte.Location = new System.Drawing.Point(141, 54);
            this.txtDataAte.Name = "txtDataAte";
            this.txtDataAte.Size = new System.Drawing.Size(116, 20);
            this.txtDataAte.TabIndex = 12;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.rbEncerrado);
            this.gbDestino.Controls.Add(this.rbDescarte);
            this.gbDestino.Controls.Add(this.rbArqMorto);
            this.gbDestino.Controls.Add(this.rbAndamento);
            this.gbDestino.Location = new System.Drawing.Point(263, 32);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(356, 42);
            this.gbDestino.TabIndex = 13;
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
            // frmLicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 110);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.txtDataAte);
            this.Controls.Add(this.txtDataDe);
            this.Controls.Add(this.lblDataAte);
            this.Controls.Add(this.lblDataDe);
            this.Controls.Add(this.btnGerarRel);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmLicitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Relatório de Licitações";
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGerarRel;
        private System.Windows.Forms.Label lblDataDe;
        private System.Windows.Forms.Label lblDataAte;
        private System.Windows.Forms.DateTimePicker txtDataDe;
        private System.Windows.Forms.DateTimePicker txtDataAte;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.RadioButton rbEncerrado;
        private System.Windows.Forms.RadioButton rbDescarte;
        private System.Windows.Forms.RadioButton rbArqMorto;
        private System.Windows.Forms.RadioButton rbAndamento;
    }
}