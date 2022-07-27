namespace WF.Forms.Estoque
{
    partial class ConfiguraGridView
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(348, 236);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 30);
            this.BtnVoltar.TabIndex = 9;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(267, 236);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // ConfiguraGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 278);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguraGridView";
            this.Text = "ConfiguraGridView";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnVoltar;
        internal System.Windows.Forms.Button BtnSalvar;
    }
}