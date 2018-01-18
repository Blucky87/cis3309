using System;
using System.CodeDom;
using System.Collections.Generic;
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
                List<TextBox> textBoxList = new List<TextBox>();
                textBoxList.Add(textBoxOperand1);
                textBoxList.Add(textBoxOperand2);
                textBoxList.Add(textBoxOperator);
                
                textBoxList.ForEach(IsOperator);
                textBoxList.ForEach(IsPresent);

                decimal operand1 = Convert.ToDecimal(textBoxOperand1.Text);
                string operator1 = textBoxOperator.Text;
                decimal operand2 = Convert.ToDecimal(textBoxOperand2.Text);
                decimal result = Calculate(operand1, operator1, operand2);

                result = Math.Round(result, 4);
                this.textBoxResult.Text = result.ToString();
                textBoxOperand1.Focus();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n\n" +
                                ex.GetType().ToString() + "\n" +
                                ex.StackTrace, "Exception");
            }
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

        private void IsOperator(TextBox textBox)
        {
            if (!textBox.Text.Equals("+")
                || !textBox.Text.Equals("-")
                || !textBox.Text.Equals("*")
                || !textBox.Text.Equals("/"))
            {
                throw new 
            }
        }

        private void IsPresent(TextBox textBox)
        {
            if (textBox.Text.Equals(""))
            {
                throw new FormatException("TextBox is Empty");
            }
        }

        private void IsDecimal(TextBox textBox)
        {

        }


    }
}