namespace Shoey
{
    partial class frmSeeCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeeCatalogue));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.goToBasket = new System.Windows.Forms.ToolStripMenuItem();
            this.goToPrevPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueBG = new System.Windows.Forms.PictureBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.ListBoxLbl = new System.Windows.Forms.Label();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitSys,
            this.backToMnu,
            this.goToBasket,
            this.goToPrevPurchases});
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
            // goToPrevPurchases
            // 
            this.goToPrevPurchases.Name = "goToPrevPurchases";
            this.goToPrevPurchases.Size = new System.Drawing.Size(120, 20);
            this.goToPrevPurchases.Text = "Previous Purchases";
            this.goToPrevPurchases.Click += new System.EventHandler(this.goToPrevPurchases_Click);
            // 
            // catalogueBG
            // 
            this.catalogueBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("catalogueBG.BackgroundImage")));
            this.catalogueBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catalogueBG.Location = new System.Drawing.Point(0, 27);
            this.catalogueBG.Name = "catalogueBG";
            this.catalogueBG.Size = new System.Drawing.Size(800, 425);
            this.catalogueBG.TabIndex = 1;
            this.catalogueBG.TabStop = false;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(422, 84);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxProducts.Size = new System.Drawing.Size(366, 134);
            this.listBoxProducts.TabIndex = 2;
            // 
            // ListBoxLbl
            // 
            this.ListBoxLbl.AutoSize = true;
            this.ListBoxLbl.Location = new System.Drawing.Point(471, 68);
            this.ListBoxLbl.Name = "ListBoxLbl";
            this.ListBoxLbl.Size = new System.Drawing.Size(253, 13);
            this.ListBoxLbl.TabIndex = 3;
            this.ListBoxLbl.Text = "Shoes available to purchase according to Suppliers*";
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(505, 224);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(185, 59);
            this.btnAddToBasket.TabIndex = 4;
            this.btnAddToBasket.Text = "Add to Basket";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmSeeCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.ListBoxLbl);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.catalogueBG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSeeCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.frmSeeCatalogue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMnu;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem goToBasket;
        private System.Windows.Forms.ToolStripMenuItem goToPrevPurchases;
        private System.Windows.Forms.PictureBox catalogueBG;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label ListBoxLbl;
        private System.Windows.Forms.Button btnAddToBasket;
    }
}