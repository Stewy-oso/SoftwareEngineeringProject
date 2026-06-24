namespace Shoey
{
    partial class frmSeePopularity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeePopularity));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chrtPopularity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitSys,
            this.backToMainMnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitSys
            // 
            this.exitSys.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitSys.BackColor = System.Drawing.Color.Red;
            this.exitSys.Name = "exitSys";
            this.exitSys.Size = new System.Drawing.Size(38, 20);
            this.exitSys.Text = "Exit";
            this.exitSys.Click += new System.EventHandler(this.exitSys_Click);
            // 
            // backToMainMnu
            // 
            this.backToMainMnu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToMainMnu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backToMainMnu.Name = "backToMainMnu";
            this.backToMainMnu.Size = new System.Drawing.Size(44, 20);
            this.backToMainMnu.Text = "Back";
            this.backToMainMnu.Click += new System.EventHandler(this.backToMainMnu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 424);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chrtPopularity
            // 
            this.chrtPopularity.BackColor = System.Drawing.Color.DimGray;
            this.chrtPopularity.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.Name = "ChartArea1";
            this.chrtPopularity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtPopularity.Legends.Add(legend1);
            this.chrtPopularity.Location = new System.Drawing.Point(26, 40);
            this.chrtPopularity.Name = "chrtPopularity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtPopularity.Series.Add(series1);
            this.chrtPopularity.Size = new System.Drawing.Size(747, 398);
            this.chrtPopularity.TabIndex = 2;
            this.chrtPopularity.Text = "Popularity";
            // 
            // frmSeePopularity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chrtPopularity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeePopularity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popularity";
            this.Load += new System.EventHandler(this.frmSeePopularity_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem backToMainMnu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPopularity;
    }
}