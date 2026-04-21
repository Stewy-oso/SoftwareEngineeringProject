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
using static Shoey.frmSeeSaleItems;

namespace Shoey
{
    public partial class frmTrackSales : Form
    {
        public frmTrackSales()
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

        private void goToStock_Click(object sender, EventArgs e)
        {
            frmSeeSaleItems seeStock = new frmSeeSaleItems();
            seeStock.Show();

            this.Close();
        }

        private void frmTrackSales_Load(object sender, EventArgs e)
        {
            
            RefreshSalesList();
        }

        private void RefreshSalesList()
        {
            Database db = new Database();
            var soldItems = db.ListSales();
            listBoxSoldItems.DataSource = null;
            listBoxSoldItems.DataSource = soldItems;
        }

        private void goToAnalytics_Click(object sender, EventArgs e)
        {
            frmSeeYearlyRevenue yrlyRevenue = new frmSeeYearlyRevenue();
            yrlyRevenue.Show();

            this.Close();
        }
    }
}
