namespace Products
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcInventory = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDeleteProductByID = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.btnGetProductByID = new System.Windows.Forms.Button();
            this.btnGetAllProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcInventory
            // 
            this.btnCalcInventory.Location = new System.Drawing.Point(846, 677);
            this.btnCalcInventory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcInventory.Name = "btnCalcInventory";
            this.btnCalcInventory.Size = new System.Drawing.Size(196, 44);
            this.btnCalcInventory.TabIndex = 15;
            this.btnCalcInventory.Text = "Calc Inventory";
            this.btnCalcInventory.UseVisualStyleBackColor = true;
            this.btnCalcInventory.Click += new System.EventHandler(this.btnCalcInventory_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(24, 23);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1014, 639);
            this.txtOutput.TabIndex = 14;
            // 
            // btnDeleteProductByID
            // 
            this.btnDeleteProductByID.Location = new System.Drawing.Point(316, 733);
            this.btnDeleteProductByID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteProductByID.Name = "btnDeleteProductByID";
            this.btnDeleteProductByID.Size = new System.Drawing.Size(230, 44);
            this.btnDeleteProductByID.TabIndex = 13;
            this.btnDeleteProductByID.Text = "Delete Product by ID";
            this.btnDeleteProductByID.UseVisualStyleBackColor = true;
            this.btnDeleteProductByID.Click += new System.EventHandler(this.btnDeleteProductByID_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(558, 683);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(196, 31);
            this.txtProductID.TabIndex = 12;
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Location = new System.Drawing.Point(24, 677);
            this.btnInsertProduct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(230, 44);
            this.btnInsertProduct.TabIndex = 11;
            this.btnInsertProduct.Text = "Insert Product";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // btnGetProductByID
            // 
            this.btnGetProductByID.Location = new System.Drawing.Point(316, 677);
            this.btnGetProductByID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetProductByID.Name = "btnGetProductByID";
            this.btnGetProductByID.Size = new System.Drawing.Size(230, 44);
            this.btnGetProductByID.TabIndex = 10;
            this.btnGetProductByID.Text = "Get Product by ID";
            this.btnGetProductByID.UseVisualStyleBackColor = true;
            this.btnGetProductByID.Click += new System.EventHandler(this.btnGetProductByID_Click);
            // 
            // btnGetAllProducts
            // 
            this.btnGetAllProducts.Location = new System.Drawing.Point(24, 733);
            this.btnGetAllProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetAllProducts.Name = "btnGetAllProducts";
            this.btnGetAllProducts.Size = new System.Drawing.Size(230, 44);
            this.btnGetAllProducts.TabIndex = 9;
            this.btnGetAllProducts.Text = "Get All Products";
            this.btnGetAllProducts.UseVisualStyleBackColor = true;
            this.btnGetAllProducts.Click += new System.EventHandler(this.btnGetAllProducts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(846, 733);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 802);
            this.Controls.Add(this.btnCalcInventory);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDeleteProductByID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnInsertProduct);
            this.Controls.Add(this.btnGetProductByID);
            this.Controls.Add(this.btnGetAllProducts);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcInventory;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDeleteProductByID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Button btnGetProductByID;
        private System.Windows.Forms.Button btnGetAllProducts;
        private System.Windows.Forms.Button btnExit;
    }
}

