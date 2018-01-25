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
            decimal operand1 = decimal.Parse(textBoxOperand1.Text);
            string operator1 = textBoxOperator.Text;

            decimal operand2 = decimal.Parse(textBoxOperand2.Text);
            decimal result = Calculate(operand1, operator1, operand2);

            result = Math.Round(result, 4);
            textBoxResult.Text = result.ToString();
            textBoxOperand1.Focus();
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

    }
}