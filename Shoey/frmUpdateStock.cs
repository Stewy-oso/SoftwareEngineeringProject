using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoey
{
    public partial class frmUpdateStock : Form
    {
        private int productID;

        public frmUpdateStock(int productID)
        {
            InitializeComponent();
            this.productID = productID;
        }
        private void txtAddStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            // I want to add that a user will input a producID, then 
            // a table will show all info about that product, where
            // the user can alter the product info there
            int addStock;

            if(!int.TryParse(txtAddStock.Text, out addStock))
            {
                MessageBox.Show("Enter a valid number.");
                return;
            }

            else
            {

                Database db = new Database();
                

                db.UpdateStockItems(
                        productID,
                        decimal.Parse(txtPrice.Text),
                        addStock,
                        //txtDesc.Text,
                        txtColour.Text
                    );

                MessageBox.Show("Stock Updated");

                this.Close();
            }

            
        }

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {
            /* Temp data */
            //int productID = 1;

            Database db = new Database();
            DataTable dt = db.FindSelectedInfo(productID);

            if(dt.Rows.Count > 0)
            {
                txtPrice.Text = dt.Rows[0]["PRICE"].ToString();
                txtAddStock.Text = dt.Rows[0]["QTY"].ToString();
                //txtDesc.Text = dt.Rows[0]["DESC"].ToString();
                txtColour.Text = dt.Rows[0]["COLOUR"].ToString();
            }
        }
    }
}
