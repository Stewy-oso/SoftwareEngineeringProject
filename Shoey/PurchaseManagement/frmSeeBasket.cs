using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void RefreshBasketList()
        {
            listBoxBasket.DataSource = null;
            listBoxBasket.DataSource = Basket;
        }

        public void AddProductToBasket(Product p)
        {
            Basket.Add(p);
            RefreshBasketList();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

            var selectedProducts = listBoxBasket.SelectedItems.Cast<frmSeeCatalogue.Product>().ToList();

            if (Basket.Count == 0)
            {
                MessageBox.Show("Your basket is empty.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to purchase " + selectedProducts.Count + " items?",
                "Confirm Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                frmSeePrevPurchase.AddPurchasedProducts(selectedProducts);

                foreach (var product in selectedProducts)
                {
                    Basket.Remove(product);
                }
                
                RefreshBasketList();

                MessageBox.Show("Purchase completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxBasket_Click(object sender, EventArgs e)
        {

        }

        private void buyAllBtn_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxBasket.SelectedItems.Cast<frmSeeCatalogue.Product>().ToList();

            if (Basket.Count == 0)
            {
                MessageBox.Show("Your basket is empty.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to purchase all items?",
                "Confirm Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                frmSeePrevPurchase.AddPurchasedProducts(selectedProducts);

                foreach (var product in selectedProducts)
                {
                    Basket.Remove(product);
                }

                RefreshBasketList();

                MessageBox.Show("Purchase completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
