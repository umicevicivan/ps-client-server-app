namespace RecenzijaFilma
{
    partial class FrmGlavnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glumacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRecenzijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmToolStripMenuItem,
            this.glumacToolStripMenuItem,
            this.novaRecenzijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(521, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.izmenaToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // izmenaToolStripMenuItem
            // 
            this.izmenaToolStripMenuItem.Name = "izmenaToolStripMenuItem";
            this.izmenaToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.izmenaToolStripMenuItem.Text = "Izmena / Brisanje";
            this.izmenaToolStripMenuItem.Click += new System.EventHandler(this.izmenaToolStripMenuItem_Click);
            // 
            // glumacToolStripMenuItem
            // 
            this.glumacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem1,
            this.izmenaToolStripMenuItem1});
            this.glumacToolStripMenuItem.Name = "glumacToolStripMenuItem";
            this.glumacToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.glumacToolStripMenuItem.Text = "Glumac";
            // 
            // unosToolStripMenuItem1
            // 
            this.unosToolStripMenuItem1.Name = "unosToolStripMenuItem1";
            this.unosToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.unosToolStripMenuItem1.Text = "Unos novog glumca";
            this.unosToolStripMenuItem1.Click += new System.EventHandler(this.unosToolStripMenuItem1_Click);
            // 
            // izmenaToolStripMenuItem1
            // 
            this.izmenaToolStripMenuItem1.Name = "izmenaToolStripMenuItem1";
            this.izmenaToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.izmenaToolStripMenuItem1.Text = "Brisanje / Izmena";
            this.izmenaToolStripMenuItem1.Click += new System.EventHandler(this.izmenaToolStripMenuItem1_Click);
            // 
            // novaRecenzijaToolStripMenuItem
            // 
            this.novaRecenzijaToolStripMenuItem.Name = "novaRecenzijaToolStripMenuItem";
            this.novaRecenzijaToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.novaRecenzijaToolStripMenuItem.Text = "Nova recenzija";
            this.novaRecenzijaToolStripMenuItem.Click += new System.EventHandler(this.novaRecenzijaToolStripMenuItem_Click);
            // 
            // FrmGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 335);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGlavnaForma";
            this.Text = "FrmGlavnaForma";
            this.Load += new System.EventHandler(this.FrmGlavnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glumacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmenaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaRecenzijaToolStripMenuItem;
    }
}