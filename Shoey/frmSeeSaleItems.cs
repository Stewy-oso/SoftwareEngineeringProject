using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Shoey
{
    public partial class frmSeeSaleItems : Form
    {

        Database db = new Database();

        public static List<SaleItem> SaleItems = new List<SaleItem>();
        public frmSeeSaleItems()
        {
            InitializeComponent();
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
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Close();
        }

        private void goToTrackSales_Click(object sender, EventArgs e)
        {
            frmTrackSales trackSales = new frmTrackSales();
            trackSales.Show();

            this.Close();
        }

        public class SaleItem
        {
            public String Name {  get; set; }
            public int Stock {  get; set; }
            public decimal Price { get; set; }
            public bool Sold { get; set; } = false;

            public override string ToString()
            {
                return "Name: " + Name + "Price: " + Price + "Stock: " + Stock + "Sold: " + Sold;
            }
        }

        private void frmSeeSaleItems_Load(object sender, EventArgs e)
        {
            loadStockItems();

            //DataTable dt = db.getSaleItems();

            //cbSaleItems.DataSource = dt;
            //cbSaleItems.DisplayMember = "NAME";
            //cbSaleItems.ValueMember = "PRODUCTID";
            /*
            foreach (var p in frmSeePrevPurchase.PreviousPurchases)
            {
                if (!SaleItems.Any(s => s.Name == p.Name))
                {
                    SaleItems.Add(new SaleItem
                    {
                        Name = p.Name,
                        Price = p.Price,
                        Stock = p.Stock
                    });
                }
            }
            */

            //RefreshSaleItemsList();
        }

        private void RefreshSaleItemsList()
        {
            /*
            listBoxSaleItems.DataSource = null;
            listBoxSaleItems.DataSource = SaleItems;
            */
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        { 
            if(dgvSaleItems.SelectedRows.Count > 0) {
                int productID = Convert.ToInt32(dgvSaleItems.SelectedRows[0].Cells["PRODUCTID"].Value);

                frmUpdateStock frm = new frmUpdateStock(productID);
                frm.ShowDialog();

                loadStockItems();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        private void markAsSoldBtn_Click(object sender, EventArgs e)
        { /*
            if (listBoxSaleItems.SelectedItem is SaleItem item)
            {
                if (item.Stock > 0)
                {
                    item.Stock -= 1;
                    item.Sold = true;
                    RefreshSaleItemsList();
                }
                else
                {
                    MessageBox.Show("Cannot sell, out of stock.");
                }
            }
            */
        }

        private void loadStockItems()
        {
            Database db = new Database();
            DataTable dt = db.getSaleItems();

            dgvSaleItems.AutoGenerateColumns = true;
            dgvSaleItems.DataSource = dt;

            dgvSaleItems.Columns["NAME"].HeaderText = "Name";
            dgvSaleItems.Columns["QTY"].HeaderText = "Quantity";
            dgvSaleItems.Columns["PRICE"].HeaderText = "Price";
            
            //Hide columns
            dgvSaleItems.Columns["PRODUCTID"].Visible = false;
            dgvSaleItems.Columns["COLOUR"].Visible = false;
            dgvSaleItems.Columns["MANUFACTURER"].Visible = false;

            //Force sizing all columns & cells
            //dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnDeletStock_Click(object sender, EventArgs e)
        {
            if (dgvSaleItems.SelectedRows.Count > 0)
            {
                int productID = Convert.ToInt32(dgvSaleItems.SelectedRows[0].Cells["PRODUCTID"].Value);
                string productName = dgvSaleItems.SelectedRows[0].Cells["NAME"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " + productName + " ?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
            
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Database db = new Database();
                        db.DeleteProduct(productID);

                        MessageBox.Show(productName + " deleted successfully!");

                        loadStockItems();
                    }
                    catch
                    {
                        MessageBox.Show("Error deleting " + productName + ". Please try again.");
                    }
                }
            }

            else
            {
                MessageBox.Show("Please select an item to delete first.");
            }
        }
    }
}
