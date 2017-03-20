﻿namespace Sial.View.Cadastro.Empresa
{
    partial class frmGridEmpresa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisaEmpresas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Empresas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(625, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(647, 63);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisaEmpresas
            // 
            this.lblPesquisaEmpresas.AutoSize = true;
            this.lblPesquisaEmpresas.Location = new System.Drawing.Point(13, 49);
            this.lblPesquisaEmpresas.Name = "lblPesquisaEmpresas";
            this.lblPesquisaEmpresas.Size = new System.Drawing.Size(99, 13);
            this.lblPesquisaEmpresas.TabIndex = 3;
            this.lblPesquisaEmpresas.Text = "Pesquisa Empresas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.IdEmpresa,
            this.Nome});
            this.dataGridView1.Location = new System.Drawing.Point(16, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 289);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Width = 50;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.HeaderText = "Id. Empresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.ReadOnly = true;
            this.IdEmpresa.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 580;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(16, 92);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(96, 23);
            this.BtnNovo.TabIndex = 5;
            this.BtnNovo.Text = "Nova Empresa";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // frmGridEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 422);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPesquisaEmpresas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GridEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblPesquisaEmpresas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button BtnNovo;
    }
}