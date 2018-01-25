using System;
using System.Windows.Forms;

namespace SimpleCalculator {

    public partial class Form1 : Form {

        public Form1()
        {
            InitializeComponent();

            AcceptButton = buttonCalculate;
            CancelButton = buttonExit;

            textBoxOperand1.TextChanged += ClearResult;
            textBoxOperand2.TextChanged += ClearResult;
            textBoxOperator.TextChanged += ClearResult;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

            try {

                bool isValid = isValidData();
                if (isValid)
                {
                    decimal operand1 = Convert.ToDecimal(textBoxOperand1.Text);
                    string operator1 = textBoxOperator.Text;
                    decimal operand2 = Convert.ToDecimal(textBoxOperand2.Text);

                    decimal result = Calculate(operand1, operator1, operand2);
                    result = Math.Round(result, 4);
                    textBoxResult.Text = result.ToString();
                    textBoxOperand1.Focus();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n\n" +
                                ex.GetType().ToString() + "\n" +
                                ex.StackTrace, "Exception");
            }
        }

        private bool isValidData()
        {

            if (IsOperator(textBoxOperator, "Operator") && IsPresent(textBoxOperator, "Operator")
                                                        && IsPresent(textBoxOperand1, "Operand 1") 
                                                        && IsDecimal(textBoxOperand1, "Operand 1")
                                                        && isWithinRange(textBoxOperand1, "Operand 1", 0, 1000000)
                                                        && IsPresent(textBoxOperand2, "Operand 2")
                                                        && IsDecimal(textBoxOperand2, "Operand 2")
                                                        && isWithinRange(textBoxOperand2, "Operand 2", 0, 1000000))
            {
                return true;
            }

            return false;
        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private bool IsOperator(TextBox textBox, string name)
        {
            if (!(textBox.Text.Equals("+")
                || textBox.Text.Equals("-")
                || textBox.Text.Equals("*")
                || textBox.Text.Equals("/")))
            {
                MessageBox.Show("Symbol for " + name + " is invalid.", "Entry Error");
                return false;
            }

            return true;
        }

        private bool isWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);

            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".",
                    "Entry Error");
                textBox.Focus();
                return false;
            }

            return true;
        }
        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }

            return true;
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }

            MessageBox.Show(name + " must be a decimal value.", "Entry Error");
            textBox.Focus();

            return false;
        }


    }
}