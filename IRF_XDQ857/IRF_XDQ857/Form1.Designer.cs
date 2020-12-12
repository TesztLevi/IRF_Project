namespace IRF_XDQ857
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.button_matchstart = new System.Windows.Forms.ToolStripButton();
            this.button_awayteam = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.játékosokKiírásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meccsekKiírásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.button_matchstart,
            this.button_awayteam,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1437, 34);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 29);
            this.toolStripButton1.Text = "Új Meccs";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(110, 29);
            this.toolStripButton3.Text = "Játékos Piac";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // button_matchstart
            // 
            this.button_matchstart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_matchstart.Enabled = false;
            this.button_matchstart.Image = ((System.Drawing.Image)(resources.GetObject("button_matchstart.Image")));
            this.button_matchstart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_matchstart.Name = "button_matchstart";
            this.button_matchstart.Size = new System.Drawing.Size(115, 29);
            this.button_matchstart.Text = "Kezdősípszó";
            this.button_matchstart.Click += new System.EventHandler(this.button_matchstart_Click);
            // 
            // button_awayteam
            // 
            this.button_awayteam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_awayteam.Enabled = false;
            this.button_awayteam.Image = ((System.Drawing.Image)(resources.GetObject("button_awayteam.Image")));
            this.button_awayteam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_awayteam.Name = "button_awayteam";
            this.button_awayteam.Size = new System.Drawing.Size(229, 29);
            this.button_awayteam.Text = "Ellenfél csapat összeállítása";
            this.button_awayteam.Click += new System.EventHandler(this.Button_awayteam_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.játékosokKiírásaToolStripMenuItem,
            this.meccsekKiírásaToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(124, 29);
            this.toolStripSplitButton1.Text = "CSV-be írás";
            // 
            // játékosokKiírásaToolStripMenuItem
            // 
            this.játékosokKiírásaToolStripMenuItem.Name = "játékosokKiírásaToolStripMenuItem";
            this.játékosokKiírásaToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.játékosokKiírásaToolStripMenuItem.Text = "Játékosok kiírása";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 580);
            this.panel1.TabIndex = 8;
            // 
            // meccsekKiírásaToolStripMenuItem
            // 
            this.meccsekKiírásaToolStripMenuItem.Name = "meccsekKiírásaToolStripMenuItem";
            this.meccsekKiírásaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.meccsekKiírásaToolStripMenuItem.Text = "Meccsek kiírása";
            this.meccsekKiírásaToolStripMenuItem.Click += new System.EventHandler(this.MeccsekKiírásaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 820);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton button_matchstart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem játékosokKiírásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton button_awayteam;
        private System.Windows.Forms.ToolStripMenuItem meccsekKiírásaToolStripMenuItem;
    }
}

