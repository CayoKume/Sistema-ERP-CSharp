namespace WF.Forms.Estoque
{
    partial class ConfiguraEtiqueta
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
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbcConfigurarPagina = new System.Windows.Forms.TabPage();
            this.txtEspacamentoDireita = new System.Windows.Forms.TextBox();
            this.txtEspacamentoEsquerda = new System.Windows.Forms.TextBox();
            this.txtEspacamentoLinhas = new System.Windows.Forms.TextBox();
            this.txtEspacamentoColunas = new System.Windows.Forms.TextBox();
            this.txtQtdeLinhas = new System.Windows.Forms.TextBox();
            this.txtQtdeColunas = new System.Windows.Forms.TextBox();
            this.lblEspacamentoDireita = new System.Windows.Forms.Label();
            this.lblEspacamentoEsquerda = new System.Windows.Forms.Label();
            this.lblEspacamentoLinhas = new System.Windows.Forms.Label();
            this.lblEspacamentoColunas = new System.Windows.Forms.Label();
            this.lblQtdeLinhas = new System.Windows.Forms.Label();
            this.lblQtdeColunas = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.txtQtdeEtiquetaPágina = new System.Windows.Forms.TextBox();
            this.txtQtdeEtiquetaColuna = new System.Windows.Forms.TextBox();
            this.txtQtdeEtiquetaLinha = new System.Windows.Forms.TextBox();
            this.txtLarguraPagina = new System.Windows.Forms.TextBox();
            this.txtLarguraEtiqueta = new System.Windows.Forms.TextBox();
            this.txtAlturaPagina = new System.Windows.Forms.TextBox();
            this.txtAlturaEtiqueta = new System.Windows.Forms.TextBox();
            this.lblNomeFormato = new System.Windows.Forms.Label();
            this.txtNomeFormato = new System.Windows.Forms.TextBox();
            this.lblQtdeEtiquetaPágina = new System.Windows.Forms.Label();
            this.lblQtdeEtiquetaColuna = new System.Windows.Forms.Label();
            this.lblLarguraPagina = new System.Windows.Forms.Label();
            this.lblQtdeEtiquetaLinha = new System.Windows.Forms.Label();
            this.lblLarguraEtiqueta = new System.Windows.Forms.Label();
            this.lblAlturaPagina = new System.Windows.Forms.Label();
            this.lblAlturaEtiqueta = new System.Windows.Forms.Label();
            this.tbcConfiguarCampos = new System.Windows.Forms.TabPage();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtNomeModelo = new System.Windows.Forms.TextBox();
            this.tbcPrincipal.SuspendLayout();
            this.tbcConfigurarPagina.SuspendLayout();
            this.tbcConfiguarCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbcConfigurarPagina);
            this.tbcPrincipal.Controls.Add(this.tbcConfiguarCampos);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbcPrincipal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 9);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(723, 285);
            this.tbcPrincipal.TabIndex = 3;
            // 
            // tbcConfigurarPagina
            // 
            this.tbcConfigurarPagina.Controls.Add(this.txtEspacamentoDireita);
            this.tbcConfigurarPagina.Controls.Add(this.txtEspacamentoEsquerda);
            this.tbcConfigurarPagina.Controls.Add(this.txtEspacamentoLinhas);
            this.tbcConfigurarPagina.Controls.Add(this.txtEspacamentoColunas);
            this.tbcConfigurarPagina.Controls.Add(this.txtQtdeLinhas);
            this.tbcConfigurarPagina.Controls.Add(this.txtQtdeColunas);
            this.tbcConfigurarPagina.Controls.Add(this.lblEspacamentoDireita);
            this.tbcConfigurarPagina.Controls.Add(this.lblEspacamentoEsquerda);
            this.tbcConfigurarPagina.Controls.Add(this.lblEspacamentoLinhas);
            this.tbcConfigurarPagina.Controls.Add(this.lblEspacamentoColunas);
            this.tbcConfigurarPagina.Controls.Add(this.lblQtdeLinhas);
            this.tbcConfigurarPagina.Controls.Add(this.lblQtdeColunas);
            this.tbcConfigurarPagina.Controls.Add(this.BtnSalvar);
            this.tbcConfigurarPagina.Controls.Add(this.txtQtdeEtiquetaPágina);
            this.tbcConfigurarPagina.Controls.Add(this.txtQtdeEtiquetaColuna);
            this.tbcConfigurarPagina.Controls.Add(this.txtQtdeEtiquetaLinha);
            this.tbcConfigurarPagina.Controls.Add(this.txtLarguraPagina);
            this.tbcConfigurarPagina.Controls.Add(this.txtLarguraEtiqueta);
            this.tbcConfigurarPagina.Controls.Add(this.txtAlturaPagina);
            this.tbcConfigurarPagina.Controls.Add(this.txtAlturaEtiqueta);
            this.tbcConfigurarPagina.Controls.Add(this.lblNomeFormato);
            this.tbcConfigurarPagina.Controls.Add(this.txtNomeFormato);
            this.tbcConfigurarPagina.Controls.Add(this.lblQtdeEtiquetaPágina);
            this.tbcConfigurarPagina.Controls.Add(this.lblQtdeEtiquetaColuna);
            this.tbcConfigurarPagina.Controls.Add(this.lblLarguraPagina);
            this.tbcConfigurarPagina.Controls.Add(this.lblQtdeEtiquetaLinha);
            this.tbcConfigurarPagina.Controls.Add(this.lblLarguraEtiqueta);
            this.tbcConfigurarPagina.Controls.Add(this.lblAlturaPagina);
            this.tbcConfigurarPagina.Controls.Add(this.lblAlturaEtiqueta);
            this.tbcConfigurarPagina.Location = new System.Drawing.Point(4, 26);
            this.tbcConfigurarPagina.Name = "tbcConfigurarPagina";
            this.tbcConfigurarPagina.Padding = new System.Windows.Forms.Padding(3);
            this.tbcConfigurarPagina.Size = new System.Drawing.Size(715, 255);
            this.tbcConfigurarPagina.TabIndex = 1;
            this.tbcConfigurarPagina.Text = "Configuração da Página";
            this.tbcConfigurarPagina.UseVisualStyleBackColor = true;
            // 
            // txtEspacamentoDireita
            // 
            this.txtEspacamentoDireita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacamentoDireita.Location = new System.Drawing.Point(602, 153);
            this.txtEspacamentoDireita.Name = "txtEspacamentoDireita";
            this.txtEspacamentoDireita.Size = new System.Drawing.Size(100, 23);
            this.txtEspacamentoDireita.TabIndex = 20;
            // 
            // txtEspacamentoEsquerda
            // 
            this.txtEspacamentoEsquerda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacamentoEsquerda.Location = new System.Drawing.Point(602, 127);
            this.txtEspacamentoEsquerda.Name = "txtEspacamentoEsquerda";
            this.txtEspacamentoEsquerda.Size = new System.Drawing.Size(100, 23);
            this.txtEspacamentoEsquerda.TabIndex = 21;
            // 
            // txtEspacamentoLinhas
            // 
            this.txtEspacamentoLinhas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacamentoLinhas.Location = new System.Drawing.Point(602, 101);
            this.txtEspacamentoLinhas.Name = "txtEspacamentoLinhas";
            this.txtEspacamentoLinhas.Size = new System.Drawing.Size(100, 23);
            this.txtEspacamentoLinhas.TabIndex = 22;
            // 
            // txtEspacamentoColunas
            // 
            this.txtEspacamentoColunas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacamentoColunas.Location = new System.Drawing.Point(602, 75);
            this.txtEspacamentoColunas.Name = "txtEspacamentoColunas";
            this.txtEspacamentoColunas.Size = new System.Drawing.Size(100, 23);
            this.txtEspacamentoColunas.TabIndex = 23;
            // 
            // txtQtdeLinhas
            // 
            this.txtQtdeLinhas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeLinhas.Location = new System.Drawing.Point(602, 49);
            this.txtQtdeLinhas.Name = "txtQtdeLinhas";
            this.txtQtdeLinhas.Size = new System.Drawing.Size(100, 23);
            this.txtQtdeLinhas.TabIndex = 24;
            // 
            // txtQtdeColunas
            // 
            this.txtQtdeColunas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeColunas.Location = new System.Drawing.Point(602, 23);
            this.txtQtdeColunas.Name = "txtQtdeColunas";
            this.txtQtdeColunas.Size = new System.Drawing.Size(100, 23);
            this.txtQtdeColunas.TabIndex = 25;
            // 
            // lblEspacamentoDireita
            // 
            this.lblEspacamentoDireita.AutoSize = true;
            this.lblEspacamentoDireita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacamentoDireita.Location = new System.Drawing.Point(404, 157);
            this.lblEspacamentoDireita.Name = "lblEspacamentoDireita";
            this.lblEspacamentoDireita.Size = new System.Drawing.Size(157, 17);
            this.lblEspacamentoDireita.TabIndex = 19;
            this.lblEspacamentoDireita.Text = "Espaçamento a Direita";
            // 
            // lblEspacamentoEsquerda
            // 
            this.lblEspacamentoEsquerda.AutoSize = true;
            this.lblEspacamentoEsquerda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacamentoEsquerda.Location = new System.Drawing.Point(404, 131);
            this.lblEspacamentoEsquerda.Name = "lblEspacamentoEsquerda";
            this.lblEspacamentoEsquerda.Size = new System.Drawing.Size(174, 17);
            this.lblEspacamentoEsquerda.TabIndex = 18;
            this.lblEspacamentoEsquerda.Text = "Espaçamento a Esquerda";
            // 
            // lblEspacamentoLinhas
            // 
            this.lblEspacamentoLinhas.AutoSize = true;
            this.lblEspacamentoLinhas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacamentoLinhas.Location = new System.Drawing.Point(404, 105);
            this.lblEspacamentoLinhas.Name = "lblEspacamentoLinhas";
            this.lblEspacamentoLinhas.Size = new System.Drawing.Size(168, 17);
            this.lblEspacamentoLinhas.TabIndex = 17;
            this.lblEspacamentoLinhas.Text = "Espaçamento das Linhas";
            // 
            // lblEspacamentoColunas
            // 
            this.lblEspacamentoColunas.AutoSize = true;
            this.lblEspacamentoColunas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacamentoColunas.Location = new System.Drawing.Point(404, 79);
            this.lblEspacamentoColunas.Name = "lblEspacamentoColunas";
            this.lblEspacamentoColunas.Size = new System.Drawing.Size(182, 17);
            this.lblEspacamentoColunas.TabIndex = 16;
            this.lblEspacamentoColunas.Text = "Espaçamento das Colunas";
            // 
            // lblQtdeLinhas
            // 
            this.lblQtdeLinhas.AutoSize = true;
            this.lblQtdeLinhas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeLinhas.Location = new System.Drawing.Point(404, 53);
            this.lblQtdeLinhas.Name = "lblQtdeLinhas";
            this.lblQtdeLinhas.Size = new System.Drawing.Size(151, 17);
            this.lblQtdeLinhas.TabIndex = 15;
            this.lblQtdeLinhas.Text = "Quantidade de Linhas";
            // 
            // lblQtdeColunas
            // 
            this.lblQtdeColunas.AutoSize = true;
            this.lblQtdeColunas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeColunas.Location = new System.Drawing.Point(404, 27);
            this.lblQtdeColunas.Name = "lblQtdeColunas";
            this.lblQtdeColunas.Size = new System.Drawing.Size(165, 17);
            this.lblQtdeColunas.TabIndex = 14;
            this.lblQtdeColunas.Text = "Quantidade de Colunas";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(627, 219);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvar.TabIndex = 13;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtQtdeEtiquetaPágina
            // 
            this.txtQtdeEtiquetaPágina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEtiquetaPágina.Location = new System.Drawing.Point(261, 82);
            this.txtQtdeEtiquetaPágina.Name = "txtQtdeEtiquetaPágina";
            this.txtQtdeEtiquetaPágina.Size = new System.Drawing.Size(100, 23);
            this.txtQtdeEtiquetaPágina.TabIndex = 12;
            // 
            // txtQtdeEtiquetaColuna
            // 
            this.txtQtdeEtiquetaColuna.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEtiquetaColuna.Location = new System.Drawing.Point(261, 53);
            this.txtQtdeEtiquetaColuna.Name = "txtQtdeEtiquetaColuna";
            this.txtQtdeEtiquetaColuna.Size = new System.Drawing.Size(100, 23);
            this.txtQtdeEtiquetaColuna.TabIndex = 12;
            // 
            // txtQtdeEtiquetaLinha
            // 
            this.txtQtdeEtiquetaLinha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEtiquetaLinha.Location = new System.Drawing.Point(261, 27);
            this.txtQtdeEtiquetaLinha.Name = "txtQtdeEtiquetaLinha";
            this.txtQtdeEtiquetaLinha.Size = new System.Drawing.Size(100, 23);
            this.txtQtdeEtiquetaLinha.TabIndex = 12;
            // 
            // txtLarguraPagina
            // 
            this.txtLarguraPagina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLarguraPagina.Location = new System.Drawing.Point(261, 186);
            this.txtLarguraPagina.Name = "txtLarguraPagina";
            this.txtLarguraPagina.Size = new System.Drawing.Size(100, 23);
            this.txtLarguraPagina.TabIndex = 12;
            // 
            // txtLarguraEtiqueta
            // 
            this.txtLarguraEtiqueta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLarguraEtiqueta.Location = new System.Drawing.Point(261, 134);
            this.txtLarguraEtiqueta.Name = "txtLarguraEtiqueta";
            this.txtLarguraEtiqueta.Size = new System.Drawing.Size(100, 23);
            this.txtLarguraEtiqueta.TabIndex = 12;
            // 
            // txtAlturaPagina
            // 
            this.txtAlturaPagina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaPagina.Location = new System.Drawing.Point(261, 160);
            this.txtAlturaPagina.Name = "txtAlturaPagina";
            this.txtAlturaPagina.Size = new System.Drawing.Size(100, 23);
            this.txtAlturaPagina.TabIndex = 12;
            // 
            // txtAlturaEtiqueta
            // 
            this.txtAlturaEtiqueta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaEtiqueta.Location = new System.Drawing.Point(261, 108);
            this.txtAlturaEtiqueta.Name = "txtAlturaEtiqueta";
            this.txtAlturaEtiqueta.Size = new System.Drawing.Size(100, 23);
            this.txtAlturaEtiqueta.TabIndex = 12;
            // 
            // lblNomeFormato
            // 
            this.lblNomeFormato.AutoSize = true;
            this.lblNomeFormato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFormato.Location = new System.Drawing.Point(386, 224);
            this.lblNomeFormato.Name = "lblNomeFormato";
            this.lblNomeFormato.Size = new System.Drawing.Size(129, 17);
            this.lblNomeFormato.TabIndex = 11;
            this.lblNomeFormato.Text = "Nome do Formato";
            // 
            // txtNomeFormato
            // 
            this.txtNomeFormato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFormato.Location = new System.Drawing.Point(521, 223);
            this.txtNomeFormato.Name = "txtNomeFormato";
            this.txtNomeFormato.Size = new System.Drawing.Size(100, 23);
            this.txtNomeFormato.TabIndex = 9;
            // 
            // lblQtdeEtiquetaPágina
            // 
            this.lblQtdeEtiquetaPágina.AutoSize = true;
            this.lblQtdeEtiquetaPágina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeEtiquetaPágina.Location = new System.Drawing.Point(8, 81);
            this.lblQtdeEtiquetaPágina.Name = "lblQtdeEtiquetaPágina";
            this.lblQtdeEtiquetaPágina.Size = new System.Drawing.Size(247, 17);
            this.lblQtdeEtiquetaPágina.TabIndex = 8;
            this.lblQtdeEtiquetaPágina.Text = "Quantidade de Etiquetas por Página";
            // 
            // lblQtdeEtiquetaColuna
            // 
            this.lblQtdeEtiquetaColuna.AutoSize = true;
            this.lblQtdeEtiquetaColuna.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeEtiquetaColuna.Location = new System.Drawing.Point(8, 55);
            this.lblQtdeEtiquetaColuna.Name = "lblQtdeEtiquetaColuna";
            this.lblQtdeEtiquetaColuna.Size = new System.Drawing.Size(249, 17);
            this.lblQtdeEtiquetaColuna.TabIndex = 8;
            this.lblQtdeEtiquetaColuna.Text = "Quantidade de Etiquetas por Coluna";
            // 
            // lblLarguraPagina
            // 
            this.lblLarguraPagina.AutoSize = true;
            this.lblLarguraPagina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarguraPagina.Location = new System.Drawing.Point(8, 188);
            this.lblLarguraPagina.Name = "lblLarguraPagina";
            this.lblLarguraPagina.Size = new System.Drawing.Size(129, 17);
            this.lblLarguraPagina.TabIndex = 7;
            this.lblLarguraPagina.Text = "Largura da Página";
            // 
            // lblQtdeEtiquetaLinha
            // 
            this.lblQtdeEtiquetaLinha.AutoSize = true;
            this.lblQtdeEtiquetaLinha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeEtiquetaLinha.Location = new System.Drawing.Point(8, 29);
            this.lblQtdeEtiquetaLinha.Name = "lblQtdeEtiquetaLinha";
            this.lblQtdeEtiquetaLinha.Size = new System.Drawing.Size(235, 17);
            this.lblQtdeEtiquetaLinha.TabIndex = 8;
            this.lblQtdeEtiquetaLinha.Text = "Quantidade de Etiquetas por Linha";
            // 
            // lblLarguraEtiqueta
            // 
            this.lblLarguraEtiqueta.AutoSize = true;
            this.lblLarguraEtiqueta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarguraEtiqueta.Location = new System.Drawing.Point(8, 136);
            this.lblLarguraEtiqueta.Name = "lblLarguraEtiqueta";
            this.lblLarguraEtiqueta.Size = new System.Drawing.Size(137, 17);
            this.lblLarguraEtiqueta.TabIndex = 7;
            this.lblLarguraEtiqueta.Text = "Largura da Etiqueta";
            // 
            // lblAlturaPagina
            // 
            this.lblAlturaPagina.AutoSize = true;
            this.lblAlturaPagina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaPagina.Location = new System.Drawing.Point(8, 162);
            this.lblAlturaPagina.Name = "lblAlturaPagina";
            this.lblAlturaPagina.Size = new System.Drawing.Size(118, 17);
            this.lblAlturaPagina.TabIndex = 5;
            this.lblAlturaPagina.Text = "Altura da Página";
            // 
            // lblAlturaEtiqueta
            // 
            this.lblAlturaEtiqueta.AutoSize = true;
            this.lblAlturaEtiqueta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaEtiqueta.Location = new System.Drawing.Point(8, 110);
            this.lblAlturaEtiqueta.Name = "lblAlturaEtiqueta";
            this.lblAlturaEtiqueta.Size = new System.Drawing.Size(126, 17);
            this.lblAlturaEtiqueta.TabIndex = 5;
            this.lblAlturaEtiqueta.Text = "Altura da Etiqueta";
            // 
            // tbcConfiguarCampos
            // 
            this.tbcConfiguarCampos.Controls.Add(this.DataGridView1);
            this.tbcConfiguarCampos.Controls.Add(this.Button1);
            this.tbcConfiguarCampos.Controls.Add(this.Label7);
            this.tbcConfiguarCampos.Controls.Add(this.txtNomeModelo);
            this.tbcConfiguarCampos.Location = new System.Drawing.Point(4, 26);
            this.tbcConfiguarCampos.Name = "tbcConfiguarCampos";
            this.tbcConfiguarCampos.Size = new System.Drawing.Size(715, 340);
            this.tbcConfiguarCampos.TabIndex = 2;
            this.tbcConfiguarCampos.Text = "Configuação dos Campos";
            this.tbcConfiguarCampos.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(603, 276);
            this.DataGridView1.TabIndex = 43;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(520, 282);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 42;
            this.Button1.Text = "Salvar";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(304, 286);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 16);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "Nome do Modelo";
            // 
            // txtNomeModelo
            // 
            this.txtNomeModelo.Location = new System.Drawing.Point(414, 284);
            this.txtNomeModelo.Name = "txtNomeModelo";
            this.txtNomeModelo.Size = new System.Drawing.Size(100, 23);
            this.txtNomeModelo.TabIndex = 33;
            // 
            // ConfiguraEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 294);
            this.Controls.Add(this.tbcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguraEtiqueta";
            this.Text = "ConfiguraEtiquetas";
            this.tbcPrincipal.ResumeLayout(false);
            this.tbcConfigurarPagina.ResumeLayout(false);
            this.tbcConfigurarPagina.PerformLayout();
            this.tbcConfiguarCampos.ResumeLayout(false);
            this.tbcConfiguarCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tbcPrincipal;
        internal System.Windows.Forms.TabPage tbcConfigurarPagina;
        internal System.Windows.Forms.TextBox txtEspacamentoDireita;
        internal System.Windows.Forms.TextBox txtEspacamentoEsquerda;
        internal System.Windows.Forms.TextBox txtEspacamentoLinhas;
        internal System.Windows.Forms.TextBox txtEspacamentoColunas;
        internal System.Windows.Forms.TextBox txtQtdeLinhas;
        internal System.Windows.Forms.TextBox txtQtdeColunas;
        internal System.Windows.Forms.Label lblEspacamentoDireita;
        internal System.Windows.Forms.Label lblEspacamentoEsquerda;
        internal System.Windows.Forms.Label lblEspacamentoLinhas;
        internal System.Windows.Forms.Label lblEspacamentoColunas;
        internal System.Windows.Forms.Label lblQtdeLinhas;
        internal System.Windows.Forms.Label lblQtdeColunas;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.TextBox txtQtdeEtiquetaPágina;
        internal System.Windows.Forms.TextBox txtQtdeEtiquetaColuna;
        internal System.Windows.Forms.TextBox txtQtdeEtiquetaLinha;
        internal System.Windows.Forms.TextBox txtLarguraPagina;
        internal System.Windows.Forms.TextBox txtLarguraEtiqueta;
        internal System.Windows.Forms.TextBox txtAlturaPagina;
        internal System.Windows.Forms.TextBox txtAlturaEtiqueta;
        internal System.Windows.Forms.Label lblNomeFormato;
        internal System.Windows.Forms.TextBox txtNomeFormato;
        internal System.Windows.Forms.Label lblQtdeEtiquetaPágina;
        internal System.Windows.Forms.Label lblQtdeEtiquetaColuna;
        internal System.Windows.Forms.Label lblLarguraPagina;
        internal System.Windows.Forms.Label lblQtdeEtiquetaLinha;
        internal System.Windows.Forms.Label lblLarguraEtiqueta;
        internal System.Windows.Forms.Label lblAlturaPagina;
        internal System.Windows.Forms.Label lblAlturaEtiqueta;
        internal System.Windows.Forms.TabPage tbcConfiguarCampos;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtNomeModelo;
    }
}