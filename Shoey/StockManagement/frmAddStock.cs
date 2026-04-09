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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }

        decimal price;
        int qty;

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtQty.Text, out qty))
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            if(!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Enter a valid Price.");
                return;
            }

            if(string.IsNullOrEmpty(txtColour.Text) || string.IsNullOrEmpty(txtManu.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Cannot leave empty fields");
                return;
            }

            // NOTE TO FIX LATER: Honestly code above could be a separate function to keep the button cleaner.

            try
            {
                Database db = new Database();

                db.AddNewStock(
                    txtName.Text,
                    qty,
                    price,
                    txtColour.Text,
                    txtManu.Text
                    );



                MessageBox.Show("Product Added Successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Product couldn't be added. Please try again. \n" + ex.Message);
            }
        }

        private void mnuBackBtn_Click(object sender, EventArgs e)
        {
            frmSeeSaleItems frm = new frmSeeSaleItems();
            frm.Show();

            this.Close();
        }

        private void mnuExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
