namespace WF.Forms.Estoque
{
    partial class BuscaRequisicoe
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
            this.pnlRequisicao = new System.Windows.Forms.Panel();
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
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvBuscaRequisicao = new System.Windows.Forms.DataGridView();
            this.pnlPrincipal.SuspendLayout();
            this.pnlRequisicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaRequisicao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlRequisicao);
            this.pnlPrincipal.Controls.Add(this.BtnLimpar);
            this.pnlPrincipal.Controls.Add(this.btnAprovar);
            this.pnlPrincipal.Controls.Add(this.btnPesquisar);
            this.pnlPrincipal.Controls.Add(this.btnVoltar);
            this.pnlPrincipal.Controls.Add(this.dgvBuscaRequisicao);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(550, 420);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // pnlRequisicao
            // 
            this.pnlRequisicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnlRequisicao.Size = new System.Drawing.Size(440, 149);
            this.pnlRequisicao.TabIndex = 49;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(354, 10);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(74, 21);
            this.cboStatus.TabIndex = 19;
            // 
            // cboAtendidoPor
            // 
            this.cboAtendidoPor.FormattingEnabled = true;
            this.cboAtendidoPor.Location = new System.Drawing.Point(81, 116);
            this.cboAtendidoPor.Name = "cboAtendidoPor";
            this.cboAtendidoPor.Size = new System.Drawing.Size(110, 21);
            this.cboAtendidoPor.TabIndex = 18;
            // 
            // cboAprovadoPor
            // 
            this.cboAprovadoPor.FormattingEnabled = true;
            this.cboAprovadoPor.Location = new System.Drawing.Point(81, 79);
            this.cboAprovadoPor.Name = "cboAprovadoPor";
            this.cboAprovadoPor.Size = new System.Drawing.Size(110, 21);
            this.cboAprovadoPor.TabIndex = 18;
            // 
            // cboSolicitadoPor
            // 
            this.cboSolicitadoPor.FormattingEnabled = true;
            this.cboSolicitadoPor.Location = new System.Drawing.Point(81, 42);
            this.cboSolicitadoPor.Name = "cboSolicitadoPor";
            this.cboSolicitadoPor.Size = new System.Drawing.Size(110, 21);
            this.cboSolicitadoPor.TabIndex = 18;
            // 
            // cboTipoRequisicao
            // 
            this.cboTipoRequisicao.FormattingEnabled = true;
            this.cboTipoRequisicao.Location = new System.Drawing.Point(195, 10);
            this.cboTipoRequisicao.Name = "cboTipoRequisicao";
            this.cboTipoRequisicao.Size = new System.Drawing.Size(110, 21);
            this.cboTipoRequisicao.TabIndex = 18;
            // 
            // lblDataConclusao
            // 
            this.lblDataConclusao.AutoSize = true;
            this.lblDataConclusao.Location = new System.Drawing.Point(197, 119);
            this.lblDataConclusao.Name = "lblDataConclusao";
            this.lblDataConclusao.Size = new System.Drawing.Size(83, 13);
            this.lblDataConclusao.TabIndex = 17;
            this.lblDataConclusao.Text = "Data Conclusão";
            // 
            // txtHoraConclusao
            // 
            this.txtHoraConclusao.Location = new System.Drawing.Point(361, 116);
            this.txtHoraConclusao.Name = "txtHoraConclusao";
            this.txtHoraConclusao.Size = new System.Drawing.Size(67, 20);
            this.txtHoraConclusao.TabIndex = 16;
            // 
            // txtDataConclusao
            // 
            this.txtDataConclusao.Location = new System.Drawing.Point(288, 116);
            this.txtDataConclusao.Name = "txtDataConclusao";
            this.txtDataConclusao.Size = new System.Drawing.Size(67, 20);
            this.txtDataConclusao.TabIndex = 16;
            // 
            // txtHoraAprovacao
            // 
            this.txtHoraAprovacao.Location = new System.Drawing.Point(361, 79);
            this.txtHoraAprovacao.Name = "txtHoraAprovacao";
            this.txtHoraAprovacao.Size = new System.Drawing.Size(67, 20);
            this.txtHoraAprovacao.TabIndex = 14;
            // 
            // txtDataProvacao
            // 
            this.txtDataProvacao.Location = new System.Drawing.Point(288, 79);
            this.txtDataProvacao.Name = "txtDataProvacao";
            this.txtDataProvacao.Size = new System.Drawing.Size(67, 20);
            this.txtDataProvacao.TabIndex = 13;
            // 
            // txtHoraEmissao
            // 
            this.txtHoraEmissao.Location = new System.Drawing.Point(361, 42);
            this.txtHoraEmissao.Name = "txtHoraEmissao";
            this.txtHoraEmissao.Size = new System.Drawing.Size(67, 20);
            this.txtHoraEmissao.TabIndex = 12;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Location = new System.Drawing.Point(288, 42);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(67, 20);
            this.txtDataEmissao.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(49, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(50, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblAprovadoPor
            // 
            this.lblAprovadoPor.AutoSize = true;
            this.lblAprovadoPor.Location = new System.Drawing.Point(3, 82);
            this.lblAprovadoPor.Name = "lblAprovadoPor";
            this.lblAprovadoPor.Size = new System.Drawing.Size(72, 13);
            this.lblAprovadoPor.TabIndex = 7;
            this.lblAprovadoPor.Text = "Aprovado Por";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(311, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblSolicitadoPor
            // 
            this.lblSolicitadoPor.AutoSize = true;
            this.lblSolicitadoPor.Location = new System.Drawing.Point(3, 45);
            this.lblSolicitadoPor.Name = "lblSolicitadoPor";
            this.lblSolicitadoPor.Size = new System.Drawing.Size(72, 13);
            this.lblSolicitadoPor.TabIndex = 6;
            this.lblSolicitadoPor.Text = "Solicitado Por";
            // 
            // lblAtendidoPor
            // 
            this.lblAtendidoPor.AutoSize = true;
            this.lblAtendidoPor.Location = new System.Drawing.Point(3, 119);
            this.lblAtendidoPor.Name = "lblAtendidoPor";
            this.lblAtendidoPor.Size = new System.Drawing.Size(68, 13);
            this.lblAtendidoPor.TabIndex = 8;
            this.lblAtendidoPor.Text = "Atendido Por";
            // 
            // lblDataAprovacao
            // 
            this.lblDataAprovacao.AutoSize = true;
            this.lblDataAprovacao.Location = new System.Drawing.Point(197, 82);
            this.lblDataAprovacao.Name = "lblDataAprovacao";
            this.lblDataAprovacao.Size = new System.Drawing.Size(85, 13);
            this.lblDataAprovacao.TabIndex = 4;
            this.lblDataAprovacao.Text = "Data Aprovação";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(197, 45);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(72, 13);
            this.lblDataEmissao.TabIndex = 3;
            this.lblDataEmissao.Text = "Data Emissão";
            // 
            // lblTipoRequisicao
            // 
            this.lblTipoRequisicao.AutoSize = true;
            this.lblTipoRequisicao.Location = new System.Drawing.Point(105, 13);
            this.lblTipoRequisicao.Name = "lblTipoRequisicao";
            this.lblTipoRequisicao.Size = new System.Drawing.Size(84, 13);
            this.lblTipoRequisicao.TabIndex = 2;
            this.lblTipoRequisicao.Text = "Tipo Requisição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(296, 345);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 45;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAprovar
            // 
            this.btnAprovar.Location = new System.Drawing.Point(12, 345);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(55, 23);
            this.btnAprovar.TabIndex = 2;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(215, 345);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(377, 345);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvBuscaRequisicao
            // 
            this.dgvBuscaRequisicao.AllowUserToAddRows = false;
            this.dgvBuscaRequisicao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscaRequisicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscaRequisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaRequisicao.Location = new System.Drawing.Point(12, 167);
            this.dgvBuscaRequisicao.Name = "dgvBuscaRequisicao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBuscaRequisicao.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscaRequisicao.Size = new System.Drawing.Size(440, 172);
            this.dgvBuscaRequisicao.TabIndex = 37;
            // 
            // BuscaRequisicoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaRequisicoe";
            this.Text = "BuscaRequisicoes";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlRequisicao.ResumeLayout(false);
            this.pnlRequisicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaRequisicao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.Panel pnlRequisicao;
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
        internal System.Windows.Forms.Button BtnLimpar;
        internal System.Windows.Forms.Button btnAprovar;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Button btnVoltar;
        internal System.Windows.Forms.DataGridView dgvBuscaRequisicao;
    }
}