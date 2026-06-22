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


            // FINSIH THIS i.e add error codes
            if(validator.IsValidEmail(emailTxtBoxSignUp.Text) != 0)
            {
                if(validator.IsValidEmail(emailTxtBoxSignUp.Text) == 1)
                {
                    MessageBox.Show("Cannot have Email empty");
                    return;
                }
                if (validator.IsValidEmail(emailTxtBoxSignUp.Text) == 2)
                {
                    MessageBox.Show("Email is invalid length");
                    return;
                }
                if (validator.IsValidEmail(emailTxtBoxSignUp.Text) == 3)
                {
                    MessageBox.Show("Invalid email domain");
                    return;
                }
                if (validator.IsValidEmail(emailTxtBoxSignUp.Text) == 4)
                {
                    MessageBox.Show("No @ sign");
                    return;
                }
                

            }

            if(validator.IsValidPassword(passwordTxtBoxSignUp.Text) != 0)
            {
                MessageBox.Show("Please enter a valid Password.");
                return;
            }

            //
            string hashedPassword = passwordHashing.HashPassword(passwordTxtBoxSignUp.Text);

            try
            {
                Database db = new Database();

                db.CreateNewCust(
                    txtName.Text,
                    txtSurname.Text,
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

        private void signInBtn_Click(object sender, EventArgs e)
        {

            string password = passwordTxtBoxSignIn.Text;
            string email = emailTxtBoxSignIn.Text;

            int validE = validator.IsValidEmail(email);
            if (validE != 0)
            {
                if (validE == 1) MessageBox.Show("Email Cannot Be Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (validE == 2) MessageBox.Show("Email has invalid length!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (validE == 3) MessageBox.Show("Email has an Invalid domain! \nValid domains are: @gmail.com," +
                    "\n@outlook.com,\n@yahoo.com,\n@ittralee.ie,\n@mymtu.ie,\n@mtu.ie", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (validE == 4) MessageBox.Show("Email is missing an @ sign!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int Validp = validator.IsValidPassword(password);
            if (Validp != 0)
            {
                if (Validp == 1) MessageBox.Show("Password Cannot Be Empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 2) MessageBox.Show("Need to have a lowercase character!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 3) MessageBox.Show("Need to have a uppercase character!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 4) MessageBox.Show("Need to have a digit!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 5) MessageBox.Show("Need to hacve a symbol! (i.e $,%,^, etc)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Validp == 6) MessageBox.Show("Password must be longer than 8 characters!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            
            string hash = passwordHashing.HashPassword(password);

            Database db = new Database();

            int custID = db.Login(email, hash);
            if(custID != -1)
            {
                MessageBox.Show("Successfully Logged In! Welcome " + db.GetCustomerName(custID), "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Cannot Login. Check password?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
