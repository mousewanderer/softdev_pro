using System;
using System.ComponentModel;
using System.Data;

namespace GreaterACT6
{
    public partial class Calculator : Form
    {

        double result = 0; // Stores the result of calculations
        string operation = ""; // Stores the current operation (e.g., +, -, *)
        bool isOperationPerformed = false; // Tracks if an operation was performed

        bool value0 = false;
        bool dot_active = false;
        double baseNumber = 1;

        bool powerup = false;

         bool isSqrtActive = false;
         bool isLogActive = false;
        bool isPowerActive = false;
        string storedExpression = ""; // Stores the expression inside the function

        bool isSinActive = false;
        bool isCosActive = false;
        bool isTanActive = false;
        bool isLnActive = false;


        public Calculator()
        {
            InitializeComponent();
        }



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

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = Viewbox.Text;

                if (expression.Contains("sin("))
                {
                    expression = ProcessFunction(expression, "sin", x => Math.Sin(x * (Math.PI / 180))); // Convert to radians
                }
                if (expression.Contains("cos("))
                {
                    expression = ProcessFunction(expression, "cos", x => Math.Cos(x * (Math.PI / 180)));
                }
                if (expression.Contains("tan("))
                {
                    expression = ProcessFunction(expression, "tan", x =>
                    {
                        double radians = x * (Math.PI / 180);
                        return Math.Cos(radians) == 0 ? double.NaN : Math.Tan(radians); // Avoid undefined tan(90), tan(270)
                    });
                }

                if (expression.Contains("sqrt("))
                {
                    expression = ProcessFunction(expression, "sqrt", Math.Sqrt);
                }
                if (expression.Contains("log("))
                {
                    expression = ProcessFunction(expression, "log", Math.Log10);
                }
                if (expression.Contains("^"))
                {
                    expression = ProcessPower(expression);
                }

                // Evaluate the final expression
                result = EvaluateExpression(expression);
                Viewbox.Text = $"{result:n3}";
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
                equals_Click(sender, e);
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

        private void squareroot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text))
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1]; // Last character
                char secondLastChar = Viewbox.Text.Length > 1 ? Viewbox.Text[Viewbox.Text.Length - 2] : ' '; // Avoid index error

                if (lastChar == ' ')
                {
                    // If there's a space before sqrt, just append sqrt(
                    Viewbox.Text += "sqrt(";
                }
                else if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    Viewbox.Text += " sqrt("; // Keep spacing consistent
                }
                else if (secondLastChar == '+' || secondLastChar == '-' || secondLastChar == '*' || secondLastChar == '/')
                {
                    Viewbox.Text += "sqrt("; // If second last char is an operator, prevent extra space
                }
                else
                {
                    Viewbox.Text += "* sqrt("; // Multiply if there's an existing number
                }
            }
            else
            {
                Viewbox.Text = "sqrt("; // Allow sqrt() as the first input
            }

            isSqrtActive = true;
        }

        //------------------------------------------------------------------------------------------
        private void power_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text))
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1];

                if (char.IsDigit(lastChar) || lastChar == ')')
                {
                    Viewbox.Text += " ^ ";
                }
            }

            isPowerActive = true;
        }

        //------------------------------------------------------------------------------------------
        private void naturallog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text))
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1]; // Last character
                char secondLastChar = Viewbox.Text.Length > 1 ? Viewbox.Text[Viewbox.Text.Length - 2] : ' '; // Avoid index error

                if (lastChar == ' ')
                {
                    // If there's a space before ln, just append ln(
                    Viewbox.Text += "ln(";
                }
                else if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    Viewbox.Text += " ln("; // Keep spacing consistent
                }
                else if (secondLastChar == '+' || secondLastChar == '-' || secondLastChar == '*' || secondLastChar == '/')
                {
                    Viewbox.Text += "ln("; // If second last char is an operator, prevent extra space
                }
                else
                {
                    Viewbox.Text += "* ln("; // Multiply if there's an existing number
                }
            }
            else
            {
                Viewbox.Text = "ln("; // Allow ln() as the first input
            }

            isLnActive = true;
        }

        //------------------------------------------------------------------------------------------
        private void logarithm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text)  )
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1]; // Last character
                char secondLastChar = Viewbox.Text.Length > 1 ? Viewbox.Text[Viewbox.Text.Length - 2] : ' '; // Avoid index error

                if (lastChar == ' ')
                {
                    // If there's a space before log, just append log(
                    Viewbox.Text += "log(";
                }
                else if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    Viewbox.Text += " log("; // Keep spacing consistent
                }
                else if (secondLastChar == '+' || secondLastChar == '-' || secondLastChar == '*' || secondLastChar == '/')
                {
                    Viewbox.Text += "log("; // If second last char is an operator, prevent extra space
                }
                else
                {
                 
                    Viewbox.Text += "* log("; // Multiply if there's an existing number
                }
            }
            else
            {
                Viewbox.Text = "log("; // Allow log() as the first input
            }

            isLogActive = true;
        }
        //------------------------------------------------------------------------------------------
        private void Sinetrigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text))
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1];

                if (char.IsDigit(lastChar) || lastChar == ')')
                {
                    Viewbox.Text += " * sin(";
                }
                else if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    Viewbox.Text += " sin(";
                }
                else
                {
                    Viewbox.Text += "sin(";
                }
            }
            else
            {
                Viewbox.Text = "sin(";
            }

            isSinActive = true;
        }

        private void cosinetrigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text))
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1];

                if (char.IsDigit(lastChar) || lastChar == ')')
                {
                    Viewbox.Text += " * cos(";
                }
                else if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    Viewbox.Text += " cos(";
                }
                else
                {
                    Viewbox.Text += "cos(";
                }
            }
            else
            {
                Viewbox.Text = "cos(";
            }

            isCosActive = true;
        }
        private void tangeanttrigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Viewbox.Text))
            {
                char lastChar = Viewbox.Text[Viewbox.Text.Length - 1];

                if (char.IsDigit(lastChar) || lastChar == ')')
                {
                    Viewbox.Text += " * tan(";
                }
                else if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    Viewbox.Text += " tan(";
                }
                else
                {
                    Viewbox.Text += "tan(";
                }
            }
            else
            {
                Viewbox.Text = "tan(";
            }

            isTanActive = true;
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
    }
}

