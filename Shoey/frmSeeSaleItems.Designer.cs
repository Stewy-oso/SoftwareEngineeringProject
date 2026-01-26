namespace Shoey
{
    partial class frmSeeSaleItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeeSaleItems));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToTrackSales = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxSaleItems = new System.Windows.Forms.ListBox();
            this.currentStockLbl = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.markAsSoldBtn = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToTrackSales,
            this.exitSys,
            this.backToMnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToTrackSales
            // 
            this.goToTrackSales.Name = "goToTrackSales";
            this.goToTrackSales.Size = new System.Drawing.Size(76, 20);
            this.goToTrackSales.Text = "Track Sales";
            this.goToTrackSales.Click += new System.EventHandler(this.goToTrackSales_Click);
            // 
            // exitSys
            // 
            this.exitSys.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitSys.BackColor = System.Drawing.Color.Red;
            this.exitSys.Name = "exitSys";
            this.exitSys.Size = new System.Drawing.Size(37, 20);
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
            // listBoxSaleItems
            // 
            this.listBoxSaleItems.FormattingEnabled = true;
            this.listBoxSaleItems.Location = new System.Drawing.Point(269, 60);
            this.listBoxSaleItems.Name = "listBoxSaleItems";
            this.listBoxSaleItems.Size = new System.Drawing.Size(297, 212);
            this.listBoxSaleItems.TabIndex = 2;
            // 
            // currentStockLbl
            // 
            this.currentStockLbl.AutoSize = true;
            this.currentStockLbl.Location = new System.Drawing.Point(380, 44);
            this.currentStockLbl.Name = "currentStockLbl";
            this.currentStockLbl.Size = new System.Drawing.Size(72, 13);
            this.currentStockLbl.TabIndex = 3;
            this.currentStockLbl.Text = "Current Stock";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(40, 60);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(133, 59);
            this.btnUpdateStock.TabIndex = 4;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // markAsSoldBtn
            // 
            this.markAsSoldBtn.Location = new System.Drawing.Point(40, 141);
            this.markAsSoldBtn.Name = "markAsSoldBtn";
            this.markAsSoldBtn.Size = new System.Drawing.Size(133, 59);
            this.markAsSoldBtn.TabIndex = 5;
            this.markAsSoldBtn.Text = "Mark As Sold";
            this.markAsSoldBtn.UseVisualStyleBackColor = true;
            this.markAsSoldBtn.Click += new System.EventHandler(this.markAsSoldBtn_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(628, 76);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(147, 20);
            this.txtStock.TabIndex = 6;
            this.txtStock.Text = "Enter Stock Amount";
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Location = new System.Drawing.Point(625, 60);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(154, 13);
            this.stockLbl.TabIndex = 7;
            this.stockLbl.Text = "Stock Amount for selected item";
            // 
            // frmSeeSaleItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.markAsSoldBtn);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.currentStockLbl);
            this.Controls.Add(this.listBoxSaleItems);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeeSaleItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmSeeSaleItems_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToTrackSales;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem backToMnu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxSaleItems;
        private System.Windows.Forms.Label currentStockLbl;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button markAsSoldBtn;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label stockLbl;
    }
}