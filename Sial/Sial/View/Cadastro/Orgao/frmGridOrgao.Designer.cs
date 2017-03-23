namespace Sial.View.Cadastro.Orgao
{
    partial class frmGridOrgao
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
            this.BtnNovo = new System.Windows.Forms.Button();
            this.dgvOrgao = new System.Windows.Forms.DataGridView();
            this.lblPesquisaEmpresas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IdOrgao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgao)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(16, 83);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(96, 23);
            this.BtnNovo.TabIndex = 11;
            this.BtnNovo.Text = "Novo Orgão";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // dgvOrgao
            // 
            this.dgvOrgao.AllowUserToAddRows = false;
            this.dgvOrgao.AllowUserToDeleteRows = false;
            this.dgvOrgao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrgao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrgao,
            this.Nome});
            this.dgvOrgao.Location = new System.Drawing.Point(16, 112);
            this.dgvOrgao.MultiSelect = false;
            this.dgvOrgao.Name = "dgvOrgao";
            this.dgvOrgao.ReadOnly = true;
            this.dgvOrgao.ShowCellErrors = false;
            this.dgvOrgao.ShowCellToolTips = false;
            this.dgvOrgao.ShowEditingIcon = false;
            this.dgvOrgao.ShowRowErrors = false;
            this.dgvOrgao.Size = new System.Drawing.Size(741, 289);
            this.dgvOrgao.TabIndex = 2;
            this.dgvOrgao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrgao_CellDoubleClick);
            // 
            // lblPesquisaEmpresas
            // 
            this.lblPesquisaEmpresas.AutoSize = true;
            this.lblPesquisaEmpresas.Location = new System.Drawing.Point(13, 40);
            this.lblPesquisaEmpresas.Name = "lblPesquisaEmpresas";
            this.lblPesquisaEmpresas.Size = new System.Drawing.Size(82, 13);
            this.lblPesquisaEmpresas.TabIndex = 9;
            this.lblPesquisaEmpresas.Text = "Pesquisa Orgao";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(647, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 56);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(625, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Orgão";
            // 
            // IdOrgao
            // 
            this.IdOrgao.DataPropertyName = "IdOrgao";
            this.IdOrgao.HeaderText = "Id. Orgão";
            this.IdOrgao.Name = "IdOrgao";
            this.IdOrgao.ReadOnly = true;
            this.IdOrgao.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 580;
            // 
            // frmGridOrgao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 412);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.dgvOrgao);
            this.Controls.Add(this.lblPesquisaEmpresas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridOrgao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Grid Orgão";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView dgvOrgao;
        private System.Windows.Forms.Label lblPesquisaEmpresas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrgao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}