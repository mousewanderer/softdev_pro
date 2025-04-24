using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace EXP11
{
    public partial class Form1 : Form
    {


        bool allowed = true;


        public Form1()
        {
            InitializeComponent();
        }



        string connectionString = "Server=(INSERT SMSS) DATABASE";



        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStudents.DataSource = dt;
            }




        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // this one
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
            // Add categories to the ComboBox
            CourseBox.Items.Add("Computer Engineering");
            CourseBox.Items.Add("AI Development");
            CourseBox.Items.Add("Civil Engineering");
            CourseBox.Items.Add("Electrical Engineering");
            CourseBox.Items.Add("Computer Science");
            CourseBox.Items.Add("Information Technology");
            CourseBox.Items.Add("Ethical hacking");
            CourseBox.Items.Add("Block chain technology");
            CourseBox.Items.Add("Mechanical Engineering");
            CourseBox.Items.Add("Criminology");
            CourseBox.Items.Add("Software Engineering");
            CourseBox.Items.Add("Tourism Management");

        }

        private bool IsValidAge(int age)
        {
            if (age >= 150)
            {
                MessageBox.Show("Too old");
                txtAge.Text = "";
                return false;
            }
            else if (age <= 0)
            {
                MessageBox.Show("Non existent");
                txtAge.Text = "";
                return false;
            }
            else if (age <= 18)
            {
                MessageBox.Show("Too young");
                return false;
            }
            else if (age >= 60)
            {
                MessageBox.Show("Are you sure???");
            }

            return true;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || !int.TryParse(txtStudentID.Text, out int studentId))
            {
                MessageBox.Show("Valid Student ID is required.");
                return;
            }

            bool updateAge = int.TryParse(txtAge.Text, out int age);
            bool updateCourse = CourseBox.SelectedIndex != -1;

            // Validate age
            if (updateAge && !IsValidAge(age)) return;

            if (!updateAge && !updateCourse)
            {
                MessageBox.Show("Please input either Age or Course to update.");
                return;
            }

            // Only proceed if allowed (for age)
            if (!updateAge || (updateAge && allowed))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    List<string> updateFields = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    if (updateAge)
                    {
                        updateFields.Add("Age = @Age");
                        cmd.Parameters.AddWithValue("@Age", age);
                    }

                    if (updateCourse)
                    {
                        updateFields.Add("Course = @Course");
                        cmd.Parameters.AddWithValue("@Course", CourseBox.SelectedItem.ToString().Trim());
                    }

                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    string updateClause = string.Join(", ", updateFields);
                    cmd.CommandText = $"UPDATE Students SET {updateClause} WHERE StudentID = @StudentID";

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                            LoadStudents();

                            // Clear inputs
                            txtStudentID.Text = "";
                            txtAge.Text = "";
                            CourseBox.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Student ID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }








        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate StudentID
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || !int.TryParse(txtStudentID.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return; // Cancel deletion
            }

            // Proceed with deletion
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully.");
                        LoadStudents(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Student ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age))
            {
                txtAge.Text = "";
                return;
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text, out int age))
            {
                txtStudentID.Text = "";
                return;
            }
        }
    }
}