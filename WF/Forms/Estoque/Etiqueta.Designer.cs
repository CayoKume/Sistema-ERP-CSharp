namespace WF.Forms.Estoque
{
    partial class Etiqueta
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
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnConfiguracao = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.dgvBuscaProdutos = new System.Windows.Forms.DataGridView();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.ComboBox2);
            this.pnlPrincipal.Controls.Add(this.ComboBox1);
            this.pnlPrincipal.Controls.Add(this.Label2);
            this.pnlPrincipal.Controls.Add(this.Label1);
            this.pnlPrincipal.Controls.Add(this.BtnImprimir);
            this.pnlPrincipal.Controls.Add(this.BtnExcluir);
            this.pnlPrincipal.Controls.Add(this.BtnAdicionar);
            this.pnlPrincipal.Controls.Add(this.BtnConfiguracao);
            this.pnlPrincipal.Controls.Add(this.BtnVoltar);
            this.pnlPrincipal.Controls.Add(this.dgvBuscaProdutos);
            this.pnlPrincipal.Controls.Add(this.cboProduto);
            this.pnlPrincipal.Controls.Add(this.txtQuantidade);
            this.pnlPrincipal.Controls.Add(this.txtReferencia);
            this.pnlPrincipal.Controls.Add(this.lblQuantidade);
            this.pnlPrincipal.Controls.Add(this.lblProduto);
            this.pnlPrincipal.Controls.Add(this.lblReferencia);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(690, 382);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // ComboBox2
            // 
            this.ComboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(543, 58);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(104, 25);
            this.ComboBox2.TabIndex = 47;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(419, 58);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(104, 25);
            this.ComboBox1.TabIndex = 46;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(540, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(135, 17);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Formato da Página";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(415, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 17);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "Modelo Etiqueta";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(522, 340);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 30);
            this.BtnImprimir.TabIndex = 43;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(441, 340);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 30);
            this.BtnExcluir.TabIndex = 42;
            this.BtnExcluir.Text = "Remover";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(353, 340);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(82, 30);
            this.BtnAdicionar.TabIndex = 41;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtnConfiguracao
            // 
            this.BtnConfiguracao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracao.Location = new System.Drawing.Point(12, 340);
            this.BtnConfiguracao.Name = "BtnConfiguracao";
            this.BtnConfiguracao.Size = new System.Drawing.Size(109, 30);
            this.BtnConfiguracao.TabIndex = 40;
            this.BtnConfiguracao.Text = "Configuração";
            this.BtnConfiguracao.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(603, 340);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 38;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvBuscaProdutos
            // 
            this.dgvBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaProdutos.Location = new System.Drawing.Point(12, 89);
            this.dgvBuscaProdutos.Name = "dgvBuscaProdutos";
            this.dgvBuscaProdutos.Size = new System.Drawing.Size(666, 245);
            this.dgvBuscaProdutos.TabIndex = 37;
            // 
            // cboProduto
            // 
            this.cboProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(12, 58);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(194, 25);
            this.cboProduto.TabIndex = 10;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(325, 59);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(77, 23);
            this.txtQuantidade.TabIndex = 7;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(212, 59);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(100, 23);
            this.txtReferencia.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(322, 38);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(87, 17);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 38);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(60, 17);
            this.lblProduto.TabIndex = 4;
            this.lblProduto.Text = "Produto";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(209, 38);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(76, 17);
            this.lblReferencia.TabIndex = 1;
            this.lblReferencia.Text = "Referência";
            // 
            // Etiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 382);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Etiqueta";
            this.Text = "Etiquetas";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnImprimir;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnAdicionar;
        internal System.Windows.Forms.Button BtnConfiguracao;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.DataGridView dgvBuscaProdutos;
        internal System.Windows.Forms.ComboBox cboProduto;
        internal System.Windows.Forms.TextBox txtQuantidade;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.Label lblQuantidade;
        internal System.Windows.Forms.Label lblProduto;
        internal System.Windows.Forms.Label lblReferencia;
    }
}