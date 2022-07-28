namespace WF.Forms.Estoque
{
    partial class Medidas
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
            this.lboUnidade = new System.Windows.Forms.Label();
            this.lboPesos = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.pnlUnidades = new System.Windows.Forms.Panel();
            this.BtnMedidaEstoque = new System.Windows.Forms.Button();
            this.BtnlboMedidaCompra = new System.Windows.Forms.Button();
            this.cboMedidaEstoque = new System.Windows.Forms.ComboBox();
            this.cboMedidaCompra = new System.Windows.Forms.ComboBox();
            this.txtTaxaDeConversao = new System.Windows.Forms.TextBox();
            this.lboTaxaDeConversao = new System.Windows.Forms.Label();
            this.txtQtdCaixa = new System.Windows.Forms.TextBox();
            this.lboQtdCaixa = new System.Windows.Forms.Label();
            this.pnlPesos = new System.Windows.Forms.Panel();
            this.txtKiloCaixa = new System.Windows.Forms.TextBox();
            this.txtPesoUnitario = new System.Windows.Forms.TextBox();
            this.lboKiloCaixa = new System.Windows.Forms.Label();
            this.lboPesoUnitario = new System.Windows.Forms.Label();
            this.pnlDimensoes = new System.Windows.Forms.Panel();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lboVolume = new System.Windows.Forms.Label();
            this.lboComprimento = new System.Windows.Forms.Label();
            this.lboLargura = new System.Windows.Forms.Label();
            this.lboAltura = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.pnlUnidades.SuspendLayout();
            this.pnlPesos.SuspendLayout();
            this.pnlDimensoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboUnidade
            // 
            this.lboUnidade.AutoSize = true;
            this.lboUnidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboUnidade.Location = new System.Drawing.Point(17, 39);
            this.lboUnidade.Name = "lboUnidade";
            this.lboUnidade.Size = new System.Drawing.Size(67, 17);
            this.lboUnidade.TabIndex = 4;
            this.lboUnidade.Text = "Unidades";
            // 
            // lboPesos
            // 
            this.lboPesos.AutoSize = true;
            this.lboPesos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboPesos.Location = new System.Drawing.Point(17, 228);
            this.lboPesos.Name = "lboPesos";
            this.lboPesos.Size = new System.Drawing.Size(43, 17);
            this.lboPesos.TabIndex = 5;
            this.lboPesos.Text = "Pesos";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(17, 312);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(77, 17);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "Dimensões";
            // 
            // pnlUnidades
            // 
            this.pnlUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnidades.Controls.Add(this.BtnMedidaEstoque);
            this.pnlUnidades.Controls.Add(this.BtnlboMedidaCompra);
            this.pnlUnidades.Controls.Add(this.cboMedidaEstoque);
            this.pnlUnidades.Controls.Add(this.cboMedidaCompra);
            this.pnlUnidades.Controls.Add(this.txtTaxaDeConversao);
            this.pnlUnidades.Controls.Add(this.lboTaxaDeConversao);
            this.pnlUnidades.Controls.Add(this.txtQtdCaixa);
            this.pnlUnidades.Controls.Add(this.lboQtdCaixa);
            this.pnlUnidades.Location = new System.Drawing.Point(12, 49);
            this.pnlUnidades.Name = "pnlUnidades";
            this.pnlUnidades.Size = new System.Drawing.Size(357, 176);
            this.pnlUnidades.TabIndex = 7;
            // 
            // BtnMedidaEstoque
            // 
            this.BtnMedidaEstoque.BackColor = System.Drawing.Color.Transparent;
            this.BtnMedidaEstoque.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.BtnMedidaEstoque.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMedidaEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMedidaEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMedidaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedidaEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedidaEstoque.Location = new System.Drawing.Point(10, 65);
            this.BtnMedidaEstoque.Name = "BtnMedidaEstoque";
            this.BtnMedidaEstoque.Size = new System.Drawing.Size(191, 46);
            this.BtnMedidaEstoque.TabIndex = 5;
            this.BtnMedidaEstoque.Text = "Unidade de Medida do Estoque";
            this.BtnMedidaEstoque.UseVisualStyleBackColor = false;
            // 
            // BtnlboMedidaCompra
            // 
            this.BtnlboMedidaCompra.BackColor = System.Drawing.Color.Transparent;
            this.BtnlboMedidaCompra.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.BtnlboMedidaCompra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnlboMedidaCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnlboMedidaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnlboMedidaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnlboMedidaCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnlboMedidaCompra.Location = new System.Drawing.Point(10, 14);
            this.BtnlboMedidaCompra.Name = "BtnlboMedidaCompra";
            this.BtnlboMedidaCompra.Size = new System.Drawing.Size(191, 45);
            this.BtnlboMedidaCompra.TabIndex = 4;
            this.BtnlboMedidaCompra.Text = "Unidade de Medida da Compra";
            this.BtnlboMedidaCompra.UseVisualStyleBackColor = false;
            // 
            // cboMedidaEstoque
            // 
            this.cboMedidaEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMedidaEstoque.FormattingEnabled = true;
            this.cboMedidaEstoque.Location = new System.Drawing.Point(227, 77);
            this.cboMedidaEstoque.Name = "cboMedidaEstoque";
            this.cboMedidaEstoque.Size = new System.Drawing.Size(113, 25);
            this.cboMedidaEstoque.TabIndex = 1;
            // 
            // cboMedidaCompra
            // 
            this.cboMedidaCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMedidaCompra.FormattingEnabled = true;
            this.cboMedidaCompra.Location = new System.Drawing.Point(227, 25);
            this.cboMedidaCompra.Name = "cboMedidaCompra";
            this.cboMedidaCompra.Size = new System.Drawing.Size(113, 25);
            this.cboMedidaCompra.TabIndex = 0;
            // 
            // txtTaxaDeConversao
            // 
            this.txtTaxaDeConversao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaDeConversao.Location = new System.Drawing.Point(227, 148);
            this.txtTaxaDeConversao.Name = "txtTaxaDeConversao";
            this.txtTaxaDeConversao.Size = new System.Drawing.Size(113, 23);
            this.txtTaxaDeConversao.TabIndex = 3;
            this.txtTaxaDeConversao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lboTaxaDeConversao
            // 
            this.lboTaxaDeConversao.AutoSize = true;
            this.lboTaxaDeConversao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboTaxaDeConversao.Location = new System.Drawing.Point(8, 151);
            this.lboTaxaDeConversao.Name = "lboTaxaDeConversao";
            this.lboTaxaDeConversao.Size = new System.Drawing.Size(133, 17);
            this.lboTaxaDeConversao.TabIndex = 0;
            this.lboTaxaDeConversao.Text = "Taxa de Conversão";
            // 
            // txtQtdCaixa
            // 
            this.txtQtdCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdCaixa.Location = new System.Drawing.Point(227, 122);
            this.txtQtdCaixa.Name = "txtQtdCaixa";
            this.txtQtdCaixa.Size = new System.Drawing.Size(113, 23);
            this.txtQtdCaixa.TabIndex = 2;
            this.txtQtdCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lboQtdCaixa
            // 
            this.lboQtdCaixa.AutoSize = true;
            this.lboQtdCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboQtdCaixa.Location = new System.Drawing.Point(8, 122);
            this.lboQtdCaixa.Name = "lboQtdCaixa";
            this.lboQtdCaixa.Size = new System.Drawing.Size(109, 17);
            this.lboQtdCaixa.TabIndex = 0;
            this.lboQtdCaixa.Text = "Qtde por Caixa";
            // 
            // pnlPesos
            // 
            this.pnlPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesos.Controls.Add(this.txtKiloCaixa);
            this.pnlPesos.Controls.Add(this.txtPesoUnitario);
            this.pnlPesos.Controls.Add(this.lboKiloCaixa);
            this.pnlPesos.Controls.Add(this.lboPesoUnitario);
            this.pnlPesos.Location = new System.Drawing.Point(12, 237);
            this.pnlPesos.Name = "pnlPesos";
            this.pnlPesos.Size = new System.Drawing.Size(357, 72);
            this.pnlPesos.TabIndex = 8;
            // 
            // txtKiloCaixa
            // 
            this.txtKiloCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKiloCaixa.Location = new System.Drawing.Point(227, 43);
            this.txtKiloCaixa.Name = "txtKiloCaixa";
            this.txtKiloCaixa.Size = new System.Drawing.Size(113, 23);
            this.txtKiloCaixa.TabIndex = 1;
            this.txtKiloCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoUnitario
            // 
            this.txtPesoUnitario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoUnitario.Location = new System.Drawing.Point(227, 14);
            this.txtPesoUnitario.Name = "txtPesoUnitario";
            this.txtPesoUnitario.Size = new System.Drawing.Size(113, 23);
            this.txtPesoUnitario.TabIndex = 0;
            this.txtPesoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lboKiloCaixa
            // 
            this.lboKiloCaixa.AutoSize = true;
            this.lboKiloCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboKiloCaixa.Location = new System.Drawing.Point(8, 45);
            this.lboKiloCaixa.Name = "lboKiloCaixa";
            this.lboKiloCaixa.Size = new System.Drawing.Size(104, 17);
            this.lboKiloCaixa.TabIndex = 0;
            this.lboKiloCaixa.Text = "Kilos por Caixa";
            // 
            // lboPesoUnitario
            // 
            this.lboPesoUnitario.AutoSize = true;
            this.lboPesoUnitario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboPesoUnitario.Location = new System.Drawing.Point(8, 16);
            this.lboPesoUnitario.Name = "lboPesoUnitario";
            this.lboPesoUnitario.Size = new System.Drawing.Size(151, 17);
            this.lboPesoUnitario.TabIndex = 0;
            this.lboPesoUnitario.Text = "Peso Unitário(Gramas)";
            // 
            // pnlDimensoes
            // 
            this.pnlDimensoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDimensoes.Controls.Add(this.txtVolume);
            this.pnlDimensoes.Controls.Add(this.txtComprimento);
            this.pnlDimensoes.Controls.Add(this.txtLargura);
            this.pnlDimensoes.Controls.Add(this.txtAltura);
            this.pnlDimensoes.Controls.Add(this.lboVolume);
            this.pnlDimensoes.Controls.Add(this.lboComprimento);
            this.pnlDimensoes.Controls.Add(this.lboLargura);
            this.pnlDimensoes.Controls.Add(this.lboAltura);
            this.pnlDimensoes.Location = new System.Drawing.Point(12, 320);
            this.pnlDimensoes.Name = "pnlDimensoes";
            this.pnlDimensoes.Size = new System.Drawing.Size(357, 122);
            this.pnlDimensoes.TabIndex = 9;
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(227, 90);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(113, 23);
            this.txtVolume.TabIndex = 3;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComprimento
            // 
            this.txtComprimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprimento.Location = new System.Drawing.Point(227, 64);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(113, 23);
            this.txtComprimento.TabIndex = 2;
            this.txtComprimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLargura
            // 
            this.txtLargura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLargura.Location = new System.Drawing.Point(227, 39);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(113, 23);
            this.txtLargura.TabIndex = 1;
            this.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(227, 14);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(113, 23);
            this.txtAltura.TabIndex = 0;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lboVolume
            // 
            this.lboVolume.AutoSize = true;
            this.lboVolume.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboVolume.Location = new System.Drawing.Point(8, 92);
            this.lboVolume.Name = "lboVolume";
            this.lboVolume.Size = new System.Drawing.Size(84, 17);
            this.lboVolume.TabIndex = 0;
            this.lboVolume.Text = "Volume(m³)";
            // 
            // lboComprimento
            // 
            this.lboComprimento.AutoSize = true;
            this.lboComprimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboComprimento.Location = new System.Drawing.Point(8, 66);
            this.lboComprimento.Name = "lboComprimento";
            this.lboComprimento.Size = new System.Drawing.Size(100, 17);
            this.lboComprimento.TabIndex = 0;
            this.lboComprimento.Text = "Comprimento";
            // 
            // lboLargura
            // 
            this.lboLargura.AutoSize = true;
            this.lboLargura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboLargura.Location = new System.Drawing.Point(8, 41);
            this.lboLargura.Name = "lboLargura";
            this.lboLargura.Size = new System.Drawing.Size(57, 17);
            this.lboLargura.TabIndex = 0;
            this.lboLargura.Text = "Largura";
            // 
            // lboAltura
            // 
            this.lboAltura.AutoSize = true;
            this.lboAltura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboAltura.Location = new System.Drawing.Point(8, 16);
            this.lboAltura.Name = "lboAltura";
            this.lboAltura.Size = new System.Drawing.Size(46, 17);
            this.lboAltura.TabIndex = 0;
            this.lboAltura.Text = "Altura";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(294, 457);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(213, 457);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // Medidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 499);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.lboUnidade);
            this.Controls.Add(this.lboPesos);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.pnlUnidades);
            this.Controls.Add(this.pnlPesos);
            this.Controls.Add(this.pnlDimensoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medidas";
            this.Text = "Medidas";
            this.pnlUnidades.ResumeLayout(false);
            this.pnlUnidades.PerformLayout();
            this.pnlPesos.ResumeLayout(false);
            this.pnlPesos.PerformLayout();
            this.pnlDimensoes.ResumeLayout(false);
            this.pnlDimensoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lboUnidade;
        internal System.Windows.Forms.Label lboPesos;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Panel pnlUnidades;
        internal System.Windows.Forms.Button BtnMedidaEstoque;
        internal System.Windows.Forms.Button BtnlboMedidaCompra;
        internal System.Windows.Forms.ComboBox cboMedidaEstoque;
        internal System.Windows.Forms.ComboBox cboMedidaCompra;
        internal System.Windows.Forms.TextBox txtTaxaDeConversao;
        internal System.Windows.Forms.Label lboTaxaDeConversao;
        internal System.Windows.Forms.TextBox txtQtdCaixa;
        internal System.Windows.Forms.Label lboQtdCaixa;
        internal System.Windows.Forms.Panel pnlPesos;
        internal System.Windows.Forms.TextBox txtKiloCaixa;
        internal System.Windows.Forms.TextBox txtPesoUnitario;
        internal System.Windows.Forms.Label lboKiloCaixa;
        internal System.Windows.Forms.Label lboPesoUnitario;
        internal System.Windows.Forms.Panel pnlDimensoes;
        internal System.Windows.Forms.TextBox txtVolume;
        internal System.Windows.Forms.TextBox txtComprimento;
        internal System.Windows.Forms.TextBox txtLargura;
        internal System.Windows.Forms.TextBox txtAltura;
        internal System.Windows.Forms.Label lboVolume;
        internal System.Windows.Forms.Label lboComprimento;
        internal System.Windows.Forms.Label lboLargura;
        internal System.Windows.Forms.Label lboAltura;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnSalvar;
    }
}