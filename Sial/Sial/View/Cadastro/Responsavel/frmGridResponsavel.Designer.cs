namespace Sial.View.Cadastro.Responsavel
{
    partial class frmGridResponsavel
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
            this.dgvResp = new System.Windows.Forms.DataGridView();
            this.lblPesquisaEmpresas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IdResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResp)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(18, 84);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(126, 23);
            this.BtnNovo.TabIndex = 17;
            this.BtnNovo.Text = "Novo Responsável";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // dgvResp
            // 
            this.dgvResp.AllowUserToAddRows = false;
            this.dgvResp.AllowUserToDeleteRows = false;
            this.dgvResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdResponsavel,
            this.Nome});
            this.dgvResp.Location = new System.Drawing.Point(18, 113);
            this.dgvResp.MultiSelect = false;
            this.dgvResp.Name = "dgvResp";
            this.dgvResp.ReadOnly = true;
            this.dgvResp.ShowCellErrors = false;
            this.dgvResp.ShowCellToolTips = false;
            this.dgvResp.ShowEditingIcon = false;
            this.dgvResp.ShowRowErrors = false;
            this.dgvResp.Size = new System.Drawing.Size(741, 289);
            this.dgvResp.TabIndex = 14;
            this.dgvResp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResp_CellDoubleClick);
            // 
            // lblPesquisaEmpresas
            // 
            this.lblPesquisaEmpresas.AutoSize = true;
            this.lblPesquisaEmpresas.Location = new System.Drawing.Point(15, 41);
            this.lblPesquisaEmpresas.Name = "lblPesquisaEmpresas";
            this.lblPesquisaEmpresas.Size = new System.Drawing.Size(115, 13);
            this.lblPesquisaEmpresas.TabIndex = 16;
            this.lblPesquisaEmpresas.Text = "Pesquisa Responsável";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(649, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(18, 57);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(625, 20);
            this.txtPesquisa.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(14, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 24);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Responsável";
            // 
            // IdResponsavel
            // 
            this.IdResponsavel.DataPropertyName = "IdResponsavel";
            this.IdResponsavel.HeaderText = "Id. Resp.";
            this.IdResponsavel.Name = "IdResponsavel";
            this.IdResponsavel.ReadOnly = true;
            this.IdResponsavel.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 580;
            // 
            // frmGridResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 412);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.dgvResp);
            this.Controls.Add(this.lblPesquisaEmpresas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGridResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sial - Grid Responsável";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView dgvResp;
        private System.Windows.Forms.Label lblPesquisaEmpresas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}