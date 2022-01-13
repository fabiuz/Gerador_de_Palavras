namespace Gerador_de_Palavras
{
    partial class frmGeradorDePalavras
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
            this.mnArquivo = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoNovoProjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoAbrirProjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnArquivo
            // 
            this.mnArquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.mnArquivo.Location = new System.Drawing.Point(0, 0);
            this.mnArquivo.MdiWindowListItem = this.arquivoToolStripMenuItem;
            this.mnArquivo.Name = "mnArquivo";
            this.mnArquivo.Size = new System.Drawing.Size(800, 24);
            this.mnArquivo.TabIndex = 1;
            this.mnArquivo.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivoNovoProjeto,
            this.mnArquivoAbrirProjeto,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "A&rquivo";
            // 
            // mnArquivoNovoProjeto
            // 
            this.mnArquivoNovoProjeto.Name = "mnArquivoNovoProjeto";
            this.mnArquivoNovoProjeto.Size = new System.Drawing.Size(180, 22);
            this.mnArquivoNovoProjeto.Text = "&Novo Projeto";
            this.mnArquivoNovoProjeto.Click += new System.EventHandler(this.mnArquivoNovoProjeto_Click);
            // 
            // mnArquivoAbrirProjeto
            // 
            this.mnArquivoAbrirProjeto.Name = "mnArquivoAbrirProjeto";
            this.mnArquivoAbrirProjeto.Size = new System.Drawing.Size(180, 22);
            this.mnArquivoAbrirProjeto.Text = "Abrir &Projeto";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // frmGeradorDePalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnArquivo);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnArquivo;
            this.Name = "frmGeradorDePalavras";
            this.Text = "Gerador de Palavras v2.0";
            this.mnArquivo.ResumeLayout(false);
            this.mnArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnArquivo;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoNovoProjeto;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoAbrirProjeto;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}