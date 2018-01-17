using System;
using System.Windows.Forms;

namespace SimpleCalculator {

    public partial class Form1 : Form {

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var operand1 = Convert.ToDecimal(textBoxOperand1.Text);
                var operator1 = textBoxOperator.Text;
                var operand2 = Convert.ToDecimal(textBoxOperand2.Text);
                var result = Calculate(operand1, operator1, operand2);

                result = Math.Round(result, 4);
                textBoxResult.Text = result.ToString();
                textBoxOperand1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error. Please enter smaller values.",
                    "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Divide-by-zero error. Please enter a non-zero value for operand 2.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                                ex.GetType() + "\n" +
                                ex.StackTrace, "Exception");
            }
        }

        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
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
    }
}