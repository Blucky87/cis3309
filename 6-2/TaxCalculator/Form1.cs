using System;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AcceptButton = buttonCalculate;
            CancelButton = buttonExit;

            textBoxIncome.TextChanged += ClearTax;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            decimal income = decimal.Parse(textBoxIncome.Text);
            decimal tax = CalculateTax(income);

            textBoxTax.Text = tax.ToString();
        }

        private decimal CalculateTax(decimal income)
        {
            decimal tax = 0m;

            if (income <= 9225)
                tax = (int)(income * .10m);
            else if (income > 9225 && income <= 37450)
                tax = 922.50m + (int)((income - 9225) * .15m);
            else if (income > 37450 && income <= 90750)
                tax = 5156.25m + (int)((income - 37450) * .25m);
            else if (income > 90750 && income <= 189300)
                tax = 18481.25m + (int)((income - 90750) * .28m);
            else if (income > 189300 && income <= 411500)
                tax = 46075.25m + (int)((income - 189300) * .33m);
            else if (income > 411500 && income <= 413200)
                tax = 119401.25m + (int)((income - 411500) * .35m);
            else if (income > 413200)
                tax = 119996.25m + (int)((income - 413200) * .396m);

            return tax;
        }

        private void ClearTax(object sender, EventArgs e)
        {
            textBoxTax.Text = "";
        }

    }
}
