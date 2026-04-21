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

        private void frmSeeSaleItems_Load(object sender, EventArgs e)
        {
            loadStockItems();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        { 
            if(dgvBasket.SelectedRows.Count > 0) {
                int productID = Convert.ToInt32(dgvBasket.SelectedRows[0].Cells["PRODUCTID"].Value);

                frmUpdateStock frm = new frmUpdateStock(productID);
                frm.ShowDialog();

                loadStockItems();
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        private void loadStockItems()
        {
            Database db = new Database();
            DataTable dt = db.getSaleItems();

            dgvBasket.AutoGenerateColumns = true;
            dgvBasket.DataSource = dt;

            dgvBasket.Columns["NAME"].HeaderText = "Name";
            dgvBasket.Columns["QTY"].HeaderText = "Quantity";
            dgvBasket.Columns["PRICE"].HeaderText = "Price";
            
            //Hide columns
            dgvBasket.Columns["PRODUCTID"].Visible = false;
            dgvBasket.Columns["COLOUR"].Visible = false;
            dgvBasket.Columns["MANUFACTURER"].Visible = false;

            //Force sizing all columns & cells
            //dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvSaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnDeletStock_Click(object sender, EventArgs e)
        {
            if (dgvBasket.SelectedRows.Count > 0)
            {
                int productID = Convert.ToInt32(dgvBasket.SelectedRows[0].Cells["PRODUCTID"].Value);
                string productName = dgvBasket.SelectedRows[0].Cells["NAME"].Value.ToString();

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

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmAddStock frm = new frmAddStock();
            frm.ShowDialog();
            this.Close();

            loadStockItems();
        }
    }
}
