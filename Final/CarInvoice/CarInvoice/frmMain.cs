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
    public partial class frmMain : Form
    {
        private Customer customer;
        private CarDB carDb;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            carDb = new CarDB();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmGetCustInfo frmGetCustInfo = new frmGetCustInfo();
            frmGetCustInfo.ShowDialog();

            if (frmGetCustInfo.DialogResult == DialogResult.OK)
            {
                customer = frmGetCustInfo.Tag as Customer;

                customer.ID = carDb.MaxCustomer() + 1;
                carDb.InsertCustomer(customer);

                customer = carDb.SelectCustomer(customer.ID);
                MessageBox.Show(customer.ToString());
            }
        }

        private void btnConfigCar_Click(object sender, EventArgs e)
        {
            frmGetCustID frmGetCustId = new frmGetCustID();
            frmGetCustId.ShowDialog();

            if (frmGetCustId.DialogResult == DialogResult.OK)
            {
                customer = carDb.SelectCustomer((Int32)frmGetCustId.Tag);

                frmBuildCar frmBuildCar = new frmBuildCar(customer);
                frmBuildCar.ShowDialog();

                if (frmBuildCar.DialogResult == DialogResult.Abort) Close();
            }
        }
    }
}
