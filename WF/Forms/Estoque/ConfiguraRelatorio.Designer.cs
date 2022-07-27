namespace WF.Forms.Estoque
{
    partial class ConfiguraRelatorio
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
            this.lblNomeRelatorio = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.txtNomeRelatorio = new System.Windows.Forms.TextBox();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.chkListEntradas = new System.Windows.Forms.CheckedListBox();
            this.chkListSaidas = new System.Windows.Forms.CheckedListBox();
            this.lblSaidas = new System.Windows.Forms.Label();
            this.lblImpostos = new System.Windows.Forms.Label();
            this.chkListImpostos = new System.Windows.Forms.CheckedListBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.chkListValores = new System.Windows.Forms.CheckedListBox();
            this.chkListMedidas = new System.Windows.Forms.CheckedListBox();
            this.chkListEstoque = new System.Windows.Forms.CheckedListBox();
            this.lblDatas = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.chkListDatas = new System.Windows.Forms.CheckedListBox();
            this.chkListProduto = new System.Windows.Forms.CheckedListBox();
            this.chkExibeProdutoNegativo = new System.Windows.Forms.CheckBox();
            this.chkExibeSomenteProdutoNegativo = new System.Windows.Forms.CheckBox();
            this.chkNaoExibeProdutoNegativo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNomeRelatorio
            // 
            this.lblNomeRelatorio.AutoSize = true;
            this.lblNomeRelatorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRelatorio.Location = new System.Drawing.Point(510, 489);
            this.lblNomeRelatorio.Name = "lblNomeRelatorio";
            this.lblNomeRelatorio.Size = new System.Drawing.Size(132, 17);
            this.lblNomeRelatorio.TabIndex = 109;
            this.lblNomeRelatorio.Text = "Nome do Relatório";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(582, 535);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 108;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(501, 535);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 107;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNomeRelatorio
            // 
            this.txtNomeRelatorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRelatorio.Location = new System.Drawing.Point(528, 509);
            this.txtNomeRelatorio.Name = "txtNomeRelatorio";
            this.txtNomeRelatorio.Size = new System.Drawing.Size(100, 23);
            this.txtNomeRelatorio.TabIndex = 106;
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.Location = new System.Drawing.Point(204, 417);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(60, 17);
            this.lblEntradas.TabIndex = 105;
            this.lblEntradas.Text = "Entadas";
            // 
            // chkListEntradas
            // 
            this.chkListEntradas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListEntradas.FormattingEnabled = true;
            this.chkListEntradas.Items.AddRange(new object[] {
            "Devoluções de Clientes",
            "Ordem de Serviços",
            "Compras"});
            this.chkListEntradas.Location = new System.Drawing.Point(207, 436);
            this.chkListEntradas.Name = "chkListEntradas";
            this.chkListEntradas.Size = new System.Drawing.Size(226, 58);
            this.chkListEntradas.TabIndex = 104;
            // 
            // chkListSaidas
            // 
            this.chkListSaidas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListSaidas.FormattingEnabled = true;
            this.chkListSaidas.Items.AddRange(new object[] {
            "Devoluções de Fornecedores",
            "Requisições",
            "Vendas"});
            this.chkListSaidas.Location = new System.Drawing.Point(207, 356);
            this.chkListSaidas.Name = "chkListSaidas";
            this.chkListSaidas.Size = new System.Drawing.Size(226, 58);
            this.chkListSaidas.TabIndex = 103;
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidas.Location = new System.Drawing.Point(204, 337);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(49, 17);
            this.lblSaidas.TabIndex = 102;
            this.lblSaidas.Text = "Saídas";
            // 
            // lblImpostos
            // 
            this.lblImpostos.AutoSize = true;
            this.lblImpostos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostos.Location = new System.Drawing.Point(204, 130);
            this.lblImpostos.Name = "lblImpostos";
            this.lblImpostos.Size = new System.Drawing.Size(66, 17);
            this.lblImpostos.TabIndex = 101;
            this.lblImpostos.Text = "Impostos";
            // 
            // chkListImpostos
            // 
            this.chkListImpostos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListImpostos.FormattingEnabled = true;
            this.chkListImpostos.Items.AddRange(new object[] {
            "% ICMS",
            "Valor Total ICMS",
            "% IPI de Saída",
            "Valor Total IPI de Saída",
            "% IPI de Entrada",
            "Valor Total IPI de Entrada",
            "% ISS",
            "Valor Total ISS",
            "% II",
            "Valor Total II"});
            this.chkListImpostos.Location = new System.Drawing.Point(207, 150);
            this.chkListImpostos.Name = "chkListImpostos";
            this.chkListImpostos.Size = new System.Drawing.Size(226, 184);
            this.chkListImpostos.TabIndex = 100;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(9, 256);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(59, 17);
            this.lblEstoque.TabIndex = 99;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblMedidas
            // 
            this.lblMedidas.AutoSize = true;
            this.lblMedidas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidas.Location = new System.Drawing.Point(442, 31);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(62, 17);
            this.lblMedidas.TabIndex = 98;
            this.lblMedidas.Text = "Medidas";
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValores.Location = new System.Drawing.Point(204, 31);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(55, 17);
            this.lblValores.TabIndex = 97;
            this.lblValores.Text = "Valores";
            // 
            // chkListValores
            // 
            this.chkListValores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListValores.FormattingEnabled = true;
            this.chkListValores.Items.AddRange(new object[] {
            "Preço de Compra",
            "Preço de Compra + Impostos",
            "Margem de Lucro %",
            "Preço de Venda"});
            this.chkListValores.Location = new System.Drawing.Point(207, 51);
            this.chkListValores.Name = "chkListValores";
            this.chkListValores.Size = new System.Drawing.Size(226, 76);
            this.chkListValores.TabIndex = 96;
            // 
            // chkListMedidas
            // 
            this.chkListMedidas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListMedidas.FormattingEnabled = true;
            this.chkListMedidas.Items.AddRange(new object[] {
            "Unidade de Medida Compra",
            "Unidade de Medida Estoque",
            "Quantidade po Caixa",
            "Taxa de Conversão",
            "Peso Unitário",
            "Peso por Caixa",
            "Altura",
            "Largura",
            "Comprimento",
            "Volume"});
            this.chkListMedidas.Location = new System.Drawing.Point(445, 51);
            this.chkListMedidas.Name = "chkListMedidas";
            this.chkListMedidas.Size = new System.Drawing.Size(227, 184);
            this.chkListMedidas.TabIndex = 95;
            // 
            // chkListEstoque
            // 
            this.chkListEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListEstoque.FormattingEnabled = true;
            this.chkListEstoque.Items.AddRange(new object[] {
            "Estoque Disponível",
            "Estoque Mínimo",
            "Estoque Máximo",
            "Estoque Vinculado",
            "Estoque Previsto",
            "Produtos à Comprar"});
            this.chkListEstoque.Location = new System.Drawing.Point(9, 276);
            this.chkListEstoque.Name = "chkListEstoque";
            this.chkListEstoque.Size = new System.Drawing.Size(189, 112);
            this.chkListEstoque.TabIndex = 94;
            // 
            // lblDatas
            // 
            this.lblDatas.AutoSize = true;
            this.lblDatas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatas.Location = new System.Drawing.Point(9, 392);
            this.lblDatas.Name = "lblDatas";
            this.lblDatas.Size = new System.Drawing.Size(46, 17);
            this.lblDatas.TabIndex = 93;
            this.lblDatas.Text = "Datas";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 31);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(60, 17);
            this.lblProduto.TabIndex = 92;
            this.lblProduto.Text = "Produto";
            // 
            // chkListDatas
            // 
            this.chkListDatas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListDatas.FormattingEnabled = true;
            this.chkListDatas.Items.AddRange(new object[] {
            "Data da Última Venda",
            "Data da Última Compra",
            "Data de Atualização"});
            this.chkListDatas.Location = new System.Drawing.Point(9, 411);
            this.chkListDatas.Name = "chkListDatas";
            this.chkListDatas.Size = new System.Drawing.Size(189, 76);
            this.chkListDatas.TabIndex = 91;
            // 
            // chkListProduto
            // 
            this.chkListProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListProduto.FormattingEnabled = true;
            this.chkListProduto.Items.AddRange(new object[] {
            "Código Produto",
            "Descrição",
            "Referência",
            "Tipo Produto",
            "Categoria",
            "Fornecedor",
            "Classe",
            "Status",
            "Descrições Detalhadas",
            "Observações",
            "Imagem"});
            this.chkListProduto.Location = new System.Drawing.Point(9, 51);
            this.chkListProduto.Name = "chkListProduto";
            this.chkListProduto.Size = new System.Drawing.Size(189, 202);
            this.chkListProduto.TabIndex = 90;
            // 
            // chkExibeProdutoNegativo
            // 
            this.chkExibeProdutoNegativo.AutoSize = true;
            this.chkExibeProdutoNegativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExibeProdutoNegativo.Location = new System.Drawing.Point(12, 528);
            this.chkExibeProdutoNegativo.Name = "chkExibeProdutoNegativo";
            this.chkExibeProdutoNegativo.Size = new System.Drawing.Size(438, 21);
            this.chkExibeProdutoNegativo.TabIndex = 89;
            this.chkExibeProdutoNegativo.Text = "Exibir Produtos com Estoque Menor ou Igual ao Estoque Mínimo";
            this.chkExibeProdutoNegativo.UseVisualStyleBackColor = true;
            // 
            // chkExibeSomenteProdutoNegativo
            // 
            this.chkExibeSomenteProdutoNegativo.AutoSize = true;
            this.chkExibeSomenteProdutoNegativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExibeSomenteProdutoNegativo.Location = new System.Drawing.Point(12, 551);
            this.chkExibeSomenteProdutoNegativo.Name = "chkExibeSomenteProdutoNegativo";
            this.chkExibeSomenteProdutoNegativo.Size = new System.Drawing.Size(335, 21);
            this.chkExibeSomenteProdutoNegativo.TabIndex = 88;
            this.chkExibeSomenteProdutoNegativo.Text = "Exibir Somente Produtos com Estoque Negativo";
            this.chkExibeSomenteProdutoNegativo.UseVisualStyleBackColor = true;
            // 
            // chkNaoExibeProdutoNegativo
            // 
            this.chkNaoExibeProdutoNegativo.AutoSize = true;
            this.chkNaoExibeProdutoNegativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNaoExibeProdutoNegativo.Location = new System.Drawing.Point(12, 505);
            this.chkNaoExibeProdutoNegativo.Name = "chkNaoExibeProdutoNegativo";
            this.chkNaoExibeProdutoNegativo.Size = new System.Drawing.Size(402, 21);
            this.chkNaoExibeProdutoNegativo.TabIndex = 87;
            this.chkNaoExibeProdutoNegativo.Text = "Não Exibir Produtos com Estoque Igual ou Menor que Zero";
            this.chkNaoExibeProdutoNegativo.UseVisualStyleBackColor = true;
            // 
            // ConfiguraRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 581);
            this.Controls.Add(this.lblNomeRelatorio);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.txtNomeRelatorio);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.chkListEntradas);
            this.Controls.Add(this.chkListSaidas);
            this.Controls.Add(this.lblSaidas);
            this.Controls.Add(this.lblImpostos);
            this.Controls.Add(this.chkListImpostos);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblMedidas);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.chkListValores);
            this.Controls.Add(this.chkListMedidas);
            this.Controls.Add(this.chkListEstoque);
            this.Controls.Add(this.lblDatas);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.chkListDatas);
            this.Controls.Add(this.chkListProduto);
            this.Controls.Add(this.chkExibeProdutoNegativo);
            this.Controls.Add(this.chkExibeSomenteProdutoNegativo);
            this.Controls.Add(this.chkNaoExibeProdutoNegativo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguraRelatorio";
            this.Text = "ConfiguraRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblNomeRelatorio;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.TextBox txtNomeRelatorio;
        internal System.Windows.Forms.Label lblEntradas;
        internal System.Windows.Forms.CheckedListBox chkListEntradas;
        internal System.Windows.Forms.CheckedListBox chkListSaidas;
        internal System.Windows.Forms.Label lblSaidas;
        internal System.Windows.Forms.Label lblImpostos;
        internal System.Windows.Forms.CheckedListBox chkListImpostos;
        internal System.Windows.Forms.Label lblEstoque;
        internal System.Windows.Forms.Label lblMedidas;
        internal System.Windows.Forms.Label lblValores;
        internal System.Windows.Forms.CheckedListBox chkListValores;
        internal System.Windows.Forms.CheckedListBox chkListMedidas;
        internal System.Windows.Forms.CheckedListBox chkListEstoque;
        internal System.Windows.Forms.Label lblDatas;
        internal System.Windows.Forms.Label lblProduto;
        internal System.Windows.Forms.CheckedListBox chkListDatas;
        internal System.Windows.Forms.CheckedListBox chkListProduto;
        internal System.Windows.Forms.CheckBox chkExibeProdutoNegativo;
        internal System.Windows.Forms.CheckBox chkExibeSomenteProdutoNegativo;
        internal System.Windows.Forms.CheckBox chkNaoExibeProdutoNegativo;
    }
}