namespace TaxCalculator
{
    partial class Form1
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
            this.labelIncome = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(26, 50);
            this.labelIncome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(170, 25);
            this.labelIncome.TabIndex = 0;
            this.labelIncome.Text = "Taxable income:";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(226, 44);
            this.textBoxIncome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(196, 31);
            this.textBoxIncome.TabIndex = 1;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(26, 100);
            this.labelTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(179, 25);
            this.labelTax.TabIndex = 2;
            this.labelTax.Text = "Income tax owed:";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(226, 94);
            this.textBoxTax.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(196, 31);
            this.textBoxTax.TabIndex = 3;
            this.textBoxTax.TabStop = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(88, 167);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 44);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(276, 167);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 44);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(508, 244);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.labelIncome);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
    }
}

