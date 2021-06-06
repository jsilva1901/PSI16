namespace ProjetoPSI16AFJS
{
    partial class MainFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFRM));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilhetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stbStrip = new System.Windows.Forms.StatusStrip();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem,
            this.bilhetesToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(718, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "Menu";
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // bilhetesToolStripMenuItem
            // 
            this.bilhetesToolStripMenuItem.Name = "bilhetesToolStripMenuItem";
            this.bilhetesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.bilhetesToolStripMenuItem.Text = "Bilhetes";
            this.bilhetesToolStripMenuItem.Click += new System.EventHandler(this.bilhetesToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // stbStrip
            // 
            this.stbStrip.Location = new System.Drawing.Point(0, 502);
            this.stbStrip.Name = "stbStrip";
            this.stbStrip.Size = new System.Drawing.Size(718, 22);
            this.stbStrip.TabIndex = 2;
            this.stbStrip.Text = "stbStrip";
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 524);
            this.Controls.Add(this.stbStrip);
            this.Controls.Add(this.mnuMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "MainFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cinemas JMC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainFRM_Activated);
            this.Load += new System.EventHandler(this.MainFRM_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilhetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stbStrip;
    }
}

