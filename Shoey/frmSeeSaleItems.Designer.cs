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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToTrackSales = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentStockLbl = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.btnDeletStock = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
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
            this.goToTrackSales.Size = new System.Drawing.Size(75, 20);
            this.goToTrackSales.Text = "Track Sales";
            this.goToTrackSales.Click += new System.EventHandler(this.goToTrackSales_Click);
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
            // dgvSaleItems
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaleItems.Location = new System.Drawing.Point(212, 60);
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.Size = new System.Drawing.Size(399, 283);
            this.dgvSaleItems.TabIndex = 8;
            // 
            // btnDeletStock
            // 
            this.btnDeletStock.Location = new System.Drawing.Point(40, 278);
            this.btnDeletStock.Name = "btnDeletStock";
            this.btnDeletStock.Size = new System.Drawing.Size(133, 65);
            this.btnDeletStock.TabIndex = 9;
            this.btnDeletStock.Text = "Delete Stock";
            this.btnDeletStock.UseVisualStyleBackColor = true;
            this.btnDeletStock.Click += new System.EventHandler(this.btnDeletStock_Click);
            // 
            // frmSeeSaleItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletStock);
            this.Controls.Add(this.dgvSaleItems);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.currentStockLbl);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToTrackSales;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem backToMnu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label currentStockLbl;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.Button btnDeletStock;
    }
}