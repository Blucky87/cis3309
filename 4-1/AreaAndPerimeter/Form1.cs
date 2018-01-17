using System;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            KeyPreview = true;
            KeyPress += Form1_KeyPress;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtArea.Text = (Decimal.Parse(txtLength.Text) * Decimal.Parse(txtWidth.Text)).ToString();
            txtPerimeter.Text = ((Decimal.Parse(txtLength.Text) * 2) + (Decimal.Parse(txtWidth.Text) * 2)).ToString();

            txtLength.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\u001b'))
            {
                button2_Click(sender, e);
            }
        }

    }
}
