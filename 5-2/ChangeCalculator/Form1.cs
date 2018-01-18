using System;
using System.Windows.Forms;

namespace ChangeCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            AcceptButton = buttonCalculate;
            CancelButton = buttonExit;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBoxAmount.Text);
            int quarters = 0, dimes = 0, nickels = 0, pennies = 0, remainder = 0;

            quarters  = amount / 25;
            remainder = amount % 25;
            dimes     = remainder / 10;
            remainder = remainder % 10;
            nickels   = remainder / 5;
            pennies   = remainder % 5;

            textBoxAmount.Text = "";
            textBoxAmount.Focus();

            textBoxQuarters.Text = quarters.ToString();
            textBoxDimes.Text = dimes.ToString();
            textBoxNickels.Text = nickels.ToString();
            textBoxPennies.Text = pennies.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
