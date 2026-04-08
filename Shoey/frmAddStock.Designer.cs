namespace Shoey
{
    partial class frmAddStock
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtManu = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblManu = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(334, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(334, 117);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "0.00";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(334, 91);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(151, 20);
            this.txtQty.TabIndex = 3;
            // 
            // txtManu
            // 
            this.txtManu.Location = new System.Drawing.Point(334, 65);
            this.txtManu.Name = "txtManu";
            this.txtManu.Size = new System.Drawing.Size(151, 20);
            this.txtManu.TabIndex = 4;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(334, 143);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(151, 20);
            this.txtColour.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(287, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(287, 120);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(278, 94);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Quantity";
            // 
            // lblManu
            // 
            this.lblManu.AutoSize = true;
            this.lblManu.Location = new System.Drawing.Point(260, 68);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(70, 13);
            this.lblManu.TabIndex = 9;
            this.lblManu.Text = "Manufacturer";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(287, 146);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 10;
            this.lblColour.Text = "Colour";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(334, 200);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(151, 36);
            this.btnAddStock.TabIndex = 12;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblManu);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtManu);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtName);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddStock";
            this.Text = "frmAddStock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtManu;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblManu;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAddStock;
    }
}