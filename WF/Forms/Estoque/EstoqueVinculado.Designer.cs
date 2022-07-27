namespace WF.Forms.Estoque
{
    partial class EstoqueVinculado
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.txtTotalDisponivel = new System.Windows.Forms.TextBox();
            this.txtTotalPrevisto = new System.Windows.Forms.TextBox();
            this.txtTotalEstoque = new System.Windows.Forms.TextBox();
            this.lblTotalVinculado = new System.Windows.Forms.Label();
            this.lblTotalDisponivel = new System.Windows.Forms.Label();
            this.lblTotalEstoque = new System.Windows.Forms.Label();
            this.dgvEstoqueVinculado = new System.Windows.Forms.DataGridView();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueVinculado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.BtnVoltar);
            this.pnlPrincipal.Controls.Add(this.txtTotalDisponivel);
            this.pnlPrincipal.Controls.Add(this.txtTotalPrevisto);
            this.pnlPrincipal.Controls.Add(this.txtTotalEstoque);
            this.pnlPrincipal.Controls.Add(this.lblTotalVinculado);
            this.pnlPrincipal.Controls.Add(this.lblTotalDisponivel);
            this.pnlPrincipal.Controls.Add(this.lblTotalEstoque);
            this.pnlPrincipal.Controls.Add(this.dgvEstoqueVinculado);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(595, 450);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(496, 408);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // txtTotalDisponivel
            // 
            this.txtTotalDisponivel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDisponivel.Location = new System.Drawing.Point(503, 372);
            this.txtTotalDisponivel.Name = "txtTotalDisponivel";
            this.txtTotalDisponivel.Size = new System.Drawing.Size(68, 23);
            this.txtTotalDisponivel.TabIndex = 6;
            // 
            // txtTotalPrevisto
            // 
            this.txtTotalPrevisto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrevisto.Location = new System.Drawing.Point(314, 372);
            this.txtTotalPrevisto.Name = "txtTotalPrevisto";
            this.txtTotalPrevisto.Size = new System.Drawing.Size(68, 23);
            this.txtTotalPrevisto.TabIndex = 5;
            // 
            // txtTotalEstoque
            // 
            this.txtTotalEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEstoque.Location = new System.Drawing.Point(118, 372);
            this.txtTotalEstoque.Name = "txtTotalEstoque";
            this.txtTotalEstoque.Size = new System.Drawing.Size(68, 23);
            this.txtTotalEstoque.TabIndex = 4;
            // 
            // lblTotalVinculado
            // 
            this.lblTotalVinculado.AutoSize = true;
            this.lblTotalVinculado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVinculado.Location = new System.Drawing.Point(199, 375);
            this.lblTotalVinculado.Name = "lblTotalVinculado";
            this.lblTotalVinculado.Size = new System.Drawing.Size(109, 17);
            this.lblTotalVinculado.TabIndex = 3;
            this.lblTotalVinculado.Text = "Total Vinculado";
            // 
            // lblTotalDisponivel
            // 
            this.lblTotalDisponivel.AutoSize = true;
            this.lblTotalDisponivel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDisponivel.Location = new System.Drawing.Point(388, 375);
            this.lblTotalDisponivel.Name = "lblTotalDisponivel";
            this.lblTotalDisponivel.Size = new System.Drawing.Size(109, 17);
            this.lblTotalDisponivel.TabIndex = 2;
            this.lblTotalDisponivel.Text = "Total Disponível";
            // 
            // lblTotalEstoque
            // 
            this.lblTotalEstoque.AutoSize = true;
            this.lblTotalEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEstoque.Location = new System.Drawing.Point(18, 375);
            this.lblTotalEstoque.Name = "lblTotalEstoque";
            this.lblTotalEstoque.Size = new System.Drawing.Size(94, 17);
            this.lblTotalEstoque.TabIndex = 1;
            this.lblTotalEstoque.Text = "Total Estoque";
            // 
            // dgvEstoqueVinculado
            // 
            this.dgvEstoqueVinculado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueVinculado.Location = new System.Drawing.Point(12, 41);
            this.dgvEstoqueVinculado.Name = "dgvEstoqueVinculado";
            this.dgvEstoqueVinculado.Size = new System.Drawing.Size(571, 325);
            this.dgvEstoqueVinculado.TabIndex = 0;
            // 
            // EstoqueVinculado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstoqueVinculado";
            this.Text = "EstoqueVinculado";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueVinculado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.TextBox txtTotalDisponivel;
        internal System.Windows.Forms.TextBox txtTotalPrevisto;
        internal System.Windows.Forms.TextBox txtTotalEstoque;
        internal System.Windows.Forms.Label lblTotalVinculado;
        internal System.Windows.Forms.Label lblTotalDisponivel;
        internal System.Windows.Forms.Label lblTotalEstoque;
        internal System.Windows.Forms.DataGridView dgvEstoqueVinculado;
    }
}