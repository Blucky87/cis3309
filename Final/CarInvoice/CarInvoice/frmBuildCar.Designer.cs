namespace CarInvoice
{
    partial class frmBuildCar
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
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.cbxInterior = new System.Windows.Forms.ComboBox();
            this.rtxtCarInfo = new System.Windows.Forms.RichTextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(153, 13);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(180, 21);
            this.cbxModel.TabIndex = 0;
            this.cbxModel.Text = "Select a Model";
            this.cbxModel.SelectedIndexChanged += new System.EventHandler(this.cbxModel_SelectedIndexChanged);
            // 
            // cbxPackage
            // 
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Location = new System.Drawing.Point(153, 66);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(180, 21);
            this.cbxPackage.TabIndex = 1;
            this.cbxPackage.Text = "Select a Package";
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(153, 114);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(180, 21);
            this.cbxColor.TabIndex = 2;
            this.cbxColor.Text = "Select a Color";
            // 
            // cbxInterior
            // 
            this.cbxInterior.FormattingEnabled = true;
            this.cbxInterior.Location = new System.Drawing.Point(153, 162);
            this.cbxInterior.Name = "cbxInterior";
            this.cbxInterior.Size = new System.Drawing.Size(180, 21);
            this.cbxInterior.TabIndex = 3;
            this.cbxInterior.Text = "Select an Interior";
            // 
            // rtxtCarInfo
            // 
            this.rtxtCarInfo.Location = new System.Drawing.Point(343, 12);
            this.rtxtCarInfo.Name = "rtxtCarInfo";
            this.rtxtCarInfo.ReadOnly = true;
            this.rtxtCarInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtCarInfo.Size = new System.Drawing.Size(429, 438);
            this.rtxtCarInfo.TabIndex = 4;
            this.rtxtCarInfo.Text = "";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(153, 210);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(180, 20);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "Enter a Discount";
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.Location = new System.Drawing.Point(153, 255);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(180, 23);
            this.btnCalcTotal.TabIndex = 6;
            this.btnCalcTotal.Text = "Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = true;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(153, 284);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(180, 23);
            this.btnSaveInvoice.TabIndex = 7;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(12, 73);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(126, 40);
            this.btnMain.TabIndex = 9;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmBuildCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMain;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.rtxtCarInfo);
            this.Controls.Add(this.cbxInterior);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxPackage);
            this.Controls.Add(this.cbxModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuildCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Your Car";
            this.Load += new System.EventHandler(this.frmBuildCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxInterior;
        private System.Windows.Forms.RichTextBox rtxtCarInfo;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMain;
    }
}