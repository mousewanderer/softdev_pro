using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using whatACT9;

namespace whatACT9
{
    /*
     
      
     * There are 5 colors in KFC Logo - Animal Blood (#A3080B), Black (#000000), White (#FFFFFF), Old Lace 
     * (#FFF1E2) and Sandy Tan (#F5D4B7). The RGB and CMYK values of the colors are 
     * in the table below along with the closest RAL and PANTONE® numbers.
   
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;



        }

        private void Minimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized; // Minimize the calculator window
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                          "Exit Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Hardcoded username
            string correctUsername = "admin";

            // Get user input
            string enteredUsername = textBoxUsername.Text.Trim();
            string enteredPassword = textBoxPassword.Text;

            // Validate input
            if (enteredUsername == correctUsername && enteredPassword == Class1.Password)
            {
                MessageBox.Show("Login Successful!", "Success");

                // Open the Personal Information Profile Form
                PersonalInfoForm profileForm = new PersonalInfoForm();
                profileForm.Show();

                this.Hide(); // Hide the Login Form
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error");
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                          "Exit Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FORGOTpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prompt the user to enter a new password
            string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter a new password:",
                "Reset Password",
                ""
            );

            // Validate and save the new password
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                Class1.Password = newPassword;
                MessageBox.Show("Password has been reset.", "Success");
            }
            else
            {
                MessageBox.Show("Password reset cancelled or empty.", "Info");
            }
        }
    }
}
