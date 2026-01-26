namespace Shoey
{
    partial class frmSeeBasket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeeBasket));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitBasketMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.backToPreviousFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.goToCatalogueFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.goToPrevPrchsFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.basketBG = new System.Windows.Forms.PictureBox();
            this.listBoxBasket = new System.Windows.Forms.ListBox();
            this.basketLbl = new System.Windows.Forms.Label();
            this.checkoutBasketBtn = new System.Windows.Forms.Button();
            this.buyAllBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketBG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitBasketMnu,
            this.backToPreviousFrm,
            this.goToCatalogueFrm,
            this.goToPrevPrchsFrm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitBasketMnu
            // 
            this.exitBasketMnu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitBasketMnu.BackColor = System.Drawing.Color.Red;
            this.exitBasketMnu.Name = "exitBasketMnu";
            this.exitBasketMnu.Size = new System.Drawing.Size(37, 20);
            this.exitBasketMnu.Text = "Exit";
            this.exitBasketMnu.Click += new System.EventHandler(this.exitBasketMnu_Click);
            // 
            // backToPreviousFrm
            // 
            this.backToPreviousFrm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToPreviousFrm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backToPreviousFrm.Name = "backToPreviousFrm";
            this.backToPreviousFrm.Size = new System.Drawing.Size(44, 20);
            this.backToPreviousFrm.Text = "Back";
            this.backToPreviousFrm.Click += new System.EventHandler(this.backToPreviousFrm_Click);
            // 
            // goToCatalogueFrm
            // 
            this.goToCatalogueFrm.Name = "goToCatalogueFrm";
            this.goToCatalogueFrm.Size = new System.Drawing.Size(73, 20);
            this.goToCatalogueFrm.Text = "Catalogue";
            this.goToCatalogueFrm.Click += new System.EventHandler(this.goToCatalogueFrm_Click);
            // 
            // goToPrevPrchsFrm
            // 
            this.goToPrevPrchsFrm.Name = "goToPrevPrchsFrm";
            this.goToPrevPrchsFrm.Size = new System.Drawing.Size(120, 20);
            this.goToPrevPrchsFrm.Text = "Previous Purchases";
            this.goToPrevPrchsFrm.Click += new System.EventHandler(this.goToPrevPrchsFrm_Click);
            // 
            // basketBG
            // 
            this.basketBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basketBG.BackgroundImage")));
            this.basketBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basketBG.Location = new System.Drawing.Point(0, 27);
            this.basketBG.Name = "basketBG";
            this.basketBG.Size = new System.Drawing.Size(800, 433);
            this.basketBG.TabIndex = 1;
            this.basketBG.TabStop = false;
            // 
            // listBoxBasket
            // 
            this.listBoxBasket.FormattingEnabled = true;
            this.listBoxBasket.Location = new System.Drawing.Point(276, 72);
            this.listBoxBasket.Name = "listBoxBasket";
            this.listBoxBasket.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxBasket.Size = new System.Drawing.Size(252, 212);
            this.listBoxBasket.TabIndex = 2;
            this.listBoxBasket.Click += new System.EventHandler(this.listBoxBasket_Click);
            // 
            // basketLbl
            // 
            this.basketLbl.AutoSize = true;
            this.basketLbl.Location = new System.Drawing.Point(378, 56);
            this.basketLbl.Name = "basketLbl";
            this.basketLbl.Size = new System.Drawing.Size(40, 13);
            this.basketLbl.TabIndex = 3;
            this.basketLbl.Text = "Basket";
            this.basketLbl.Click += new System.EventHandler(this.listBoxBasket_Click);
            // 
            // checkoutBasketBtn
            // 
            this.checkoutBasketBtn.Location = new System.Drawing.Point(276, 290);
            this.checkoutBasketBtn.Name = "checkoutBasketBtn";
            this.checkoutBasketBtn.Size = new System.Drawing.Size(119, 49);
            this.checkoutBasketBtn.TabIndex = 4;
            this.checkoutBasketBtn.Text = "Checkout";
            this.checkoutBasketBtn.UseVisualStyleBackColor = true;
            this.checkoutBasketBtn.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // buyAllBtn
            // 
            this.buyAllBtn.Location = new System.Drawing.Point(416, 290);
            this.buyAllBtn.Name = "buyAllBtn";
            this.buyAllBtn.Size = new System.Drawing.Size(112, 49);
            this.buyAllBtn.TabIndex = 5;
            this.buyAllBtn.Text = "Checkout All";
            this.buyAllBtn.UseVisualStyleBackColor = true;
            this.buyAllBtn.Click += new System.EventHandler(this.buyAllBtn_Click);
            // 
            // frmSeeBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buyAllBtn);
            this.Controls.Add(this.checkoutBasketBtn);
            this.Controls.Add(this.basketLbl);
            this.Controls.Add(this.listBoxBasket);
            this.Controls.Add(this.basketBG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeeBasket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.frmSeeBasket_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitBasketMnu;
        private System.Windows.Forms.ToolStripMenuItem backToPreviousFrm;
        private System.Windows.Forms.PictureBox basketBG;
        private System.Windows.Forms.ToolStripMenuItem goToCatalogueFrm;
        private System.Windows.Forms.ToolStripMenuItem goToPrevPrchsFrm;
        private System.Windows.Forms.ListBox listBoxBasket;
        private System.Windows.Forms.Label basketLbl;
        private System.Windows.Forms.Button checkoutBasketBtn;
        private System.Windows.Forms.Button buyAllBtn;
    }
}