namespace AreaAndPerimeter
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textboxLength = new System.Windows.Forms.TextBox();
            this.textboxWidth = new System.Windows.Forms.TextBox();
            this.textboxArea = new System.Windows.Forms.TextBox();
            this.textboxPerimeter = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(23, 175);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(146, 175);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textboxLength
            // 
            this.textboxLength.Location = new System.Drawing.Point(121, 25);
            this.textboxLength.Name = "textboxLength";
            this.textboxLength.Size = new System.Drawing.Size(100, 20);
            this.textboxLength.TabIndex = 2;
            // 
            // textboxWidth
            // 
            this.textboxWidth.Location = new System.Drawing.Point(121, 51);
            this.textboxWidth.Name = "textboxWidth";
            this.textboxWidth.Size = new System.Drawing.Size(100, 20);
            this.textboxWidth.TabIndex = 3;
            // 
            // textboxArea
            // 
            this.textboxArea.Location = new System.Drawing.Point(121, 95);
            this.textboxArea.Name = "textboxArea";
            this.textboxArea.ReadOnly = true;
            this.textboxArea.Size = new System.Drawing.Size(100, 20);
            this.textboxArea.TabIndex = 4;
            // 
            // textboxPerimeter
            // 
            this.textboxPerimeter.Location = new System.Drawing.Point(121, 121);
            this.textboxPerimeter.Name = "textboxPerimeter";
            this.textboxPerimeter.ReadOnly = true;
            this.textboxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textboxPerimeter.TabIndex = 5;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(51, 28);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "Length:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(51, 58);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(51, 98);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(32, 13);
            this.labelArea.TabIndex = 8;
            this.labelArea.Text = "Area:";
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(51, 124);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(54, 13);
            this.labelPerimeter.TabIndex = 9;
            this.labelPerimeter.Text = "Perimeter:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 215);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textboxPerimeter);
            this.Controls.Add(this.textboxArea);
            this.Controls.Add(this.textboxWidth);
            this.Controls.Add(this.textboxLength);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Area And Perimeter";
            this.Text = "Area And Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textboxLength;
        private System.Windows.Forms.TextBox textboxWidth;
        private System.Windows.Forms.TextBox textboxArea;
        private System.Windows.Forms.TextBox textboxPerimeter;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelPerimeter;
    }
}

