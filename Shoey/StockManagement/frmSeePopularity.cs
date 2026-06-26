using Shoey.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Shoey
{
    public partial class frmSeePopularity : Form
    {
        public frmSeePopularity()
        {
            InitializeComponent();
        }

        private void backToMainMnu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Close();
        }

        private void exitSys_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                sessionManager.LogOut();
                Application.Exit();
            }
        }

        private void btnSeePop_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSeePopularity_Load(object sender, EventArgs e)
        {
            chrtPopularity.Series.Clear();

            Series series = new Series("Most Popular Shoes");
            series.ChartType = SeriesChartType.Bar;

            chrtPopularity.ChartAreas[0].AxisX.Title = "Shoes";
            chrtPopularity.ChartAreas[0].AxisY.Title = "Quantity sold";

            Database db = new Database();

            DataTable dt = db.GetTopShoes();

            foreach(DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["NAME"].ToString(), Convert.ToInt32(row["TIMES_SOLD"]));
            }

            chrtPopularity.Series.Add(series);
        }

        // Code above was based off of:
        /* 
         Title:  Chart Class
         Author: Microsoft
         Date: UNKNOWN
         Website: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datavisualization.charting.chart?view=netframework-4.8.1
         Code: chrtPopularity.Series.Clear();

            Series series = new Series("Most Popular Shoes");
            series.ChartType = SeriesChartType.Bar;

            chrtPopularity.ChartAreas[0].AxisX.Title = "Shoes";
            chrtPopularity.ChartAreas[0].AxisY.Title = "Quantity sold";

        series.Points.AddXY(row["NAME"].ToString(), Convert.ToInt32(row["TIMES_SOLD"]));

        chrtPopularity.Series.Add(series);
         */
    }
}
