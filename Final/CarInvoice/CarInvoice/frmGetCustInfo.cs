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
    public partial class frmGetCustInfo : Form
    {
        public frmGetCustInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGetCustInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.State = txtState.Text;
            customer.ZipCode = txtZipCode.Text;

            Tag = customer;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZipCode.Text = string.Empty;
        }
    }
}
