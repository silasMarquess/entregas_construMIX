
namespace AGENDA_ENTREGA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCOESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasRegistradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCOESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCOESToolStripMenuItem
            // 
            this.oPCOESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaEntregaToolStripMenuItem,
            this.entregasRegistradasToolStripMenuItem});
            this.oPCOESToolStripMenuItem.Name = "oPCOESToolStripMenuItem";
            this.oPCOESToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.oPCOESToolStripMenuItem.Text = "OPCOES";
            // 
            // novaEntregaToolStripMenuItem
            // 
            this.novaEntregaToolStripMenuItem.Name = "novaEntregaToolStripMenuItem";
            this.novaEntregaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.novaEntregaToolStripMenuItem.Text = "1 - Nova Entrega";
            // 
            // entregasRegistradasToolStripMenuItem
            // 
            this.entregasRegistradasToolStripMenuItem.Name = "entregasRegistradasToolStripMenuItem";
            this.entregasRegistradasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.entregasRegistradasToolStripMenuItem.Text = "2 - Entregas Registradas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 446);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCOESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasRegistradasToolStripMenuItem;
    }
}

