namespace Shoey
{
    partial class frmTrackSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackSales));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToStock = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.toToYrlyrevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToStock,
            this.exitSys,
            this.backToMnu,
            this.toToYrlyrevenue});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToStock
            // 
            this.goToStock.Name = "goToStock";
            this.goToStock.Size = new System.Drawing.Size(48, 20);
            this.goToStock.Text = "Stock";
            this.goToStock.Click += new System.EventHandler(this.goToStock_Click);
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
            // backToMnu
            // 
            this.backToMnu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToMnu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backToMnu.Name = "backToMnu";
            this.backToMnu.Size = new System.Drawing.Size(44, 20);
            this.backToMnu.Text = "Back";
            this.backToMnu.Click += new System.EventHandler(this.backToMnu_Click);
            // 
            // toToYrlyrevenue
            // 
            this.toToYrlyrevenue.Name = "toToYrlyrevenue";
            this.toToYrlyrevenue.Size = new System.Drawing.Size(98, 20);
            this.toToYrlyrevenue.Text = "Yearly Revenue";
            this.toToYrlyrevenue.Click += new System.EventHandler(this.goToAnalytics_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 423);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(173, 42);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.Size = new System.Drawing.Size(452, 396);
            this.dgvSales.TabIndex = 4;
            // 
            // frmTrackSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrackSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Sales";
            this.Load += new System.EventHandler(this.frmTrackSales_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToStock;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem backToMnu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toToYrlyrevenue;
        private System.Windows.Forms.DataGridView dgvSales;
    }
}