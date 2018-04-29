using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class frmProduct : Form
    {
        private ProductDB productDb;
        public frmProduct()
        {
            InitializeComponent();
            productDb = new ProductDB();
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID = txtID.Text;
            product.Description = txtDescription.Text;
            product.Price = Double.Parse(txtPrice.Text);
            product.Quantity = Int32.Parse(txtQuantity.Text);
            this.Tag = product;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
