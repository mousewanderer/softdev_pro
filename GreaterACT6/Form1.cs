using System.ComponentModel;

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
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
            value0 = true;
        }

        private void one_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void fiver_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            // If a calculation was just performed, clear the TextBox
            if ((Viewbox.Text == "0") || (isOperationPerformed))
                Viewbox.Clear();
            isOperationPerformed = false;
            // Append the button text to the TextBox
            Button button = (Button)sender;
            Viewbox.Text += button.Text;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            dot_active = false;
            Button button = (Button)sender;
            // If there's already a result, perform the previous operation
            if (result != 0)
            {
                Equals.PerformClick();
                operation = button.Text; // Set the new operation
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(Viewbox.Text);
                isOperationPerformed = true;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            dot_active = false;
            Button button = (Button)sender;
            // If there's already a result, perform the previous operation
            if (result != 0)
            {
                Equals.PerformClick();
                operation = button.Text; // Set the new operation
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(Viewbox.Text);
                isOperationPerformed = true;
            }

        }


        private void times_Click(object sender, EventArgs e)
        {
            dot_active = false;
            Button button = (Button)sender;
            // If there's already a result, perform the previous operation
            if (result != 0)
            {
                Equals.PerformClick();
                operation = button.Text; // Set the new operation
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(Viewbox.Text);
                isOperationPerformed = true;
            }

        }

        private void divide_Click(object sender, EventArgs e)
        {
            dot_active = false;
            Button button = (Button)sender;
            // If there's already a result, perform the previous operation
            if (result != 0)
            {
                Equals.PerformClick();
                operation = button.Text; // Set the new operation
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(Viewbox.Text);

                isOperationPerformed = true;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {

            string result1 = "";
            double secondNumber = Double.Parse(Viewbox.Text); // Get exponent (y)


            switch (operation)
            {


                case "^": // Power operation

                    if (powerup)
                    {
                        // If power mode is active, use the entered second number as the exponent
                        result = Math.Pow(result, secondNumber);
                        powerup = false;  // Reset the flag after computing the power
                        Viewbox.Text = $"{result:n3}";
                    }

                    break;
                case "+":
                    Viewbox.Text = $"{(result + Double.Parse(Viewbox.Text)).ToString():n3}";
                    break;
                case "-":
                    Viewbox.Text = $"{(result - Double.Parse(Viewbox.Text)).ToString():n3}";
                    break;
                case "*":
                    Viewbox.Text = $"{(result * Double.Parse(Viewbox.Text)).ToString():n3}";
                    break;
                case "/":
                    if (Double.Parse(Viewbox.Text) != 0)

                        Viewbox.Text = $"{(result / Double.Parse(Viewbox.Text)).ToString():n3}";

                    else
                    {
                        result1 = "";
                        MessageBox.Show("Division Error: Cannot Divided by Zero");
                    }


                    break;
                default:
                    result = secondNumber;
                    break;
            }
            // format good
            result1 = $"{Viewbox.Text:n3}";
            result = Double.Parse(result1);

            operation = "";


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Viewbox.Text = "0";
            result = 0;
            operation = "";
            dot_active = false;


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
            double number = Double.Parse(Viewbox.Text);

            if (number >= 0)
            {
                result = Math.Sqrt(number);
                Viewbox.Text = $"{result:n3}"; // Display formatted result
            }
            else
            {
                Viewbox.Text = "Error (Invalid Input)"; // Square root of negative number
            }

            operation = ""; // Reset operation
        }


        private void power_Click(object sender, EventArgs e)
        {
            dot_active = false;
            Button button = (Button)sender;
            // If there's already a result, perform the previous operation
            if (result != 0)
            {
                Equals.PerformClick();
                operation = button.Text; // This should be "^"
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(Viewbox.Text);
                isOperationPerformed = true;
            }
            // Set the flag to capture the exponent on the next entry
            powerup = true;
        }

        private void naturallog_Click(object sender, EventArgs e)
        {
            double number = Double.Parse(Viewbox.Text);

            if (number > 0)
            {
                result = Math.Log(number); // Natural log (base e)
                Viewbox.Text = $"{result:n3}"; // Display formatted result
            }
            else
            {
                Viewbox.Text = "Error (Invalid Input)"; // Log of zero or negative number is undefined
            }

            operation = ""; // Reset operation

        }

        private void logarithm_Click(object sender, EventArgs e)
        {
            double number = Double.Parse(Viewbox.Text);

            if (number > 0)
            {
                result = Math.Log10(number);
                Viewbox.Text = $"{result:n3}"; // Display formatted result
            }
            else
            {
                Viewbox.Text = "Error (Invalid Input)"; // Log of zero or negative number is undefined
            }

            operation = ""; // Reset operation

        }

        private void Sinetrigo_Click(object sender, EventArgs e)
        {
            double degrees = Double.Parse(Viewbox.Text);
            double radians = degrees * (Math.PI / 180); // Convert to radians

            result = Math.Sin(radians);
            Viewbox.Text = $"{result:n6}"; // Display with 6 decimal places

            operation = ""; // Reset operation
        }

        private void cosinetrigo_Click(object sender, EventArgs e)
        {
            double degrees = Double.Parse(Viewbox.Text);
            double radians = degrees * (Math.PI / 180); // Convert to radians

            result = Math.Cos(radians);
            Viewbox.Text = $"{result:n6}";

            operation = ""; // Reset operation

        }

        private void tangeanttrigo_Click(object sender, EventArgs e)
        {
            double degrees = Double.Parse(Viewbox.Text);
            double radians = degrees * (Math.PI / 180); // Convert to radians

            if (Math.Cos(radians) == 0) // Avoid undefined values (tan(90), tan(270), etc.)
            {
                MessageBox.Show("Division Error: Cannot Divided by Zero");
                Viewbox.Text = "";
            }
            else
            {
                result = Math.Tan(radians);
                Viewbox.Text = $"{result:n6}";
            }

            operation = ""; // Reset operation

        }
    }
}

