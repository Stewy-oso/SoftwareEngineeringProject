namespace Shoey
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlgBuyMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.bsktBuyMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.prevPrchseBuyMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.sellMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.trackSalesSellMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.listItmsSellMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.analyticsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.yrlyRevAnalyticsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.popAnalyticsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.bgMenu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyMenu,
            this.sellMenu,
            this.exitMenu,
            this.registerMenu,
            this.analyticsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buyMenu
            // 
            this.buyMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlgBuyMnu,
            this.bsktBuyMnu,
            this.prevPrchseBuyMnu});
            this.buyMenu.Name = "buyMenu";
            this.buyMenu.Size = new System.Drawing.Size(39, 20);
            this.buyMenu.Text = "Buy";
            this.buyMenu.Click += new System.EventHandler(this.buyMenuClick);
            // 
            // ctlgBuyMnu
            // 
            this.ctlgBuyMnu.Name = "ctlgBuyMnu";
            this.ctlgBuyMnu.Size = new System.Drawing.Size(175, 22);
            this.ctlgBuyMnu.Text = "Catalogue";
            this.ctlgBuyMnu.Click += new System.EventHandler(this.CtlgClick);
            // 
            // bsktBuyMnu
            // 
            this.bsktBuyMnu.Name = "bsktBuyMnu";
            this.bsktBuyMnu.Size = new System.Drawing.Size(175, 22);
            this.bsktBuyMnu.Text = "Basket";
            this.bsktBuyMnu.Click += new System.EventHandler(this.seeBasketClick);
            // 
            // prevPrchseBuyMnu
            // 
            this.prevPrchseBuyMnu.Name = "prevPrchseBuyMnu";
            this.prevPrchseBuyMnu.Size = new System.Drawing.Size(175, 22);
            this.prevPrchseBuyMnu.Text = "Previous Purchases";
            this.prevPrchseBuyMnu.Click += new System.EventHandler(this.seePrevPurchaseClick);
            // 
            // sellMenu
            // 
            this.sellMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackSalesSellMnu,
            this.listItmsSellMnu});
            this.sellMenu.Name = "sellMenu";
            this.sellMenu.Size = new System.Drawing.Size(37, 20);
            this.sellMenu.Text = "Sell";
            this.sellMenu.Click += new System.EventHandler(this.sellMenuClick);
            // 
            // trackSalesSellMnu
            // 
            this.trackSalesSellMnu.Name = "trackSalesSellMnu";
            this.trackSalesSellMnu.Size = new System.Drawing.Size(180, 22);
            this.trackSalesSellMnu.Text = "Track Sales";
            this.trackSalesSellMnu.Click += new System.EventHandler(this.trackSalesClick);
            // 
            // listItmsSellMnu
            // 
            this.listItmsSellMnu.Name = "listItmsSellMnu";
            this.listItmsSellMnu.Size = new System.Drawing.Size(180, 22);
            this.listItmsSellMnu.Text = "Stock";
            this.listItmsSellMnu.Click += new System.EventHandler(this.seeSaleItemsClick);
            // 
            // exitMenu
            // 
            this.exitMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitMenu.BackColor = System.Drawing.Color.Red;
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(37, 20);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMnu);
            // 
            // registerMenu
            // 
            this.registerMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.registerMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registerMenu.Name = "registerMenu";
            this.registerMenu.Size = new System.Drawing.Size(61, 20);
            this.registerMenu.Text = "Register";
            this.registerMenu.Click += new System.EventHandler(this.registerMenuClick);
            // 
            // analyticsMenu
            // 
            this.analyticsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yrlyRevAnalyticsMnu,
            this.popAnalyticsMnu});
            this.analyticsMenu.Name = "analyticsMenu";
            this.analyticsMenu.Size = new System.Drawing.Size(67, 20);
            this.analyticsMenu.Text = "Analytics";
            this.analyticsMenu.Click += new System.EventHandler(this.analyticsMenuClick);
            // 
            // yrlyRevAnalyticsMnu
            // 
            this.yrlyRevAnalyticsMnu.Name = "yrlyRevAnalyticsMnu";
            this.yrlyRevAnalyticsMnu.Size = new System.Drawing.Size(153, 22);
            this.yrlyRevAnalyticsMnu.Text = "Yearly Revenue";
            this.yrlyRevAnalyticsMnu.Click += new System.EventHandler(this.seeYrlyRevClick);
            // 
            // popAnalyticsMnu
            // 
            this.popAnalyticsMnu.Name = "popAnalyticsMnu";
            this.popAnalyticsMnu.Size = new System.Drawing.Size(153, 22);
            this.popAnalyticsMnu.Text = "Popularity";
            this.popAnalyticsMnu.Click += new System.EventHandler(this.seePopularityClick);
            // 
            // bgMenu
            // 
            this.bgMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgMenu.BackgroundImage")));
            this.bgMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.bgMenu.Location = new System.Drawing.Point(0, 27);
            this.bgMenu.Name = "bgMenu";
            this.bgMenu.Size = new System.Drawing.Size(800, 424);
            this.bgMenu.TabIndex = 1;
            this.bgMenu.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bgMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sellMenu;
        private System.Windows.Forms.ToolStripMenuItem buyMenu;
        private System.Windows.Forms.ToolStripMenuItem registerMenu;
        private System.Windows.Forms.ToolStripMenuItem analyticsMenu;
        private System.Windows.Forms.PictureBox bgMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem prevPrchseBuyMnu;
        private System.Windows.Forms.ToolStripMenuItem ctlgBuyMnu;
        private System.Windows.Forms.ToolStripMenuItem bsktBuyMnu;
        private System.Windows.Forms.ToolStripMenuItem trackSalesSellMnu;
        private System.Windows.Forms.ToolStripMenuItem listItmsSellMnu;
        private System.Windows.Forms.ToolStripMenuItem yrlyRevAnalyticsMnu;
        private System.Windows.Forms.ToolStripMenuItem popAnalyticsMnu;
    }
}

