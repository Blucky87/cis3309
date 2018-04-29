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
    public partial class frmMain : Form
    {
        private ProductDB productDb;

        public frmMain()
        {
            InitializeComponent();
            productDb = new ProductDB();
        }

        private void btnGetProductByID_Click(object sender, EventArgs e)
        {
            Product product = productDb.GetProduct(txtProductID.Text);
            if (product != null)
            {
                txtOutput.Text = product.ToString();
            }
            else
            {
                MessageBox.Show($"No product with ID: {txtProductID.Text} found.");
            }
        }

        private void btnGetAllProducts_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();

            productList = productDb.GetAllProducts();

            if (productList == null)
            {
                MessageBox.Show("Database error.");
            }
            else if (productList.Count > 0)
            {
                txtOutput.Text = productList.ToString();
            }
            else
            {
                MessageBox.Show("No records found");
                txtOutput.Text = "";
            }

        }

        private void btnDeleteProductByID_Click(object sender, EventArgs e)
        {
            int count = productDb.DeleteProduct(txtProductID.Text);
            if (count > 0)
            {
                MessageBox.Show($"Product with ID: {txtProductID.Text} deleted.");
            }
            else
            {
                MessageBox.Show($"Unable to delete product iwth ID: {txtProductID.Text}.");
            }

            txtProductID.Text = "";
            txtOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Form productForm = new frmProduct();
            productForm.ShowDialog();

            if (productForm.DialogResult == DialogResult.OK)
            {
                Product product = productForm.Tag as Product;

                productDb.InsertProduct(product);
            }

        }

        private void btnCalcInventory_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList = productDb.GetAllProducts();

            if (productList.Count > 0)
            {
                txtOutput.Text = $"Total inventory worth: ${productList.CalcInventory()}";
            }

            txtProductID.Text = "";
            MessageBox.Show("No records in DB.");
        }
    }
}
