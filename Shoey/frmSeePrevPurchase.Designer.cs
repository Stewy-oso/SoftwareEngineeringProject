namespace Shoey
{
    partial class frmSeePrevPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeePrevPurchase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.goToBasket = new System.Windows.Forms.ToolStripMenuItem();
            this.goToCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.prevPurchBG = new System.Windows.Forms.PictureBox();
            this.listBoxPrevPurch = new System.Windows.Forms.ListBox();
            this.prevPurchasesLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevPurchBG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitSys,
            this.backToMnu,
            this.goToBasket,
            this.goToCatalogue});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MnuStripPrevPurch";
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
            // goToBasket
            // 
            this.goToBasket.Name = "goToBasket";
            this.goToBasket.Size = new System.Drawing.Size(53, 20);
            this.goToBasket.Text = "Basket";
            this.goToBasket.Click += new System.EventHandler(this.goToBasket_Click);
            // 
            // goToCatalogue
            // 
            this.goToCatalogue.Name = "goToCatalogue";
            this.goToCatalogue.Size = new System.Drawing.Size(73, 20);
            this.goToCatalogue.Text = "Catalogue";
            this.goToCatalogue.Click += new System.EventHandler(this.goToCatalogue_Click);
            // 
            // prevPurchBG
            // 
            this.prevPurchBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevPurchBG.BackgroundImage")));
            this.prevPurchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevPurchBG.Location = new System.Drawing.Point(0, 27);
            this.prevPurchBG.Name = "prevPurchBG";
            this.prevPurchBG.Size = new System.Drawing.Size(800, 422);
            this.prevPurchBG.TabIndex = 1;
            this.prevPurchBG.TabStop = false;
            // 
            // listBoxPrevPurch
            // 
            this.listBoxPrevPurch.FormattingEnabled = true;
            this.listBoxPrevPurch.Location = new System.Drawing.Point(520, 89);
            this.listBoxPrevPurch.Name = "listBoxPrevPurch";
            this.listBoxPrevPurch.Size = new System.Drawing.Size(190, 199);
            this.listBoxPrevPurch.TabIndex = 2;
            // 
            // prevPurchasesLbl
            // 
            this.prevPurchasesLbl.AutoSize = true;
            this.prevPurchasesLbl.Location = new System.Drawing.Point(561, 73);
            this.prevPurchasesLbl.Name = "prevPurchasesLbl";
            this.prevPurchasesLbl.Size = new System.Drawing.Size(101, 13);
            this.prevPurchasesLbl.TabIndex = 3;
            this.prevPurchasesLbl.Text = "Previous Purchases";
            // 
            // frmSeePrevPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevPurchasesLbl);
            this.Controls.Add(this.listBoxPrevPurch);
            this.Controls.Add(this.prevPurchBG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeePrevPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previous Purchases";
            this.Load += new System.EventHandler(this.frmSeePrevPurchase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevPurchBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem backToMnu;
        private System.Windows.Forms.PictureBox prevPurchBG;
        private System.Windows.Forms.ToolStripMenuItem goToBasket;
        private System.Windows.Forms.ToolStripMenuItem goToCatalogue;
        private System.Windows.Forms.ListBox listBoxPrevPurch;
        private System.Windows.Forms.Label prevPurchasesLbl;
    }
}