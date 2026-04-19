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
        public static List<frmSeeCatalogue.Product> Basket = new List<frmSeeCatalogue.Product>();

        

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

        private void frmSeeBasket_Load(object sender, EventArgs e)
        {

        }

        private void listBoxBasket_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string hashedPassword = passwordHashing.HashPassword(password);

            Database db = new Database();

            int customerID = db.CustIDFromDB(email, hashedPassword);

            if (customerID != -1)
            {
                db.CreateSale(qty, customerID, total);
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
    }
}
