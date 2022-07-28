namespace WF.Forms.Produto
{
    partial class Requisicoes
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.pnlRequisicao = new System.Windows.Forms.Panel();
            this.lboFoto = new System.Windows.Forms.Label();
            this.pctboxProduto = new System.Windows.Forms.PictureBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboAtendidoPor = new System.Windows.Forms.ComboBox();
            this.cboAprovadoPor = new System.Windows.Forms.ComboBox();
            this.cboSolicitadoPor = new System.Windows.Forms.ComboBox();
            this.cboTipoRequisicao = new System.Windows.Forms.ComboBox();
            this.lblDataConclusao = new System.Windows.Forms.Label();
            this.txtHoraConclusao = new System.Windows.Forms.TextBox();
            this.txtDataConclusao = new System.Windows.Forms.TextBox();
            this.txtHoraAprovacao = new System.Windows.Forms.TextBox();
            this.txtDataProvacao = new System.Windows.Forms.TextBox();
            this.txtHoraEmissao = new System.Windows.Forms.TextBox();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblAprovadoPor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSolicitadoPor = new System.Windows.Forms.Label();
            this.lblAtendidoPor = new System.Windows.Forms.Label();
            this.lblDataAprovacao = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblTipoRequisicao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvRequisicoes = new System.Windows.Forms.DataGridView();
            this.pnlBotoes.SuspendLayout();
            this.pnlProduto.SuspendLayout();
            this.pnlRequisicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.BtnPesquisar);
            this.pnlBotoes.Controls.Add(this.BtnImprimir);
            this.pnlBotoes.Controls.Add(this.BtnVoltar);
            this.pnlBotoes.Controls.Add(this.BtnLimpar);
            this.pnlBotoes.Controls.Add(this.BtnExcluir);
            this.pnlBotoes.Controls.Add(this.BtnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(100, 449);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(487, 39);
            this.pnlBotoes.TabIndex = 54;
            this.pnlBotoes.TabStop = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(165, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 30);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(327, 5);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 30);
            this.BtnImprimir.TabIndex = 4;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(408, 5);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(246, 5);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(84, 5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 30);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(3, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // pnlProduto
            // 
            this.pnlProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduto.Controls.Add(this.btnAlterar);
            this.pnlProduto.Controls.Add(this.btnRemover);
            this.pnlProduto.Controls.Add(this.btnAdicionar);
            this.pnlProduto.Controls.Add(this.cboProduto);
            this.pnlProduto.Controls.Add(this.txtQuantidade);
            this.pnlProduto.Controls.Add(this.txtReferencia);
            this.pnlProduto.Controls.Add(this.lblQuantidade);
            this.pnlProduto.Controls.Add(this.lblProduto);
            this.pnlProduto.Controls.Add(this.lblReferencia);
            this.pnlProduto.Location = new System.Drawing.Point(12, 188);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(650, 51);
            this.pnlProduto.TabIndex = 53;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(580, 10);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(59, 30);
            this.btnAlterar.TabIndex = 47;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(544, 10);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(30, 30);
            this.btnRemover.TabIndex = 46;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(509, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(30, 30);
            this.btnAdicionar.TabIndex = 45;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // cboProduto
            // 
            this.cboProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(238, 14);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(107, 25);
            this.cboProduto.TabIndex = 44;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(445, 14);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 23);
            this.txtQuantidade.TabIndex = 43;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(87, 14);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(75, 23);
            this.txtReferencia.TabIndex = 42;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(355, 17);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(87, 17);
            this.lblQuantidade.TabIndex = 40;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(176, 17);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(60, 17);
            this.lblProduto.TabIndex = 39;
            this.lblProduto.Text = "Produto";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(7, 17);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(76, 17);
            this.lblReferencia.TabIndex = 38;
            this.lblReferencia.Text = "Referência";
            // 
            // pnlRequisicao
            // 
            this.pnlRequisicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRequisicao.Controls.Add(this.lboFoto);
            this.pnlRequisicao.Controls.Add(this.pctboxProduto);
            this.pnlRequisicao.Controls.Add(this.cboStatus);
            this.pnlRequisicao.Controls.Add(this.cboAtendidoPor);
            this.pnlRequisicao.Controls.Add(this.cboAprovadoPor);
            this.pnlRequisicao.Controls.Add(this.cboSolicitadoPor);
            this.pnlRequisicao.Controls.Add(this.cboTipoRequisicao);
            this.pnlRequisicao.Controls.Add(this.lblDataConclusao);
            this.pnlRequisicao.Controls.Add(this.txtHoraConclusao);
            this.pnlRequisicao.Controls.Add(this.txtDataConclusao);
            this.pnlRequisicao.Controls.Add(this.txtHoraAprovacao);
            this.pnlRequisicao.Controls.Add(this.txtDataProvacao);
            this.pnlRequisicao.Controls.Add(this.txtHoraEmissao);
            this.pnlRequisicao.Controls.Add(this.txtDataEmissao);
            this.pnlRequisicao.Controls.Add(this.txtCodigo);
            this.pnlRequisicao.Controls.Add(this.lblAprovadoPor);
            this.pnlRequisicao.Controls.Add(this.lblStatus);
            this.pnlRequisicao.Controls.Add(this.lblSolicitadoPor);
            this.pnlRequisicao.Controls.Add(this.lblAtendidoPor);
            this.pnlRequisicao.Controls.Add(this.lblDataAprovacao);
            this.pnlRequisicao.Controls.Add(this.lblDataEmissao);
            this.pnlRequisicao.Controls.Add(this.lblTipoRequisicao);
            this.pnlRequisicao.Controls.Add(this.lblCodigo);
            this.pnlRequisicao.Location = new System.Drawing.Point(12, 12);
            this.pnlRequisicao.Name = "pnlRequisicao";
            this.pnlRequisicao.Size = new System.Drawing.Size(650, 170);
            this.pnlRequisicao.TabIndex = 52;
            // 
            // lboFoto
            // 
            this.lboFoto.AutoSize = true;
            this.lboFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboFoto.Location = new System.Drawing.Point(490, 11);
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
            this.pctboxProduto.Location = new System.Drawing.Point(483, 21);
            this.pctboxProduto.Name = "pctboxProduto";
            this.pctboxProduto.Size = new System.Drawing.Size(156, 116);
            this.pctboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctboxProduto.TabIndex = 36;
            this.pctboxProduto.TabStop = false;
            this.pctboxProduto.Tag = "";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(403, 16);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(74, 25);
            this.cboStatus.TabIndex = 19;
            // 
            // cboAtendidoPor
            // 
            this.cboAtendidoPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAtendidoPor.FormattingEnabled = true;
            this.cboAtendidoPor.Location = new System.Drawing.Point(108, 132);
            this.cboAtendidoPor.Name = "cboAtendidoPor";
            this.cboAtendidoPor.Size = new System.Drawing.Size(92, 25);
            this.cboAtendidoPor.TabIndex = 18;
            // 
            // cboAprovadoPor
            // 
            this.cboAprovadoPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAprovadoPor.FormattingEnabled = true;
            this.cboAprovadoPor.Location = new System.Drawing.Point(108, 95);
            this.cboAprovadoPor.Name = "cboAprovadoPor";
            this.cboAprovadoPor.Size = new System.Drawing.Size(92, 25);
            this.cboAprovadoPor.TabIndex = 18;
            // 
            // cboSolicitadoPor
            // 
            this.cboSolicitadoPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSolicitadoPor.FormattingEnabled = true;
            this.cboSolicitadoPor.Location = new System.Drawing.Point(108, 58);
            this.cboSolicitadoPor.Name = "cboSolicitadoPor";
            this.cboSolicitadoPor.Size = new System.Drawing.Size(92, 25);
            this.cboSolicitadoPor.TabIndex = 18;
            // 
            // cboTipoRequisicao
            // 
            this.cboTipoRequisicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoRequisicao.FormattingEnabled = true;
            this.cboTipoRequisicao.Location = new System.Drawing.Point(235, 14);
            this.cboTipoRequisicao.Name = "cboTipoRequisicao";
            this.cboTipoRequisicao.Size = new System.Drawing.Size(110, 25);
            this.cboTipoRequisicao.TabIndex = 18;
            // 
            // lblDataConclusao
            // 
            this.lblDataConclusao.AutoSize = true;
            this.lblDataConclusao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConclusao.Location = new System.Drawing.Point(212, 135);
            this.lblDataConclusao.Name = "lblDataConclusao";
            this.lblDataConclusao.Size = new System.Drawing.Size(115, 17);
            this.lblDataConclusao.TabIndex = 17;
            this.lblDataConclusao.Text = "Data Conclusão";
            // 
            // txtHoraConclusao
            // 
            this.txtHoraConclusao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraConclusao.Location = new System.Drawing.Point(410, 132);
            this.txtHoraConclusao.Name = "txtHoraConclusao";
            this.txtHoraConclusao.Size = new System.Drawing.Size(67, 23);
            this.txtHoraConclusao.TabIndex = 16;
            // 
            // txtDataConclusao
            // 
            this.txtDataConclusao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataConclusao.Location = new System.Drawing.Point(337, 132);
            this.txtDataConclusao.Name = "txtDataConclusao";
            this.txtDataConclusao.Size = new System.Drawing.Size(67, 23);
            this.txtDataConclusao.TabIndex = 16;
            // 
            // txtHoraAprovacao
            // 
            this.txtHoraAprovacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraAprovacao.Location = new System.Drawing.Point(410, 95);
            this.txtHoraAprovacao.Name = "txtHoraAprovacao";
            this.txtHoraAprovacao.Size = new System.Drawing.Size(67, 23);
            this.txtHoraAprovacao.TabIndex = 14;
            // 
            // txtDataProvacao
            // 
            this.txtDataProvacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataProvacao.Location = new System.Drawing.Point(337, 95);
            this.txtDataProvacao.Name = "txtDataProvacao";
            this.txtDataProvacao.Size = new System.Drawing.Size(67, 23);
            this.txtDataProvacao.TabIndex = 13;
            // 
            // txtHoraEmissao
            // 
            this.txtHoraEmissao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEmissao.Location = new System.Drawing.Point(410, 58);
            this.txtHoraEmissao.Name = "txtHoraEmissao";
            this.txtHoraEmissao.Size = new System.Drawing.Size(67, 23);
            this.txtHoraEmissao.TabIndex = 12;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Location = new System.Drawing.Point(337, 58);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(67, 23);
            this.txtDataEmissao.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(65, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(50, 23);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblAprovadoPor
            // 
            this.lblAprovadoPor.AutoSize = true;
            this.lblAprovadoPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovadoPor.Location = new System.Drawing.Point(3, 98);
            this.lblAprovadoPor.Name = "lblAprovadoPor";
            this.lblAprovadoPor.Size = new System.Drawing.Size(99, 17);
            this.lblAprovadoPor.TabIndex = 7;
            this.lblAprovadoPor.Text = "Aprovado Por";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(351, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblSolicitadoPor
            // 
            this.lblSolicitadoPor.AutoSize = true;
            this.lblSolicitadoPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitadoPor.Location = new System.Drawing.Point(3, 61);
            this.lblSolicitadoPor.Name = "lblSolicitadoPor";
            this.lblSolicitadoPor.Size = new System.Drawing.Size(97, 17);
            this.lblSolicitadoPor.TabIndex = 6;
            this.lblSolicitadoPor.Text = "Solicitado Por";
            // 
            // lblAtendidoPor
            // 
            this.lblAtendidoPor.AutoSize = true;
            this.lblAtendidoPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendidoPor.Location = new System.Drawing.Point(3, 135);
            this.lblAtendidoPor.Name = "lblAtendidoPor";
            this.lblAtendidoPor.Size = new System.Drawing.Size(93, 17);
            this.lblAtendidoPor.TabIndex = 8;
            this.lblAtendidoPor.Text = "Atendido Por";
            // 
            // lblDataAprovacao
            // 
            this.lblDataAprovacao.AutoSize = true;
            this.lblDataAprovacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAprovacao.Location = new System.Drawing.Point(212, 98);
            this.lblDataAprovacao.Name = "lblDataAprovacao";
            this.lblDataAprovacao.Size = new System.Drawing.Size(119, 17);
            this.lblDataAprovacao.TabIndex = 4;
            this.lblDataAprovacao.Text = "Data Aprovação";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmissao.Location = new System.Drawing.Point(212, 61);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(96, 17);
            this.lblDataEmissao.TabIndex = 3;
            this.lblDataEmissao.Text = "Data Emissão";
            // 
            // lblTipoRequisicao
            // 
            this.lblTipoRequisicao.AutoSize = true;
            this.lblTipoRequisicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRequisicao.Location = new System.Drawing.Point(121, 19);
            this.lblTipoRequisicao.Name = "lblTipoRequisicao";
            this.lblTipoRequisicao.Size = new System.Drawing.Size(108, 17);
            this.lblTipoRequisicao.TabIndex = 2;
            this.lblTipoRequisicao.Text = "Tipo Requisição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(3, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // dgvRequisicoes
            // 
            this.dgvRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisicoes.Location = new System.Drawing.Point(12, 245);
            this.dgvRequisicoes.Name = "dgvRequisicoes";
            this.dgvRequisicoes.Size = new System.Drawing.Size(653, 198);
            this.dgvRequisicoes.TabIndex = 51;
            // 
            // Requisicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 500);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlProduto);
            this.Controls.Add(this.pnlRequisicao);
            this.Controls.Add(this.dgvRequisicoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Requisicoes";
            this.Text = "Requisicoes";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            this.pnlRequisicao.ResumeLayout(false);
            this.pnlRequisicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlBotoes;
        internal System.Windows.Forms.Button BtnPesquisar;
        internal System.Windows.Forms.Button BtnImprimir;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnLimpar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Panel pnlProduto;
        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnRemover;
        internal System.Windows.Forms.Button btnAdicionar;
        internal System.Windows.Forms.ComboBox cboProduto;
        internal System.Windows.Forms.TextBox txtQuantidade;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.Label lblQuantidade;
        internal System.Windows.Forms.Label lblProduto;
        internal System.Windows.Forms.Label lblReferencia;
        internal System.Windows.Forms.Panel pnlRequisicao;
        internal System.Windows.Forms.Label lboFoto;
        internal System.Windows.Forms.PictureBox pctboxProduto;
        internal System.Windows.Forms.ComboBox cboStatus;
        internal System.Windows.Forms.ComboBox cboAtendidoPor;
        internal System.Windows.Forms.ComboBox cboAprovadoPor;
        internal System.Windows.Forms.ComboBox cboSolicitadoPor;
        internal System.Windows.Forms.ComboBox cboTipoRequisicao;
        internal System.Windows.Forms.Label lblDataConclusao;
        internal System.Windows.Forms.TextBox txtHoraConclusao;
        internal System.Windows.Forms.TextBox txtDataConclusao;
        internal System.Windows.Forms.TextBox txtHoraAprovacao;
        internal System.Windows.Forms.TextBox txtDataProvacao;
        internal System.Windows.Forms.TextBox txtHoraEmissao;
        internal System.Windows.Forms.TextBox txtDataEmissao;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label lblAprovadoPor;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label lblSolicitadoPor;
        internal System.Windows.Forms.Label lblAtendidoPor;
        internal System.Windows.Forms.Label lblDataAprovacao;
        internal System.Windows.Forms.Label lblDataEmissao;
        internal System.Windows.Forms.Label lblTipoRequisicao;
        internal System.Windows.Forms.Label lblCodigo;
        internal System.Windows.Forms.DataGridView dgvRequisicoes;
    }
}