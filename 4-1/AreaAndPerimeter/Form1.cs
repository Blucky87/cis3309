using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

    }
}
