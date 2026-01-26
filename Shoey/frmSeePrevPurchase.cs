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
    public partial class frmSeePrevPurchase : Form
    {

        public static List<frmSeeCatalogue.Product> PreviousPurchases = new List<frmSeeCatalogue.Product>();

        public frmSeePrevPurchase()
        {
            InitializeComponent();
        }

        private void RefreshPurchaseList()
        {
            listBoxPrevPurch.DataSource = null;
            listBoxPrevPurch.DataSource = PreviousPurchases;
        }

        public static void AddPurchasedProducts(List<frmSeeCatalogue.Product> purchasedProducts)
        {
            PreviousPurchases.AddRange(purchasedProducts);
        }

        private void frmSeePrevPurchase_Load(object sender, EventArgs e)
        {
            RefreshPurchaseList();
        }

        private void goToCatalogue_Click(object sender, EventArgs e)
        {
            frmSeeCatalogue seeCatalogue = new frmSeeCatalogue();
            seeCatalogue.Show();

            this.Close();
        }

        private void goToBasket_Click(object sender, EventArgs e)
        {
            frmSeeBasket seeBasket = new frmSeeBasket();
            seeBasket.Show();

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
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Close();

        }
    }
}
