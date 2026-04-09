namespace Shoey
{
    partial class frmRegisterMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitRegisterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.backRegisterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMenuBG = new System.Windows.Forms.PictureBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.emailTxtBoxSignIn = new System.Windows.Forms.TextBox();
            this.emailLabelSignIn = new System.Windows.Forms.Label();
            this.passwordTxtBoxSignIn = new System.Windows.Forms.TextBox();
            this.passwordLabelSignIn = new System.Windows.Forms.Label();
            this.passwordLabelSignUp = new System.Windows.Forms.Label();
            this.passwordTxtBoxSignUp = new System.Windows.Forms.TextBox();
            this.emailLabelSignUp = new System.Windows.Forms.Label();
            this.emailTxtBoxSignUp = new System.Windows.Forms.TextBox();
            this.dobLabelSignUp = new System.Windows.Forms.Label();
            this.dobPickerSignUp = new System.Windows.Forms.DateTimePicker();
            this.lblSignupName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerMenuBG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitRegisterMenu,
            this.backRegisterMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitRegisterMenu
            // 
            this.exitRegisterMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitRegisterMenu.BackColor = System.Drawing.Color.Red;
            this.exitRegisterMenu.Name = "exitRegisterMenu";
            this.exitRegisterMenu.Size = new System.Drawing.Size(38, 20);
            this.exitRegisterMenu.Text = "Exit";
            this.exitRegisterMenu.Click += new System.EventHandler(this.exitRegisterMenuClick);
            // 
            // backRegisterMenu
            // 
            this.backRegisterMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backRegisterMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backRegisterMenu.Name = "backRegisterMenu";
            this.backRegisterMenu.Size = new System.Drawing.Size(44, 20);
            this.backRegisterMenu.Text = "Back";
            this.backRegisterMenu.Click += new System.EventHandler(this.backRegisterMnuClick);
            // 
            // registerMenuBG
            // 
            this.registerMenuBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerMenuBG.BackgroundImage")));
            this.registerMenuBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerMenuBG.Location = new System.Drawing.Point(0, 27);
            this.registerMenuBG.Name = "registerMenuBG";
            this.registerMenuBG.Size = new System.Drawing.Size(800, 425);
            this.registerMenuBG.TabIndex = 1;
            this.registerMenuBG.TabStop = false;
            // 
            // signInBtn
            // 
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.Location = new System.Drawing.Point(135, 186);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(85, 37);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            // 
            // signUpBtn
            // 
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Location = new System.Drawing.Point(553, 212);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(85, 37);
            this.signUpBtn.TabIndex = 3;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // emailTxtBoxSignIn
            // 
            this.emailTxtBoxSignIn.Location = new System.Drawing.Point(109, 134);
            this.emailTxtBoxSignIn.Name = "emailTxtBoxSignIn";
            this.emailTxtBoxSignIn.Size = new System.Drawing.Size(159, 20);
            this.emailTxtBoxSignIn.TabIndex = 4;
            this.emailTxtBoxSignIn.Text = "Enter Email";
            // 
            // emailLabelSignIn
            // 
            this.emailLabelSignIn.AutoSize = true;
            this.emailLabelSignIn.Location = new System.Drawing.Point(60, 137);
            this.emailLabelSignIn.Name = "emailLabelSignIn";
            this.emailLabelSignIn.Size = new System.Drawing.Size(32, 13);
            this.emailLabelSignIn.TabIndex = 5;
            this.emailLabelSignIn.Text = "Email";
            // 
            // passwordTxtBoxSignIn
            // 
            this.passwordTxtBoxSignIn.Location = new System.Drawing.Point(109, 160);
            this.passwordTxtBoxSignIn.MaxLength = 12;
            this.passwordTxtBoxSignIn.Name = "passwordTxtBoxSignIn";
            this.passwordTxtBoxSignIn.PasswordChar = '*';
            this.passwordTxtBoxSignIn.Size = new System.Drawing.Size(159, 20);
            this.passwordTxtBoxSignIn.TabIndex = 6;
            // 
            // passwordLabelSignIn
            // 
            this.passwordLabelSignIn.AutoSize = true;
            this.passwordLabelSignIn.Location = new System.Drawing.Point(50, 163);
            this.passwordLabelSignIn.Name = "passwordLabelSignIn";
            this.passwordLabelSignIn.Size = new System.Drawing.Size(53, 13);
            this.passwordLabelSignIn.TabIndex = 7;
            this.passwordLabelSignIn.Text = "Password";
            this.passwordLabelSignIn.Click += new System.EventHandler(this.passwordLabelSignIn_Click);
            // 
            // passwordLabelSignUp
            // 
            this.passwordLabelSignUp.AutoSize = true;
            this.passwordLabelSignUp.Location = new System.Drawing.Point(481, 163);
            this.passwordLabelSignUp.Name = "passwordLabelSignUp";
            this.passwordLabelSignUp.Size = new System.Drawing.Size(53, 13);
            this.passwordLabelSignUp.TabIndex = 11;
            this.passwordLabelSignUp.Text = "Password";
            // 
            // passwordTxtBoxSignUp
            // 
            this.passwordTxtBoxSignUp.Location = new System.Drawing.Point(540, 160);
            this.passwordTxtBoxSignUp.MaxLength = 12;
            this.passwordTxtBoxSignUp.Name = "passwordTxtBoxSignUp";
            this.passwordTxtBoxSignUp.PasswordChar = '*';
            this.passwordTxtBoxSignUp.Size = new System.Drawing.Size(148, 20);
            this.passwordTxtBoxSignUp.TabIndex = 10;
            // 
            // emailLabelSignUp
            // 
            this.emailLabelSignUp.AutoSize = true;
            this.emailLabelSignUp.Location = new System.Drawing.Point(502, 137);
            this.emailLabelSignUp.Name = "emailLabelSignUp";
            this.emailLabelSignUp.Size = new System.Drawing.Size(32, 13);
            this.emailLabelSignUp.TabIndex = 9;
            this.emailLabelSignUp.Text = "Email";
            // 
            // emailTxtBoxSignUp
            // 
            this.emailTxtBoxSignUp.Location = new System.Drawing.Point(540, 134);
            this.emailTxtBoxSignUp.Name = "emailTxtBoxSignUp";
            this.emailTxtBoxSignUp.Size = new System.Drawing.Size(148, 20);
            this.emailTxtBoxSignUp.TabIndex = 8;
            this.emailTxtBoxSignUp.Text = "Enter Email";
            // 
            // dobLabelSignUp
            // 
            this.dobLabelSignUp.AutoSize = true;
            this.dobLabelSignUp.Location = new System.Drawing.Point(468, 189);
            this.dobLabelSignUp.Name = "dobLabelSignUp";
            this.dobLabelSignUp.Size = new System.Drawing.Size(66, 13);
            this.dobLabelSignUp.TabIndex = 13;
            this.dobLabelSignUp.Text = "Date of Birth";
            this.dobLabelSignUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // dobPickerSignUp
            // 
            this.dobPickerSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dobPickerSignUp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dobPickerSignUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPickerSignUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dobPickerSignUp.Location = new System.Drawing.Point(540, 186);
            this.dobPickerSignUp.Name = "dobPickerSignUp";
            this.dobPickerSignUp.Size = new System.Drawing.Size(148, 20);
            this.dobPickerSignUp.TabIndex = 14;
            this.dobPickerSignUp.Value = new System.DateTime(2025, 12, 3, 16, 1, 59, 0);
            // 
            // lblSignupName
            // 
            this.lblSignupName.AutoSize = true;
            this.lblSignupName.Location = new System.Drawing.Point(502, 111);
            this.lblSignupName.Name = "lblSignupName";
            this.lblSignupName.Size = new System.Drawing.Size(35, 13);
            this.lblSignupName.TabIndex = 16;
            this.lblSignupName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(540, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "Enter Name";
            // 
            // frmRegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSignupName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dobPickerSignUp);
            this.Controls.Add(this.dobLabelSignUp);
            this.Controls.Add(this.passwordLabelSignUp);
            this.Controls.Add(this.passwordTxtBoxSignUp);
            this.Controls.Add(this.emailLabelSignUp);
            this.Controls.Add(this.emailTxtBoxSignUp);
            this.Controls.Add(this.passwordLabelSignIn);
            this.Controls.Add(this.passwordTxtBoxSignIn);
            this.Controls.Add(this.emailLabelSignIn);
            this.Controls.Add(this.emailTxtBoxSignIn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.registerMenuBG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegisterMenu";
            this.Text = "Register";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerMenuBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitRegisterMenu;
        private System.Windows.Forms.ToolStripMenuItem backRegisterMenu;
        private System.Windows.Forms.PictureBox registerMenuBG;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox emailTxtBoxSignIn;
        private System.Windows.Forms.Label emailLabelSignIn;
        private System.Windows.Forms.TextBox passwordTxtBoxSignIn;
        private System.Windows.Forms.Label passwordLabelSignIn;
        private System.Windows.Forms.Label passwordLabelSignUp;
        private System.Windows.Forms.TextBox passwordTxtBoxSignUp;
        private System.Windows.Forms.Label emailLabelSignUp;
        private System.Windows.Forms.TextBox emailTxtBoxSignUp;
        private System.Windows.Forms.Label dobLabelSignUp;
        private System.Windows.Forms.DateTimePicker dobPickerSignUp;
        private System.Windows.Forms.Label lblSignupName;
        private System.Windows.Forms.TextBox txtName;
    }
}