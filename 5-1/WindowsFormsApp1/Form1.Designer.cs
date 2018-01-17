namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelFactorial = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxFactorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 111);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(114, 111);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 26);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(47, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Number:";
            // 
            // labelFactorial
            // 
            this.labelFactorial.AutoSize = true;
            this.labelFactorial.Location = new System.Drawing.Point(9, 64);
            this.labelFactorial.Name = "labelFactorial";
            this.labelFactorial.Size = new System.Drawing.Size(50, 13);
            this.labelFactorial.TabIndex = 3;
            this.labelFactorial.Text = "Factorial:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(74, 23);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(41, 20);
            this.textBoxNumber.TabIndex = 4;
            // 
            // textBoxFactorial
            // 
            this.textBoxFactorial.Location = new System.Drawing.Point(74, 61);
            this.textBoxFactorial.Name = "textBoxFactorial";
            this.textBoxFactorial.Size = new System.Drawing.Size(145, 20);
            this.textBoxFactorial.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 152);
            this.Controls.Add(this.textBoxFactorial);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelFactorial);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelFactorial;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxFactorial;
    }
}

