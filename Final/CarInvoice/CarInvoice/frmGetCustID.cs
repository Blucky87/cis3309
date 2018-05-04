using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInvoice
{
    public partial class frmGetCustID : Form
    {
        public frmGetCustID()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int id;
            bool valid = Int32.TryParse(txtCustID.Text, out id);

            if (valid)
            {
                DialogResult = DialogResult.OK;
                Tag = id;
                Close();
            }
            else
            {
                MessageBox.Show("Not a valid integer value.");
            }
        }
    }
}
