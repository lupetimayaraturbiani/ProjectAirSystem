namespace teste1.Views
{
    partial class frmPrincipal
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
            this.btnListaAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaAvioes
            // 
            this.btnListaAvioes.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnListaAvioes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaAvioes.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaAvioes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaAvioes.Location = new System.Drawing.Point(142, 80);
            this.btnListaAvioes.Name = "btnListaAvioes";
            this.btnListaAvioes.Size = new System.Drawing.Size(204, 131);
            this.btnListaAvioes.TabIndex = 0;
            this.btnListaAvioes.Text = "Lista Aviões";
            this.btnListaAvioes.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGerenciarAviao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarAviao.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarAviao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerenciarAviao.Location = new System.Drawing.Point(447, 80);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(204, 131);
            this.btnGerenciarAviao.TabIndex = 1;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGerenciarCompanhia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarCompanhia.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarCompanhia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(142, 270);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(204, 131);
            this.btnGerenciarCompanhia.TabIndex = 2;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGerenciarRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarRelatorios.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarRelatorios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(447, 270);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(204, 131);
            this.btnGerenciarRelatorios.TabIndex = 3;
            this.btnGerenciarRelatorios.Text = "Gerenciar Relatórios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListaAvioes);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
    }
}