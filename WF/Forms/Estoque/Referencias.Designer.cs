namespace WF.Forms.Produto
{
    partial class Referencias
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnCatalago = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.cboCatalago = new System.Windows.Forms.ComboBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lboReferencia = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.BtnExcluir);
            this.pnlFormulario.Controls.Add(this.BtnVoltar);
            this.pnlFormulario.Controls.Add(this.BtnSalvar);
            this.pnlFormulario.Controls.Add(this.btnCatalago);
            this.pnlFormulario.Controls.Add(this.dgvResultados);
            this.pnlFormulario.Controls.Add(this.cboCatalago);
            this.pnlFormulario.Controls.Add(this.txtReferencia);
            this.pnlFormulario.Controls.Add(this.lboReferencia);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(370, 391);
            this.pnlFormulario.TabIndex = 1;
            this.pnlFormulario.TabStop = true;
            // 
            // btnCatalago
            // 
            this.btnCatalago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalago.Location = new System.Drawing.Point(36, 49);
            this.btnCatalago.Name = "btnCatalago";
            this.btnCatalago.Size = new System.Drawing.Size(85, 30);
            this.btnCatalago.TabIndex = 2;
            this.btnCatalago.Text = "Catálagos";
            this.btnCatalago.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(12, 100);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowTemplate.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(346, 225);
            this.dgvResultados.TabIndex = 3;
            // 
            // cboCatalago
            // 
            this.cboCatalago.DisplayMember = "Código de Barras";
            this.cboCatalago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatalago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatalago.FormattingEnabled = true;
            this.cboCatalago.Items.AddRange(new object[] {
            "Código de Barras",
            "Código Interno",
            "Código Fornecedor"});
            this.cboCatalago.Location = new System.Drawing.Point(134, 51);
            this.cboCatalago.Name = "cboCatalago";
            this.cboCatalago.Size = new System.Drawing.Size(196, 25);
            this.cboCatalago.TabIndex = 1;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(134, 19);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(196, 23);
            this.txtReferencia.TabIndex = 0;
            // 
            // lboReferencia
            // 
            this.lboReferencia.AutoSize = true;
            this.lboReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboReferencia.Location = new System.Drawing.Point(33, 22);
            this.lboReferencia.Name = "lboReferencia";
            this.lboReferencia.Size = new System.Drawing.Size(76, 17);
            this.lboReferencia.TabIndex = 0;
            this.lboReferencia.Text = "Referência";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(202, 349);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 30);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(283, 349);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(121, 349);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // Referencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 391);
            this.Controls.Add(this.pnlFormulario);
            this.Name = "Referencias";
            this.Text = "Referencias";
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlFormulario;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Button btnCatalago;
        internal System.Windows.Forms.DataGridView dgvResultados;
        internal System.Windows.Forms.ComboBox cboCatalago;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.Label lboReferencia;
    }
}