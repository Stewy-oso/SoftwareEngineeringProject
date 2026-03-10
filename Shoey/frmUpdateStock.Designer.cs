namespace Shoey
{
    partial class frmUpdateStock
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
            this.lblAddStock = new System.Windows.Forms.Label();
            this.txtAddStock = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblChangePrice = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblChangeColour = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblChangeDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Location = new System.Drawing.Point(300, 34);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(57, 13);
            this.lblAddStock.TabIndex = 0;
            this.lblAddStock.Text = "Add Stock";
            // 
            // txtAddStock
            // 
            this.txtAddStock.Location = new System.Drawing.Point(408, 31);
            this.txtAddStock.Name = "txtAddStock";
            this.txtAddStock.Size = new System.Drawing.Size(100, 20);
            this.txtAddStock.TabIndex = 1;
            this.txtAddStock.TextChanged += new System.EventHandler(this.txtAddStock_TextChanged);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(303, 330);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(205, 54);
            this.btnUpdateStock.TabIndex = 2;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(408, 57);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // lblChangePrice
            // 
            this.lblChangePrice.AutoSize = true;
            this.lblChangePrice.Location = new System.Drawing.Point(300, 60);
            this.lblChangePrice.Name = "lblChangePrice";
            this.lblChangePrice.Size = new System.Drawing.Size(71, 13);
            this.lblChangePrice.TabIndex = 3;
            this.lblChangePrice.Text = "Change Price";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(408, 83);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(100, 20);
            this.txtColour.TabIndex = 6;
            // 
            // lblChangeColour
            // 
            this.lblChangeColour.AutoSize = true;
            this.lblChangeColour.Location = new System.Drawing.Point(300, 86);
            this.lblChangeColour.Name = "lblChangeColour";
            this.lblChangeColour.Size = new System.Drawing.Size(75, 13);
            this.lblChangeColour.TabIndex = 5;
            this.lblChangeColour.Text = "Update Colour";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(408, 109);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 8;
            // 
            // lblChangeDesc
            // 
            this.lblChangeDesc.AutoSize = true;
            this.lblChangeDesc.Location = new System.Drawing.Point(300, 112);
            this.lblChangeDesc.Name = "lblChangeDesc";
            this.lblChangeDesc.Size = new System.Drawing.Size(100, 13);
            this.lblChangeDesc.TabIndex = 7;
            this.lblChangeDesc.Text = "Change Description";
            // 
            // frmUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblChangeDesc);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.lblChangeColour);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblChangePrice);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.txtAddStock);
            this.Controls.Add(this.lblAddStock);
            this.Name = "frmUpdateStock";
            this.Text = "frmUpdateStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.TextBox txtAddStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblChangePrice;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblChangeColour;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblChangeDesc;
    }
}