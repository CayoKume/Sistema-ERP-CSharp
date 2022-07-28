namespace WF.Forms.Produto
{
    partial class Servico
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
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.lboObservacoes = new System.Windows.Forms.Label();
            this.lboDescricaoDetalhada = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.txtCompraImposto = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtMarginLucro = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.lboMarginLucro = new System.Windows.Forms.Label();
            this.lboPrecoVenda = new System.Windows.Forms.Label();
            this.lboPrecoCompra = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lboFornecedores = new System.Windows.Forms.Label();
            this.cboFornecedores = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lboStatus = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lboCategoria = new System.Windows.Forms.Label();
            this.lboTipoProduto = new System.Windows.Forms.Label();
            this.lboReferencia = new System.Windows.Forms.Label();
            this.lboDescricao = new System.Windows.Forms.Label();
            this.lboCodigo = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefernciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImpostosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelacionamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlProdutos.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.Controls.Add(this.MenuStrip1);
            this.pnlProdutos.Controls.Add(this.pnlBotoes);
            this.pnlProdutos.Controls.Add(this.Panel6);
            this.pnlProdutos.Controls.Add(this.Panel3);
            this.pnlProdutos.Controls.Add(this.Panel2);
            this.pnlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(784, 421);
            this.pnlProdutos.TabIndex = 58;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.BtnPesquisar);
            this.pnlBotoes.Controls.Add(this.BtnImprimir);
            this.pnlBotoes.Controls.Add(this.BtnVoltar);
            this.pnlBotoes.Controls.Add(this.BtnLimpar);
            this.pnlBotoes.Controls.Add(this.BtnExcluir);
            this.pnlBotoes.Controls.Add(this.BtnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(139, 381);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(487, 28);
            this.pnlBotoes.TabIndex = 56;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(165, 3);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 54;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(327, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 53;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(408, 3);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 52;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(246, 3);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 51;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(84, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 49;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(3, 3);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 48;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.lboObservacoes);
            this.Panel6.Controls.Add(this.lboDescricaoDetalhada);
            this.Panel6.Controls.Add(this.TextBox2);
            this.Panel6.Controls.Add(this.TextBox1);
            this.Panel6.Location = new System.Drawing.Point(12, 194);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(744, 181);
            this.Panel6.TabIndex = 0;
            // 
            // lboObservacoes
            // 
            this.lboObservacoes.AutoSize = true;
            this.lboObservacoes.Location = new System.Drawing.Point(8, 89);
            this.lboObservacoes.Name = "lboObservacoes";
            this.lboObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lboObservacoes.TabIndex = 51;
            this.lboObservacoes.Text = "Observações";
            // 
            // lboDescricaoDetalhada
            // 
            this.lboDescricaoDetalhada.AutoSize = true;
            this.lboDescricaoDetalhada.Location = new System.Drawing.Point(8, 5);
            this.lboDescricaoDetalhada.Name = "lboDescricaoDetalhada";
            this.lboDescricaoDetalhada.Size = new System.Drawing.Size(107, 13);
            this.lboDescricaoDetalhada.TabIndex = 50;
            this.lboDescricaoDetalhada.Text = "Descrição Detalhada";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(11, 105);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(730, 65);
            this.TextBox2.TabIndex = 49;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(11, 21);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(730, 65);
            this.TextBox1.TabIndex = 48;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.txtCompraImposto);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.txtMarginLucro);
            this.Panel3.Controls.Add(this.txtPrecoVenda);
            this.Panel3.Controls.Add(this.txtPrecoCompra);
            this.Panel3.Controls.Add(this.lboMarginLucro);
            this.Panel3.Controls.Add(this.lboPrecoVenda);
            this.Panel3.Controls.Add(this.lboPrecoCompra);
            this.Panel3.Location = new System.Drawing.Point(12, 138);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(744, 50);
            this.Panel3.TabIndex = 43;
            // 
            // txtCompraImposto
            // 
            this.txtCompraImposto.Location = new System.Drawing.Point(288, 14);
            this.txtCompraImposto.Name = "txtCompraImposto";
            this.txtCompraImposto.Size = new System.Drawing.Size(50, 20);
            this.txtCompraImposto.TabIndex = 42;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(171, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 16);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Compra + Impostos";
            // 
            // txtMarginLucro
            // 
            this.txtMarginLucro.Location = new System.Drawing.Point(458, 14);
            this.txtMarginLucro.Name = "txtMarginLucro";
            this.txtMarginLucro.Size = new System.Drawing.Size(50, 20);
            this.txtMarginLucro.TabIndex = 20;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(610, 14);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(50, 20);
            this.txtPrecoVenda.TabIndex = 19;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(115, 14);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(50, 20);
            this.txtPrecoCompra.TabIndex = 17;
            // 
            // lboMarginLucro
            // 
            this.lboMarginLucro.AutoSize = true;
            this.lboMarginLucro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboMarginLucro.Location = new System.Drawing.Point(344, 16);
            this.lboMarginLucro.Name = "lboMarginLucro";
            this.lboMarginLucro.Size = new System.Drawing.Size(107, 16);
            this.lboMarginLucro.TabIndex = 10;
            this.lboMarginLucro.Text = "% Margin de Lucro";
            // 
            // lboPrecoVenda
            // 
            this.lboPrecoVenda.AutoSize = true;
            this.lboPrecoVenda.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboPrecoVenda.Location = new System.Drawing.Point(514, 16);
            this.lboPrecoVenda.Name = "lboPrecoVenda";
            this.lboPrecoVenda.Size = new System.Drawing.Size(89, 16);
            this.lboPrecoVenda.TabIndex = 9;
            this.lboPrecoVenda.Text = "Preço de Venda";
            // 
            // lboPrecoCompra
            // 
            this.lboPrecoCompra.AutoSize = true;
            this.lboPrecoCompra.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboPrecoCompra.Location = new System.Drawing.Point(11, 16);
            this.lboPrecoCompra.Name = "lboPrecoCompra";
            this.lboPrecoCompra.Size = new System.Drawing.Size(97, 16);
            this.lboPrecoCompra.TabIndex = 8;
            this.lboPrecoCompra.Text = "Preço de Compra";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lboFornecedores);
            this.Panel2.Controls.Add(this.cboFornecedores);
            this.Panel2.Controls.Add(this.cboStatus);
            this.Panel2.Controls.Add(this.lboStatus);
            this.Panel2.Controls.Add(this.cboCategoria);
            this.Panel2.Controls.Add(this.cboTipoProduto);
            this.Panel2.Controls.Add(this.txtReferencia);
            this.Panel2.Controls.Add(this.txtDescricao);
            this.Panel2.Controls.Add(this.txtCodigo);
            this.Panel2.Controls.Add(this.lboCategoria);
            this.Panel2.Controls.Add(this.lboTipoProduto);
            this.Panel2.Controls.Add(this.lboReferencia);
            this.Panel2.Controls.Add(this.lboDescricao);
            this.Panel2.Controls.Add(this.lboCodigo);
            this.Panel2.Location = new System.Drawing.Point(12, 57);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(744, 75);
            this.Panel2.TabIndex = 41;
            // 
            // lboFornecedores
            // 
            this.lboFornecedores.AutoSize = true;
            this.lboFornecedores.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboFornecedores.Location = new System.Drawing.Point(8, 43);
            this.lboFornecedores.Name = "lboFornecedores";
            this.lboFornecedores.Size = new System.Drawing.Size(78, 16);
            this.lboFornecedores.TabIndex = 33;
            this.lboFornecedores.Text = "Fornecedores";
            // 
            // cboFornecedores
            // 
            this.cboFornecedores.FormattingEnabled = true;
            this.cboFornecedores.Location = new System.Drawing.Point(93, 41);
            this.cboFornecedores.Name = "cboFornecedores";
            this.cboFornecedores.Size = new System.Drawing.Size(121, 21);
            this.cboFornecedores.TabIndex = 32;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(678, 41);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(55, 21);
            this.cboStatus.TabIndex = 31;
            // 
            // lboStatus
            // 
            this.lboStatus.AutoSize = true;
            this.lboStatus.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboStatus.Location = new System.Drawing.Point(632, 43);
            this.lboStatus.Name = "lboStatus";
            this.lboStatus.Size = new System.Drawing.Size(39, 16);
            this.lboStatus.TabIndex = 30;
            this.lboStatus.Text = "Status";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(284, 41);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 29;
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.FormattingEnabled = true;
            this.cboTipoProduto.Location = new System.Drawing.Point(505, 41);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(121, 21);
            this.cboTipoProduto.TabIndex = 28;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(648, 9);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(85, 20);
            this.txtReferencia.TabIndex = 21;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(181, 9);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(392, 20);
            this.txtDescricao.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(50, 20);
            this.txtCodigo.TabIndex = 14;
            // 
            // lboCategoria
            // 
            this.lboCategoria.AutoSize = true;
            this.lboCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCategoria.Location = new System.Drawing.Point(220, 43);
            this.lboCategoria.Name = "lboCategoria";
            this.lboCategoria.Size = new System.Drawing.Size(57, 16);
            this.lboCategoria.TabIndex = 13;
            this.lboCategoria.Text = "Categoria";
            // 
            // lboTipoProduto
            // 
            this.lboTipoProduto.AutoSize = true;
            this.lboTipoProduto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboTipoProduto.Location = new System.Drawing.Point(411, 43);
            this.lboTipoProduto.Name = "lboTipoProduto";
            this.lboTipoProduto.Size = new System.Drawing.Size(87, 16);
            this.lboTipoProduto.TabIndex = 12;
            this.lboTipoProduto.Text = "Tipo de Serviço";
            // 
            // lboReferencia
            // 
            this.lboReferencia.AutoSize = true;
            this.lboReferencia.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboReferencia.Location = new System.Drawing.Point(579, 11);
            this.lboReferencia.Name = "lboReferencia";
            this.lboReferencia.Size = new System.Drawing.Size(62, 16);
            this.lboReferencia.TabIndex = 11;
            this.lboReferencia.Text = "Referência";
            // 
            // lboDescricao
            // 
            this.lboDescricao.AutoSize = true;
            this.lboDescricao.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboDescricao.Location = new System.Drawing.Point(116, 11);
            this.lboDescricao.Name = "lboDescricao";
            this.lboDescricao.Size = new System.Drawing.Size(58, 16);
            this.lboDescricao.TabIndex = 1;
            this.lboDescricao.Text = "Descrição";
            // 
            // lboCodigo
            // 
            this.lboCodigo.AutoSize = true;
            this.lboCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCodigo.Location = new System.Drawing.Point(8, 11);
            this.lboCodigo.Name = "lboCodigo";
            this.lboCodigo.Size = new System.Drawing.Size(45, 16);
            this.lboCodigo.TabIndex = 0;
            this.lboCodigo.Text = "Código";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdutoToolStripMenuItem,
            this.ServiçosToolStripMenuItem,
            this.RefernciasToolStripMenuItem,
            this.MedidasToolStripMenuItem,
            this.ImpostosToolStripMenuItem,
            this.RelacionamentosToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip1.TabIndex = 59;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ProdutoToolStripMenuItem
            // 
            this.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem";
            this.ProdutoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ProdutoToolStripMenuItem.Text = "Produtos";
            // 
            // ServiçosToolStripMenuItem
            // 
            this.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem";
            this.ServiçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ServiçosToolStripMenuItem.Text = "Serviços";
            // 
            // RefernciasToolStripMenuItem
            // 
            this.RefernciasToolStripMenuItem.Name = "RefernciasToolStripMenuItem";
            this.RefernciasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.RefernciasToolStripMenuItem.Text = "Referências";
            // 
            // MedidasToolStripMenuItem
            // 
            this.MedidasToolStripMenuItem.Name = "MedidasToolStripMenuItem";
            this.MedidasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.MedidasToolStripMenuItem.Text = "Medidas";
            // 
            // ImpostosToolStripMenuItem
            // 
            this.ImpostosToolStripMenuItem.Name = "ImpostosToolStripMenuItem";
            this.ImpostosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ImpostosToolStripMenuItem.Text = "Impostos";
            // 
            // RelacionamentosToolStripMenuItem
            // 
            this.RelacionamentosToolStripMenuItem.Name = "RelacionamentosToolStripMenuItem";
            this.RelacionamentosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.RelacionamentosToolStripMenuItem.Text = "Relacionamentos";
            // 
            // Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.pnlProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servico";
            this.Text = "Servicos";
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlProdutos;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ProdutoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ServiçosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefernciasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MedidasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImpostosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RelacionamentosToolStripMenuItem;
        internal System.Windows.Forms.Panel pnlBotoes;
        internal System.Windows.Forms.Button BtnPesquisar;
        internal System.Windows.Forms.Button BtnImprimir;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnLimpar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Label lboObservacoes;
        internal System.Windows.Forms.Label lboDescricaoDetalhada;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox txtCompraImposto;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtMarginLucro;
        internal System.Windows.Forms.TextBox txtPrecoVenda;
        internal System.Windows.Forms.TextBox txtPrecoCompra;
        internal System.Windows.Forms.Label lboMarginLucro;
        internal System.Windows.Forms.Label lboPrecoVenda;
        internal System.Windows.Forms.Label lboPrecoCompra;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lboFornecedores;
        internal System.Windows.Forms.ComboBox cboFornecedores;
        internal System.Windows.Forms.ComboBox cboStatus;
        internal System.Windows.Forms.Label lboStatus;
        internal System.Windows.Forms.ComboBox cboCategoria;
        internal System.Windows.Forms.ComboBox cboTipoProduto;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label lboCategoria;
        internal System.Windows.Forms.Label lboTipoProduto;
        internal System.Windows.Forms.Label lboReferencia;
        internal System.Windows.Forms.Label lboDescricao;
        internal System.Windows.Forms.Label lboCodigo;
    }
}