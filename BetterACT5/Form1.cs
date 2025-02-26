using System.Reflection.Emit;
using System.Windows.Forms;

namespace BetterACT5
{
    public partial class Experiment5 : Form

    {

        
        public Experiment5()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Namebutton_Click(object sender, EventArgs e)
        {
            // Get the user's name from the TextBox
            string name = NameBox.Text.Trim();
            // Display a greeting message in the Label
            if (string.IsNullOrEmpty(name))
            {
                NameResult.Text = "@:  Uhmm who are you??";
            }
            else
            {
                // Auto-wrap and manually break long names
                if (name.Length > 50)
                {
                    name = name.Insert(50, "\n");  // Force line break
                }


                NameResult.Text = $"@: Hello {name}, Welcome to Experiment #5";


            }
        }

        private void nametext_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void agebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agebutton_Click(object sender, EventArgs e)
        {

            // Get the user's name from the TextBox
            string name = NameBox.Text.Trim();

            string unknown = agebox.Text.Trim();



            // Display a greeting message in the Label
            if (string.IsNullOrEmpty(name))
            {
                NameResult.Text = "@: Hello, Random stranger, Please enter your name ";
                ageresult.Text = "?: ";
            }
            else
            {

                if (name.Length > 50)
                {
                    name = name.Insert(50, "\n");  // Force line break
                }

                if (int.TryParse(unknown, out int age))
                {

                    if (age >= 18)
                    {
                        if (age >= 200)
                        {
                            ageresult.Text = $"?: {name}, You are immortal!!!";
                        }
                        else
                        {
                            ageresult.Text = $"?: {name}, You are an adult!";

                        }
                    }
                    else if (age < 0)
                    {
                        ageresult.Text = $"?: {name}, You don't even an exist!";

                    }
                    else
                    {
                        ageresult.Text = $"?: {name}, You are still under age!";

                    }

                }


            }

        }

        private void Blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void greenbutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void redbutton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }
    }

}
