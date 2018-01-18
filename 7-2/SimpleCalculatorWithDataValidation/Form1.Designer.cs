namespace SimpleCalculator
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.textBoxOperand2 = new System.Windows.Forms.TextBox();
            this.textBoxOperator = new System.Windows.Forms.TextBox();
            this.textBoxOperand1 = new System.Windows.Forms.TextBox();
            this.LabelOperand2 = new System.Windows.Forms.Label();
            this.LabelOperator = new System.Windows.Forms.Label();
            this.LabelOperand1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(111, 147);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(72, 24);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(23, 147);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(80, 24);
            this.buttonCalculate.TabIndex = 28;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.Location = new System.Drawing.Point(23, 115);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(80, 16);
            this.LabelResult.TabIndex = 26;
            this.LabelResult.Text = "Result:";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxOperand2
            // 
            this.textBoxOperand2.Location = new System.Drawing.Point(111, 83);
            this.textBoxOperand2.Name = "textBoxOperand2";
            this.textBoxOperand2.Size = new System.Drawing.Size(72, 20);
            this.textBoxOperand2.TabIndex = 25;
            this.textBoxOperand2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // textBoxOperator
            // 
            this.textBoxOperator.Location = new System.Drawing.Point(111, 51);
            this.textBoxOperator.Name = "textBoxOperator";
            this.textBoxOperator.Size = new System.Drawing.Size(24, 20);
            this.textBoxOperator.TabIndex = 24;
            this.textBoxOperator.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // textBoxOperand1
            // 
            this.textBoxOperand1.Location = new System.Drawing.Point(111, 19);
            this.textBoxOperand1.Name = "textBoxOperand1";
            this.textBoxOperand1.Size = new System.Drawing.Size(72, 20);
            this.textBoxOperand1.TabIndex = 23;
            this.textBoxOperand1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // LabelOperand2
            // 
            this.LabelOperand2.Location = new System.Drawing.Point(23, 83);
            this.LabelOperand2.Name = "LabelOperand2";
            this.LabelOperand2.Size = new System.Drawing.Size(80, 16);
            this.LabelOperand2.TabIndex = 22;
            this.LabelOperand2.Text = "Operand 2:";
            this.LabelOperand2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelOperator
            // 
            this.LabelOperator.Location = new System.Drawing.Point(23, 51);
            this.LabelOperator.Name = "LabelOperator";
            this.LabelOperator.Size = new System.Drawing.Size(80, 16);
            this.LabelOperator.TabIndex = 21;
            this.LabelOperator.Text = "Operator:";
            this.LabelOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelOperand1
            // 
            this.LabelOperand1.Location = new System.Drawing.Point(23, 19);
            this.LabelOperand1.Name = "LabelOperand1";
            this.LabelOperand1.Size = new System.Drawing.Size(80, 16);
            this.LabelOperand1.TabIndex = 20;
            this.LabelOperand1.Text = "Operand 1:";
            this.LabelOperand1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(111, 115);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(72, 20);
            this.textBoxResult.TabIndex = 30;
            this.textBoxResult.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(227, 186);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.textBoxOperand2);
            this.Controls.Add(this.textBoxOperator);
            this.Controls.Add(this.textBoxOperand1);
            this.Controls.Add(this.LabelOperand2);
            this.Controls.Add(this.LabelOperator);
            this.Controls.Add(this.LabelOperand1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button buttonExit;
        internal System.Windows.Forms.Button buttonCalculate;
        internal System.Windows.Forms.Label LabelResult;
        internal System.Windows.Forms.TextBox textBoxOperand2;
        internal System.Windows.Forms.TextBox textBoxOperator;
        internal System.Windows.Forms.TextBox textBoxOperand1;
        internal System.Windows.Forms.Label LabelOperand2;
        internal System.Windows.Forms.Label LabelOperator;
        internal System.Windows.Forms.Label LabelOperand1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

