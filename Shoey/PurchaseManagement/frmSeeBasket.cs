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

            // Error proofing (save me)
            if(dgvBasket.Columns.Count > 0)
            {
                if (dgvBasket.Columns.Contains("ProductID"))
                {
                    dgvBasket.Columns["ProductID"].Visible = false;
                }

                if(dgvBasket.Columns.Contains("Price"))
                {
                    dgvBasket.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if(dgvBasket.Columns.Contains("Subtotal"))
                {
                    dgvBasket.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                

            }
            
            dgvBasket.DefaultCellStyle.NullValue = "N/A";

            dgvBasket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBasket.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


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
            lblTotalAmt.Text = total.ToString("€0.00");
        }

        // A really broken checkout ahha
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            validator.IsValidEmail(email);

            int Validp = validator.IsValidPassword(password);

            if(Validp != 0)
            {
                if (Validp == 1) MessageBox.Show("Password Cannot Be Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 2) MessageBox.Show("Need to have a lowercase character!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 3) MessageBox.Show("Need to have a uppercase character!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 4) MessageBox.Show("Need to have a digit!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 5) MessageBox.Show("Need to hacve a symbol! (i.e $,%,^, etc)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 6) MessageBox.Show("Password must be longer than 8 characters!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            string hashedPassword = passwordHashing.HashPassword(password);

            Database db = new Database();

            int customerID = db.Login(email, hashedPassword);

            if (customerID != -1)
            {

                if(CartManager.Basket.Count == 0)
                {
                    MessageBox.Show("Basket is empty!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                decimal total = CartManager.Basket.Sum(x => x.Subtotal);

                int saleID = db.CreateSale(customerID, total);

                foreach (var item in CartManager.Basket)
                {
                    db.CreateSales_Items(
                        saleID,
                        item.ProductID,
                        item.Quantity
                        );
                }

                CartManager.Clear();
                LoadBasket();

                MessageBox.Show("Purchase completed successfully! \nSale ID: " + saleID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User doesn't exist! \nCheck email?");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvBasket.CurrentRow == null)
                return;

            int productId = Convert.ToInt32(dgvBasket.CurrentRow.Cells["ProductID"].Value);

            CartManager.RemoveFromBasket(productId);

            LoadBasket();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CartManager.Clear();
            LoadBasket();
        }
    }
}
