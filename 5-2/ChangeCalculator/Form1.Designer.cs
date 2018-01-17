namespace ChangeCalculator {
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelQuarters = new System.Windows.Forms.Label();
            this.labelDimes = new System.Windows.Forms.Label();
            this.labelNickels = new System.Windows.Forms.Label();
            this.labelPennies = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxQuarters = new System.Windows.Forms.TextBox();
            this.textBoxDimes = new System.Windows.Forms.TextBox();
            this.textBoxNickels = new System.Windows.Forms.TextBox();
            this.textBoxPennies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(52, 211);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Calculate";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(155, 211);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(25, 38);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(148, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount of change due (0-99):";
            // 
            // labelQuarters
            // 
            this.labelQuarters.AutoSize = true;
            this.labelQuarters.Location = new System.Drawing.Point(123, 79);
            this.labelQuarters.Name = "labelQuarters";
            this.labelQuarters.Size = new System.Drawing.Size(50, 13);
            this.labelQuarters.TabIndex = 3;
            this.labelQuarters.Text = "Quarters:";
            // 
            // labelDimes
            // 
            this.labelDimes.AutoSize = true;
            this.labelDimes.Location = new System.Drawing.Point(134, 105);
            this.labelDimes.Name = "labelDimes";
            this.labelDimes.Size = new System.Drawing.Size(39, 13);
            this.labelDimes.TabIndex = 4;
            this.labelDimes.Text = "Dimes:";
            // 
            // labelNickels
            // 
            this.labelNickels.AutoSize = true;
            this.labelNickels.Location = new System.Drawing.Point(128, 131);
            this.labelNickels.Name = "labelNickels";
            this.labelNickels.Size = new System.Drawing.Size(45, 13);
            this.labelNickels.TabIndex = 5;
            this.labelNickels.Text = "Nickels:";
            // 
            // labelPennies
            // 
            this.labelPennies.AutoSize = true;
            this.labelPennies.Location = new System.Drawing.Point(125, 160);
            this.labelPennies.Name = "labelPennies";
            this.labelPennies.Size = new System.Drawing.Size(48, 13);
            this.labelPennies.TabIndex = 6;
            this.labelPennies.Text = "Pennies:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(187, 35);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(43, 20);
            this.textBoxAmount.TabIndex = 7;
            // 
            // textBoxQuarters
            // 
            this.textBoxQuarters.Location = new System.Drawing.Point(187, 76);
            this.textBoxQuarters.Name = "textBoxQuarters";
            this.textBoxQuarters.Size = new System.Drawing.Size(43, 20);
            this.textBoxQuarters.TabIndex = 8;
            // 
            // textBoxDimes
            // 
            this.textBoxDimes.Location = new System.Drawing.Point(187, 102);
            this.textBoxDimes.Name = "textBoxDimes";
            this.textBoxDimes.Size = new System.Drawing.Size(43, 20);
            this.textBoxDimes.TabIndex = 9;
            // 
            // textBoxNickels
            // 
            this.textBoxNickels.Location = new System.Drawing.Point(187, 128);
            this.textBoxNickels.Name = "textBoxNickels";
            this.textBoxNickels.Size = new System.Drawing.Size(43, 20);
            this.textBoxNickels.TabIndex = 10;
            // 
            // textBoxPennies
            // 
            this.textBoxPennies.Location = new System.Drawing.Point(187, 157);
            this.textBoxPennies.Name = "textBoxPennies";
            this.textBoxPennies.Size = new System.Drawing.Size(43, 20);
            this.textBoxPennies.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 247);
            this.Controls.Add(this.textBoxPennies);
            this.Controls.Add(this.textBoxNickels);
            this.Controls.Add(this.textBoxDimes);
            this.Controls.Add(this.textBoxQuarters);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelPennies);
            this.Controls.Add(this.labelNickels);
            this.Controls.Add(this.labelDimes);
            this.Controls.Add(this.labelQuarters);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelQuarters;
        private System.Windows.Forms.Label labelDimes;
        private System.Windows.Forms.Label labelNickels;
        private System.Windows.Forms.Label labelPennies;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxQuarters;
        private System.Windows.Forms.TextBox textBoxDimes;
        private System.Windows.Forms.TextBox textBoxNickels;
        private System.Windows.Forms.TextBox textBoxPennies;
    }
}

