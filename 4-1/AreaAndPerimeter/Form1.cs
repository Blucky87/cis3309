using System;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AcceptButton = buttonCalculate;
            CancelButton = buttonExit;
        }

        private void CalculateButton_Click(object sender, EventArgs e) {

            textboxArea.Text = (Decimal.Parse(textboxLength.Text) * Decimal.Parse(textboxWidth.Text)).ToString();
            textboxPerimeter.Text = ((Decimal.Parse(textboxLength.Text) * 2) + (Decimal.Parse(textboxWidth.Text) * 2)).ToString();

            textboxLength.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
        }

    }
}
