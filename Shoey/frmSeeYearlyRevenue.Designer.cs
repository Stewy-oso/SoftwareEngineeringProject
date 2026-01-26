namespace Shoey
{
    partial class frmSeeYearlyRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeeYearlyRevenue));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitYrlyRev = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnCalculateRevenue = new System.Windows.Forms.Button();
            this.lblYearlyRevenue = new System.Windows.Forms.Label();
            this.lblPickYr = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitYrlyRev,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitYrlyRev
            // 
            this.exitYrlyRev.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitYrlyRev.BackColor = System.Drawing.Color.Red;
            this.exitYrlyRev.Name = "exitYrlyRev";
            this.exitYrlyRev.Size = new System.Drawing.Size(37, 20);
            this.exitYrlyRev.Text = "Exit";
            this.exitYrlyRev.Click += new System.EventHandler(this.exitYrlyRevClick);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(350, 137);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 2;
            // 
            // btnCalculateRevenue
            // 
            this.btnCalculateRevenue.Location = new System.Drawing.Point(367, 195);
            this.btnCalculateRevenue.Name = "btnCalculateRevenue";
            this.btnCalculateRevenue.Size = new System.Drawing.Size(90, 46);
            this.btnCalculateRevenue.TabIndex = 3;
            this.btnCalculateRevenue.Text = "Calculate Revenue";
            this.btnCalculateRevenue.UseVisualStyleBackColor = true;
            this.btnCalculateRevenue.Click += new System.EventHandler(this.btnCalculateRevenue_Click);
            // 
            // lblYearlyRevenue
            // 
            this.lblYearlyRevenue.AutoSize = true;
            this.lblYearlyRevenue.Location = new System.Drawing.Point(325, 259);
            this.lblYearlyRevenue.Name = "lblYearlyRevenue";
            this.lblYearlyRevenue.Size = new System.Drawing.Size(171, 13);
            this.lblYearlyRevenue.TabIndex = 4;
            this.lblYearlyRevenue.Text = "Yearly Revenue for chosen year: €";
            // 
            // lblPickYr
            // 
            this.lblPickYr.AutoSize = true;
            this.lblPickYr.Location = new System.Drawing.Point(356, 122);
            this.lblPickYr.Name = "lblPickYr";
            this.lblPickYr.Size = new System.Drawing.Size(109, 13);
            this.lblPickYr.TabIndex = 5;
            this.lblPickYr.Text = "Please choose a year";
            // 
            // frmSeeYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPickYr);
            this.Controls.Add(this.lblYearlyRevenue);
            this.Controls.Add(this.btnCalculateRevenue);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeeYearlyRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yearly Revenue";
            this.Load += new System.EventHandler(this.frmSeeYearlyRevenue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitYrlyRev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnCalculateRevenue;
        private System.Windows.Forms.Label lblYearlyRevenue;
        private System.Windows.Forms.Label lblPickYr;
    }
}