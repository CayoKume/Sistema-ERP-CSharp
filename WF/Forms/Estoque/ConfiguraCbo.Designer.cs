namespace WF.Forms.Estoque
{
    partial class ConfiguraCbo
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
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.lboCategoria = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.BtnRemover);
            this.pnlPrincipal.Controls.Add(this.BtnVoltar);
            this.pnlPrincipal.Controls.Add(this.BtnAdicionar);
            this.pnlPrincipal.Controls.Add(this.cboCategorias);
            this.pnlPrincipal.Controls.Add(this.lboCategoria);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(380, 130);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.Location = new System.Drawing.Point(212, 88);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(75, 30);
            this.BtnRemover.TabIndex = 4;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(293, 88);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(131, 88);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 30);
            this.BtnAdicionar.TabIndex = 3;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // cboCategorias
            // 
            this.cboCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(171, 39);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(197, 25);
            this.cboCategorias.TabIndex = 0;
            // 
            // lboCategoria
            // 
            this.lboCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lboCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboCategoria.Location = new System.Drawing.Point(12, 38);
            this.lboCategoria.Name = "lboCategoria";
            this.lboCategoria.Size = new System.Drawing.Size(153, 25);
            this.lboCategoria.TabIndex = 0;
            this.lboCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfiguraCbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 130);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguraCbo";
            this.Text = "ConfiguraCbo";
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.Button BtnRemover;
        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnAdicionar;
        internal System.Windows.Forms.ComboBox cboCategorias;
        internal System.Windows.Forms.Label lboCategoria;
    }
}