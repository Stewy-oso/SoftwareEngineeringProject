using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoey
{
    public partial class frmSeeCatalogue : Form
    {

        List<Product> products = new List<Product>();

        public frmSeeCatalogue()
        {
            InitializeComponent();
        }

        private void goToBasket_Click(object sender, EventArgs e)
        {
            frmSeeBasket seeBasket = new frmSeeBasket();
            seeBasket.Show();

            this.Close();
        }

        private void goToPrevPurchases_Click(object sender, EventArgs e)
        {
            frmSeePrevPurchase seePrevPurchase = new frmSeePrevPurchase();
            seePrevPurchase.Show();

            this.Close();
        }

        private void exitSys_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backToMnu_Click(object sender, EventArgs e)
        {
            frmMainMenu backToMnu = new frmMainMenu();
            backToMnu.Show();

            this.Close();
        }

        public class Product
        {
            public String Name { get; set; }
            public decimal Price { get; set; }
            public int Stock {  get; set; }

            public override string ToString()
            {
                return Name + "||     €||" + Price + "||     Stock Available:    ||" + Stock;
            }
        }

        private void RefreshList()
        {
            listBoxProducts.DataSource = null;
            listBoxProducts.DataSource = products;
        }


        private void frmSeeCatalogue_Load(object sender, EventArgs e)
        {
            products.Add(new Product { Name = "Air Max", Price = 120, Stock = 15 });
            products.Add(new Product { Name = "Jordans", Price = 150, Stock = 8 });
            products.Add(new Product { Name = "NB 9060", Price = 90, Stock = 24 });
            products.Add(new Product { Name = "Airforce 1", Price = 110, Stock = 14 });
            products.Add(new Product { Name = "NB 950", Price = 60, Stock = 12 });
            products.Add(new Product { Name = "SKECHERS Walkers", Price = 75, Stock = 10 });
            products.Add(new Product { Name = "DC Hyde", Price = 55, Stock = 20 });
            products.Add(new Product { Name = "DC Gaveler (Black)", Price = 65, Stock = 19 });
            products.Add(new Product { Name = "DC Gaveler (Grey)", Price = 65, Stock = 9 });

            RefreshList();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var selectedProducts = listBoxProducts.SelectedItems.Cast<Product>().ToList();


            if (listBoxProducts.SelectedItem is Product selectedProduct)
            {
                DialogResult result = MessageBox.Show("Do you want to buy " + selectedProducts.Count + " items?",
                    "Confirm Purchase",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    frmSeeBasket seeBasket = new frmSeeBasket();
                    foreach (Product product in selectedProducts)
                    {
                        frmSeeBasket.Basket.Add(product);
                    }
                    seeBasket.Show();

                    this.Hide();
                }

                

            }
            else
            {
                MessageBox.Show("Please select a product first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
