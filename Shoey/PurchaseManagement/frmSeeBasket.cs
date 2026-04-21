using Shoey.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shoey.frmSeeCatalogue;

namespace Shoey
{
    public partial class frmSeeBasket : Form
    {
        public frmSeeBasket()
        {
            InitializeComponent();
        }

        

        private void exitBasketMnu_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backToPreviousFrm_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Close();
        }

        private void goToCatalogueFrm_Click(object sender, EventArgs e)
        {
            frmSeeCatalogue seeCatalogue = new frmSeeCatalogue();
            seeCatalogue.Show();

            this.Close();
        }

        private void goToPrevPrchsFrm_Click(object sender, EventArgs e)
        {
            frmSeePrevPurchase seePrevPurchases = new frmSeePrevPurchase();
            seePrevPurchases.Show();

            this.Close();
        }
            private void LoadBasket()
        {
            dgvBasket.AutoGenerateColumns = true;
            dgvBasket.DataSource = null;
            dgvBasket.DataSource = CartManager.Basket;

            UpdateTotal();
        }

        private void frmSeeBasket_Load(object sender, EventArgs e)
        {
            LoadBasket();
        }

        private void listBoxBasket_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotal()
        {
            decimal total = CartManager.Basket.Sum(x => x.Subtotal);
            lblTotalAmt.Text = total.ToString("0.00");
        }

        // A really broken checkout ahha
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string hashedPassword = passwordHashing.HashPassword(password);

            Database db = new Database();

            int customerID = db.CustIDFromDB(email, hashedPassword);

            if (customerID != -1)
            {
                int qty = CartManager.Basket.Sum(x => x.Quantity);
                decimal total = CartManager.Basket.Sum(x => x.Subtotal);
                int productID = CartManager.Basket.First().ProductID;

                db.CreateSale(productID, qty, customerID, total);
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvBasket.CurrentRow == null)
                return;

            int productId = Convert.ToInt32(dgvBasket.CurrentRow.Cells["ProductID"].Value);

            var item = CartManager.Basket.FirstOrDefault(x => x.ProductID == productId);

            if (item != null)
            {
                CartManager.Basket.Remove(item);
            }

            LoadBasket();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CartManager.Clear();
            LoadBasket();
        }
    }
}
