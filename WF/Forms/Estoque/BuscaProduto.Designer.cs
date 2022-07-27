namespace WF.Forms.Estoque
{
    partial class BuscaProduto
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.rdoProdutoAcabado = new System.Windows.Forms.RadioButton();
            this.rdoMateriaPrima = new System.Windows.Forms.RadioButton();
            this.rdoServicos = new System.Windows.Forms.RadioButton();
            this.rdoProdutoRevenda = new System.Windows.Forms.RadioButton();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvBuscaProdutos = new System.Windows.Forms.DataGridView();
            this.lboFoto = new System.Windows.Forms.Label();
            this.pctboxProduto = new System.Windows.Forms.PictureBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboFornecedores = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblCategoriaProduto = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.BtnLimpar);
            this.pnlPrincipal.Controls.Add(this.rdoProdutoAcabado);
            this.pnlPrincipal.Controls.Add(this.rdoMateriaPrima);
            this.pnlPrincipal.Controls.Add(this.rdoServicos);
            this.pnlPrincipal.Controls.Add(this.rdoProdutoRevenda);
            this.pnlPrincipal.Controls.Add(this.btnConfiguracao);
            this.pnlPrincipal.Controls.Add(this.btnPesquisar);
            this.pnlPrincipal.Controls.Add(this.btnVoltar);
            this.pnlPrincipal.Controls.Add(this.dgvBuscaProdutos);
            this.pnlPrincipal.Controls.Add(this.lboFoto);
            this.pnlPrincipal.Controls.Add(this.pctboxProduto);
            this.pnlPrincipal.Controls.Add(this.cboStatus);
            this.pnlPrincipal.Controls.Add(this.cboFornecedores);
            this.pnlPrincipal.Controls.Add(this.cboCategoria);
            this.pnlPrincipal.Controls.Add(this.cboTipoProduto);
            this.pnlPrincipal.Controls.Add(this.txtDescricao);
            this.pnlPrincipal.Controls.Add(this.txtReferencia);
            this.pnlPrincipal.Controls.Add(this.lblCategoriaProduto);
            this.pnlPrincipal.Controls.Add(this.lblStatus);
            this.pnlPrincipal.Controls.Add(this.lblFornecedor);
            this.pnlPrincipal.Controls.Add(this.lblTipoProduto);
            this.pnlPrincipal.Controls.Add(this.lblDescricao);
            this.pnlPrincipal.Controls.Add(this.lblReferencia);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(673, 518);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(505, 476);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 45;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // rdoProdutoAcabado
            // 
            this.rdoProdutoAcabado.AutoSize = true;
            this.rdoProdutoAcabado.Location = new System.Drawing.Point(368, 20);
            this.rdoProdutoAcabado.Name = "rdoProdutoAcabado";
            this.rdoProdutoAcabado.Size = new System.Drawing.Size(144, 21);
            this.rdoProdutoAcabado.TabIndex = 44;
            this.rdoProdutoAcabado.TabStop = true;
            this.rdoProdutoAcabado.Text = "Produto Acabado";
            this.rdoProdutoAcabado.UseVisualStyleBackColor = true;
            // 
            // rdoMateriaPrima
            // 
            this.rdoMateriaPrima.AutoSize = true;
            this.rdoMateriaPrima.Location = new System.Drawing.Point(246, 20);
            this.rdoMateriaPrima.Name = "rdoMateriaPrima";
            this.rdoMateriaPrima.Size = new System.Drawing.Size(116, 21);
            this.rdoMateriaPrima.TabIndex = 43;
            this.rdoMateriaPrima.TabStop = true;
            this.rdoMateriaPrima.Text = "Matéria Prima";
            this.rdoMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // rdoServicos
            // 
            this.rdoServicos.AutoSize = true;
            this.rdoServicos.Location = new System.Drawing.Point(163, 20);
            this.rdoServicos.Name = "rdoServicos";
            this.rdoServicos.Size = new System.Drawing.Size(77, 21);
            this.rdoServicos.TabIndex = 42;
            this.rdoServicos.TabStop = true;
            this.rdoServicos.Text = "Serviços";
            this.rdoServicos.UseVisualStyleBackColor = true;
            // 
            // rdoProdutoRevenda
            // 
            this.rdoProdutoRevenda.AutoSize = true;
            this.rdoProdutoRevenda.Location = new System.Drawing.Point(17, 20);
            this.rdoProdutoRevenda.Name = "rdoProdutoRevenda";
            this.rdoProdutoRevenda.Size = new System.Drawing.Size(140, 21);
            this.rdoProdutoRevenda.TabIndex = 41;
            this.rdoProdutoRevenda.TabStop = true;
            this.rdoProdutoRevenda.Text = "Produto Revenda";
            this.rdoProdutoRevenda.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Location = new System.Drawing.Point(12, 476);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(110, 30);
            this.btnConfiguracao.TabIndex = 2;
            this.btnConfiguracao.Text = "Configuração";
            this.btnConfiguracao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(424, 476);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 30);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(586, 476);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 30);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvBuscaProdutos
            // 
            this.dgvBuscaProdutos.AllowUserToAddRows = false;
            this.dgvBuscaProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaProdutos.Location = new System.Drawing.Point(12, 210);
            this.dgvBuscaProdutos.Name = "dgvBuscaProdutos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBuscaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscaProdutos.Size = new System.Drawing.Size(649, 260);
            this.dgvBuscaProdutos.TabIndex = 37;
            // 
            // lboFoto
            // 
            this.lboFoto.AutoSize = true;
            this.lboFoto.Location = new System.Drawing.Point(462, 59);
            this.lboFoto.Name = "lboFoto";
            this.lboFoto.Size = new System.Drawing.Size(37, 17);
            this.lboFoto.TabIndex = 35;
            this.lboFoto.Text = "Foto";
            // 
            // pctboxProduto
            // 
            this.pctboxProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctboxProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctboxProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctboxProduto.Location = new System.Drawing.Point(457, 66);
            this.pctboxProduto.Name = "pctboxProduto";
            this.pctboxProduto.Size = new System.Drawing.Size(180, 130);
            this.pctboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctboxProduto.TabIndex = 36;
            this.pctboxProduto.TabStop = false;
            this.pctboxProduto.Tag = "";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(306, 88);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(112, 25);
            this.cboStatus.TabIndex = 12;
            // 
            // cboFornecedores
            // 
            this.cboFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedores.FormattingEnabled = true;
            this.cboFornecedores.Location = new System.Drawing.Point(306, 154);
            this.cboFornecedores.Name = "cboFornecedores";
            this.cboFornecedores.Size = new System.Drawing.Size(112, 25);
            this.cboFornecedores.TabIndex = 12;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(155, 154);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(119, 25);
            this.cboCategoria.TabIndex = 11;
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProduto.FormattingEnabled = true;
            this.cboTipoProduto.Location = new System.Drawing.Point(15, 154);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(118, 25);
            this.cboTipoProduto.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(15, 90);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(150, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Location = new System.Drawing.Point(188, 90);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(100, 23);
            this.txtReferencia.TabIndex = 1;
            // 
            // lblCategoriaProduto
            // 
            this.lblCategoriaProduto.AutoSize = true;
            this.lblCategoriaProduto.Location = new System.Drawing.Point(152, 134);
            this.lblCategoriaProduto.Name = "lblCategoriaProduto";
            this.lblCategoriaProduto.Size = new System.Drawing.Size(131, 17);
            this.lblCategoriaProduto.TabIndex = 5;
            this.lblCategoriaProduto.Text = "Categoria Produto";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(303, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(303, 134);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(81, 17);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(12, 134);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(90, 17);
            this.lblTipoProduto.TabIndex = 4;
            this.lblTipoProduto.Text = "Tipo Produto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 74);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(72, 17);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(185, 74);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(76, 17);
            this.lblReferencia.TabIndex = 1;
            this.lblReferencia.Text = "Referência";
            // 
            // BuscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 518);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaProduto";
            this.Text = "BuscaProduto";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.Button BtnLimpar;
        internal System.Windows.Forms.RadioButton rdoProdutoAcabado;
        internal System.Windows.Forms.RadioButton rdoMateriaPrima;
        internal System.Windows.Forms.RadioButton rdoServicos;
        internal System.Windows.Forms.RadioButton rdoProdutoRevenda;
        internal System.Windows.Forms.Button btnConfiguracao;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Button btnVoltar;
        internal System.Windows.Forms.DataGridView dgvBuscaProdutos;
        internal System.Windows.Forms.Label lboFoto;
        internal System.Windows.Forms.PictureBox pctboxProduto;
        internal System.Windows.Forms.ComboBox cboStatus;
        internal System.Windows.Forms.ComboBox cboFornecedores;
        internal System.Windows.Forms.ComboBox cboCategoria;
        internal System.Windows.Forms.ComboBox cboTipoProduto;
        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.Label lblCategoriaProduto;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label lblFornecedor;
        internal System.Windows.Forms.Label lblTipoProduto;
        internal System.Windows.Forms.Label lblDescricao;
        internal System.Windows.Forms.Label lblReferencia;
    }
}