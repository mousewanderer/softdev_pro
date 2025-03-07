using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreaterACT6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        double result = 0; // Stores the result of calculations
        string operation = ""; // Stores the current operation (e.g., +, -, *)
        bool isOperationPerformed = false; // Tracks if an operation was performed

        bool value0 = false;
        bool dot_active = false;
        double baseNumber = 1;


        string storedExpression = ""; // Stores the expression inside the function


        // button 1 is the exit






        private void button(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;


        }

        private void one_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void fiver_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent multiple operators in a row
            if (text.Length > 0 && "+-*/".Contains(text[^1])) return;

            Viewbox.Text += " " + button.Text + " ";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent multiple operators in a row
            if (text.Length > 0 && "+-*/".Contains(text[^1])) return;

            Viewbox.Text += " " + button.Text + " ";

        }


        private void times_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent multiple operators in a row
            if (text.Length > 0 && "+-*/".Contains(text[^1])) return;

            Viewbox.Text += " " + button.Text + " ";

        }

        private void divide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent multiple operators in a row
            if (text.Length > 0 && "+-*/".Contains(text[^1])) return;

            Viewbox.Text += " " + button.Text + " ";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = Viewbox.Text;



                // Evaluate the final expression
                result = EvaluateExpression(expression);
                Viewbox.Text = $"{result}";

                UpdateHistory($"{expression} = {result}");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Error (Invalid Input)");
            }
        }

        private void UpdateHistory(string entry)
        {
            const int maxEntries = 10; // Limit history to 10 calculations
            string[] historyLines = HistoryText.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (historyLines.Length >= maxEntries)
            {
                // Remove the oldest entry
                HistoryText.Text = string.Join("\n", historyLines.Skip(1));
            }

            // Append new entry
            HistoryText.Text += entry + "\n";
        }

        private string ProcessFunction(string expression, string function, Func<double, double> operation)
        {
            int startIndex = expression.IndexOf(function + "(");
            int endIndex = expression.IndexOf(")", startIndex);

            if (startIndex == -1 || endIndex == -1) return expression; // Prevents crash if improperly formatted

            string inside = expression.Substring(startIndex + function.Length + 1, endIndex - startIndex - function.Length - 1);
            double value = EvaluateExpression(inside);
            double result = operation(value);

            return expression.Replace(function + "(" + inside + ")", result.ToString());
        }

        private string ProcessPower(string expression)
        {
            string[] parts = expression.Split('^');
            if (parts.Length != 2) return expression; // Prevent errors

            double baseNum = EvaluateExpression(parts[0]);
            double exponent = EvaluateExpression(parts[1]);
            double result = Math.Pow(baseNum, exponent);

            return result.ToString();
        }




        private void Clear_Click(object sender, EventArgs e)
        {
            Viewbox.Text = "";

        }

        private double EvaluateExpression(string input)
        {
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(input, ""));
        }

        private void dot_Click(object sender, EventArgs e)
        {
            // Check if the last entered number already contains a decimal point
            if (!Viewbox.Text.Contains(".") || isOperationPerformed)
            {
                if (isOperationPerformed)
                {
                    // Reset the display when starting a new number
                    Viewbox.Text = "0";
                    isOperationPerformed = false;
                }

                // Append the decimal point
                Button button = (Button)sender;
                Viewbox.Text += button.Text;
                dot_active = true; // Track that a decimal is in use
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Equals_Click(sender, e);
            }
        }





        private void back_Click(object sender, EventArgs e)
        {

            string Text1 = Viewbox.Text;
            if (Text1.Length == 0)
            {
                dot_active = false;

            }
            else if (Text1.Length == 1)
            {
                Viewbox.Text = "0";
                dot_active = false;
            }
            else
            {
                Viewbox.Text = Text1.Substring(0, Text1.Length - 1); // remove the last part (lets try)
                if (!Viewbox.Text.Contains("."))
                {
                    dot_active = false;
                }
            }
        }



        private void open_parenthesis_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;

        }

        private void close_parenthesis_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;




        }

        // button 1 is the exit



        private void button1_Click(object sender, EventArgs e)
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

        private void Shrink_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized; // Minimize the calculator window
        }

        private void tab_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form2 and return to Form1
        }

        private void Viewbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void nine_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;

        }

        private void plus_Click_1(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent multiple operators in a row
            if (text.Length > 0 && "+-*/".Contains(text[^1])) return;

            Viewbox.Text += " " + button.Text + " ";

        }


        private void seven_Click_2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;

        }

        private void eight_Click_2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = Viewbox.Text;

            // Prevent leading zero issue
            if (text == "0" && button.Text != ".")
                Viewbox.Text = button.Text;
            else
                Viewbox.Text += button.Text;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}