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
    public partial class frmSeeYearlyRevenue : Form
    {
        public frmSeeYearlyRevenue()
        {
            InitializeComponent();
        }

        private void exitYrlyRevClick(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Close();
        }

        private void btnCalculateRevenue_Click(object sender, EventArgs e)
        {
            if(int.TryParse(cmbYear.SelectedItem.ToString(), out int selectedYear))
            {

                Database db = new Database();
            
             lblYearlyRevenue.Text =
                "Total Revenue for" + selectedYear + ": €" + db.FindSaleTotal();
            }
            else
            {
                    MessageBox.Show("Please select a valid year.");
            }
            
        }

        private void frmSeeYearlyRevenue_Load(object sender, EventArgs e)
        {
            cmbYear.Items.Clear();
            cmbYear.Items.Add(DateTime.Now.Year);
            cmbYear.SelectedIndex = 0;
        }
    }
}
