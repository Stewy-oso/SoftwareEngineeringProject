using Oracle.ManagedDataAccess.Client;
using Shoey.Logic;
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
using System.Xml.Linq;
using static Shoey.frmSeeSaleItems;

namespace Shoey
{
    public partial class frmSeeCatalogue : Form
    {

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

        private void frmSeeCatalogue_Load(object sender, EventArgs e)
        {
            loadStockItems();
        }

        private void loadStockItems()
        {
            Database db = new Database();
            DataTable dt = db.getSaleItems();

            dgvCatalogue.AutoGenerateColumns = true;
            dgvCatalogue.DataSource = dt;

            dgvCatalogue.Columns["NAME"].HeaderText = "Name";
            dgvCatalogue.Columns["QTY"].HeaderText = "Quantity";
            dgvCatalogue.Columns["PRICE"].HeaderText = "Price";

            //Hide columns
            dgvCatalogue.Columns["PRODUCTID"].Visible = false;
            dgvCatalogue.Columns["COLOUR"].Visible = false;
            dgvCatalogue.Columns["MANUFACTURER"].Visible = false;

            //Force sizing all columns & cells
            //dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvCatalogue.CurrentRow == null)
                return;

            int productId = Convert.ToInt32(dgvCatalogue.CurrentRow.Cells["PRODUCTID"].Value);
            string name = dgvCatalogue.CurrentRow.Cells["NAME"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvCatalogue.CurrentRow.Cells["PRICE"].Value);

            CartManager.AddItem(new CartItem
            {
                ProductID = productId,
                Name = name,
                Quantity = 1,
                Price = price
            });

            MessageBox.Show("Item added to Basket!");
        }
    }
}
