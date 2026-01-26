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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMnu(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void sellMenuClick(object sender, EventArgs e)
        {
            
        }

        private void buyMenuClick(object sender, EventArgs e)
        {
            
        }

        private void analyticsMenuClick(object sender, EventArgs e)
        {
            
        }

        private void registerMenuClick(object sender, EventArgs e)
        {
            frmRegisterMenu register = new frmRegisterMenu();
            register.Show();

            this.Hide();
        }

        private void CtlgClick(object sender, EventArgs e)
        {
            frmSeeCatalogue seeCtlg = new frmSeeCatalogue();
            seeCtlg.Show();

            this.Hide();
        }

        private void seeBasketClick(object sender, EventArgs e)
        {
            frmSeeBasket seeBskt = new frmSeeBasket();
            seeBskt.Show();

            this.Hide();
        }

        private void seePrevPurchaseClick(object sender, EventArgs e)
        {
            frmSeePrevPurchase seePrevPurchase = new frmSeePrevPurchase();
            seePrevPurchase.Show();

            this.Hide();
        }

        private void trackSalesClick(object sender, EventArgs e)
        {
            frmTrackSales trackSales = new frmTrackSales();
            trackSales.Show();

            this.Hide();
        }

        private void seeSaleItemsClick(object sender, EventArgs e)
        {
            frmSeeSaleItems seeSaleItems = new frmSeeSaleItems();
            seeSaleItems.Show();

            this.Hide();
        }

        private void seeYrlyRevClick(object sender, EventArgs e)
        {
            frmSeeYearlyRevenue seeYrlyRev = new frmSeeYearlyRevenue();
            seeYrlyRev.Show();

            this.Hide();
        }

        private void seePopularityClick(object sender, EventArgs e)
        {
            frmSeePopularity seePop = new frmSeePopularity();
            seePop.Show();

            this.Hide();
        }
    }
}
