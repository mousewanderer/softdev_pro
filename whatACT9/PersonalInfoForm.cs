using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using whatACT9;

namespace whatACT9
{
    public partial class PersonalInfoForm : Form


    {


        public PersonalInfoForm()
        {
            InitializeComponent();
        }





        private void PersonalInfoForm_Load(object sender, EventArgs e)

        {
            // Add categories to the ComboBox
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.Items.Add("Furry");
            comboBoxGender.Items.Add("Others Mental Illness");


            // Load profile if file exists
            if (File.Exists(filePath))
            {
                string[] data = File.ReadAllText(filePath).Split('|');
                if (data.Length == 3)
                {
                    textBoxFullName.Text = data[0];
                    textBoxAge.Text = data[1];
                    comboBoxGender.SelectedItem = data[2];
                }
                else
                {
                    MessageBox.Show("Invalid profile data. Please correct the file.", "Error");
                }
            }
        }




        private readonly string filePath = "user_profile.txt"; // This should be declared once at the class level






        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Retrieve input data
            string fullName = textBoxFullName.Text.Trim();
            string ageInput = textBoxAge.Text.Trim();
            string gender = comboBoxGender.SelectedItem?.ToString();

            // Validate Full Name
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter your full name.", "Input Error");
                return;
            }

            // Validate Age (Numeric only)
            if (string.IsNullOrEmpty(ageInput))
            {
                MessageBox.Show("Please enter your age.", "Input Error");
                return;
            }

            if (!int.TryParse(ageInput, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.", "Input Error");
                return;
            }

            // Validate Gender selection
            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Input Error");
                return;
            }


            // Age logic as requested - show age-related warning messages using MessageBox
            if (age >= 18)
            {
                if (age >= 60)
                {
                    MessageBox.Show($"{fullName}, You eligible for senior citizen discount! (-20%)", "Age Status");
                }
                else
                {

                }
            }
            else if (age < 0)
            {
                MessageBox.Show($"{fullName}, You don't exist so you are cannot order!", "Age Status");
            }
            else
            {
                MessageBox.Show($"{fullName}, You are eligible for Kid's Discount! (-20%)", "Age Status");
            }




            // Save to file (using the class-level filePath)
            File.WriteAllText(filePath, $"{fullName}|{age}|{gender}");

            // Show confirmation message
            MessageBox.Show(
                $"Profile Saved!\n\nFull Name: {fullName}\nAge: {age}\nGender: {gender}",
                "Profile Information"
            );
        }



        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Redirect to Login Form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close(); // Close the Profile Form
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void ffs_Click(object sender, EventArgs e)
        {

        }
    }
}
