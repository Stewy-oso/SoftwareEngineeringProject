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
            this.basketLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.exitBasketMnu.Size = new System.Drawing.Size(38, 20);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(320, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 166);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(460, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Location = new System.Drawing.Point(500, 241);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(34, 13);
            this.lblTotalAmt.TabIndex = 6;
            this.lblTotalAmt.Text = "€0.00";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(428, 257);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(126, 60);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(45, 101);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password:";
            // 
            // frmSeeBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.basketLbl);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label basketLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
    }
}