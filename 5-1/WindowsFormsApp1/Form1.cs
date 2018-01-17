using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class Form1 : Form {

        public Form1() {

            InitializeComponent();

            AcceptButton = buttonCalculate;
            CancelButton = buttonExit;
        }

        private void button1_Click(object sender, EventArgs e) {

            textBoxFactorial.Text = String.Format("{0:N0}", CalculateFactorial(int.Parse(textBoxNumber.Text)));
            textBoxNumber.Text = "";
            textBoxNumber.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {

            Close();
        }

        private Int64 CalculateFactorial(Int64 number) {

            if (number < 0) {
                return -1;
            } if (number == 1 || number == 0) {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }

    }

}
