using System;
using System.Windows.Forms;

namespace Factorial {

    public partial class Form1 : Form {

        public Form1() {

            InitializeComponent();

            AcceptButton = buttonCalculate;
            CancelButton = buttonExit;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            Int64 factorial = CalculateFactorial(int.Parse(textBoxNumber.Text));
            textBoxFactorial.Text = String.Format("{0:N0}",factorial);
            textBoxNumber.Text = "";
            textBoxNumber.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e) {

            Close();
        }

        private Int64 CalculateFactorial(int number) {

            if (number < 0) {
                return -1;
            }
            if (number == 1 || number == 0) {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }

    }

}
