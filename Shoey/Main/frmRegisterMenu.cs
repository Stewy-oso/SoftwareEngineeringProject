using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoey
{
    public partial class frmRegisterMenu : Form
    {
        public frmRegisterMenu()
        {
            InitializeComponent();
        }

        public static class Session {
            public static int CustomerID { get; set; }
        }

        private void exitRegisterMenuClick(object sender, EventArgs e)
        {
            DialogResult diagResult = MessageBox.Show("Confirm Exit", "Are you sure? \n\nConfirm exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (diagResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backRegisterMnuClick(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();

            this.Close();
        }

        private void passwordLabelSignIn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            //passwordHashing hash = new passwordHashing();

            

            //Validation
            if(string.IsNullOrEmpty(emailTxtBoxSignUp.Text) || string.IsNullOrEmpty(passwordTxtBoxSignUp.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please make sure all fields are filled out.");
                return;
            }

            if(!validator.IsValidEmail(emailTxtBoxSignUp.Text))
            {
                MessageBox.Show("Please enter a valid Email address.");
                return;
            }

            //
            string hashedPassword = passwordHashing.HashPassword(passwordTxtBoxSignUp.Text);

            try
            {
                Database db = new Database();

                db.CreateNewCust(
                    txtName.Text,
                    emailTxtBoxSignUp.Text,
                    hashedPassword
                    );

                MessageBox.Show("Successfully registered!");

                frmMainMenu menu = new frmMainMenu();
                menu.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
