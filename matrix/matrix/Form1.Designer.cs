using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace matrix
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
            this.buttonMatrixAGenerate = new System.Windows.Forms.Button();
            this.buttonMatrixBGenerate = new System.Windows.Forms.Button();
            this.textBoxMatrixARows = new System.Windows.Forms.TextBox();
            this.textBoxMatrixBRows = new System.Windows.Forms.TextBox();
            this.textBoxMatrixAColumns = new System.Windows.Forms.TextBox();
            this.textBoxMatrixBColumns = new System.Windows.Forms.TextBox();
            this.textBoxMatrixADisplay = new System.Windows.Forms.TextBox();
            this.textBoxMatrixBDisplay = new System.Windows.Forms.TextBox();
            this.textBoxMatrixCDisplay = new System.Windows.Forms.TextBox();
            this.radioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonMatrixBIdentity = new System.Windows.Forms.Button();
            this.buttonMatrixAllClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMatrixAGenerate
            // 
            this.buttonMatrixAGenerate.Location = new System.Drawing.Point(9, 227);
            this.buttonMatrixAGenerate.Name = "buttonMatrixAGenerate";
            this.buttonMatrixAGenerate.Size = new System.Drawing.Size(127, 23);
            this.buttonMatrixAGenerate.TabIndex = 0;
            this.buttonMatrixAGenerate.Text = "Make Matrix A";
            this.buttonMatrixAGenerate.UseVisualStyleBackColor = true;
            this.buttonMatrixAGenerate.Click += new System.EventHandler(this.buttonMatrixAGenerate_Click);
            // 
            // buttonMatrixBGenerate
            // 
            this.buttonMatrixBGenerate.Location = new System.Drawing.Point(9, 256);
            this.buttonMatrixBGenerate.Name = "buttonMatrixBGenerate";
            this.buttonMatrixBGenerate.Size = new System.Drawing.Size(127, 23);
            this.buttonMatrixBGenerate.TabIndex = 1;
            this.buttonMatrixBGenerate.Text = "Make Matrix B";
            this.buttonMatrixBGenerate.UseVisualStyleBackColor = true;
            this.buttonMatrixBGenerate.Click += new System.EventHandler(this.buttonMatrixBGenerate_Click);
            // 
            // textBoxMatrixARows
            // 
            this.textBoxMatrixARows.Location = new System.Drawing.Point(142, 229);
            this.textBoxMatrixARows.Name = "textBoxMatrixARows";
            this.textBoxMatrixARows.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatrixARows.TabIndex = 2;
            this.textBoxMatrixARows.Text = "3";
            // 
            // textBoxMatrixBRows
            // 
            this.textBoxMatrixBRows.Location = new System.Drawing.Point(142, 259);
            this.textBoxMatrixBRows.Name = "textBoxMatrixBRows";
            this.textBoxMatrixBRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatrixBRows.TabIndex = 3;
            this.textBoxMatrixBRows.Text = "3";
            // 
            // textBoxMatrixAColumns
            // 
            this.textBoxMatrixAColumns.Location = new System.Drawing.Point(248, 230);
            this.textBoxMatrixAColumns.Name = "textBoxMatrixAColumns";
            this.textBoxMatrixAColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatrixAColumns.TabIndex = 4;
            this.textBoxMatrixAColumns.Text = "3";
            // 
            // textBoxMatrixBColumns
            // 
            this.textBoxMatrixBColumns.Location = new System.Drawing.Point(248, 258);
            this.textBoxMatrixBColumns.Name = "textBoxMatrixBColumns";
            this.textBoxMatrixBColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxMatrixBColumns.TabIndex = 5;
            this.textBoxMatrixBColumns.Text = "3";
            // 
            // textBoxMatrixADisplay
            // 
            this.textBoxMatrixADisplay.Location = new System.Drawing.Point(11, 28);
            this.textBoxMatrixADisplay.Multiline = true;
            this.textBoxMatrixADisplay.Name = "textBoxMatrixADisplay";
            this.textBoxMatrixADisplay.ReadOnly = true;
            this.textBoxMatrixADisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMatrixADisplay.Size = new System.Drawing.Size(175, 175);
            this.textBoxMatrixADisplay.TabIndex = 6;
            this.textBoxMatrixADisplay.WordWrap = false;
            // 
            // textBoxMatrixBDisplay
            // 
            this.textBoxMatrixBDisplay.Location = new System.Drawing.Point(192, 28);
            this.textBoxMatrixBDisplay.Multiline = true;
            this.textBoxMatrixBDisplay.Name = "textBoxMatrixBDisplay";
            this.textBoxMatrixBDisplay.ReadOnly = true;
            this.textBoxMatrixBDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMatrixBDisplay.Size = new System.Drawing.Size(175, 175);
            this.textBoxMatrixBDisplay.TabIndex = 7;
            this.textBoxMatrixBDisplay.WordWrap = false;
            // 
            // textBoxMatrixCDisplay
            // 
            this.textBoxMatrixCDisplay.Location = new System.Drawing.Point(373, 28);
            this.textBoxMatrixCDisplay.Multiline = true;
            this.textBoxMatrixCDisplay.Name = "textBoxMatrixCDisplay";
            this.textBoxMatrixCDisplay.ReadOnly = true;
            this.textBoxMatrixCDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMatrixCDisplay.Size = new System.Drawing.Size(175, 175);
            this.textBoxMatrixCDisplay.TabIndex = 8;
            this.textBoxMatrixCDisplay.WordWrap = false;
            // 
            // radioButtonMultiply
            // 
            this.radioButtonMultiply.AutoSize = true;
            this.radioButtonMultiply.Checked = true;
            this.radioButtonMultiply.Location = new System.Drawing.Point(19, 19);
            this.radioButtonMultiply.Name = "radioButtonMultiply";
            this.radioButtonMultiply.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMultiply.TabIndex = 9;
            this.radioButtonMultiply.TabStop = true;
            this.radioButtonMultiply.Text = "Multiply";
            this.radioButtonMultiply.UseVisualStyleBackColor = true;
            this.radioButtonMultiply.CheckedChanged += new System.EventHandler(this.radioButtonMultiply_CheckedChanged);
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(85, 19);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAddition.TabIndex = 10;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Add";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            this.radioButtonAddition.CheckedChanged += new System.EventHandler(this.radioButtonAddition_CheckedChanged);
            // 
            // radioButtonSubtraction
            // 
            this.radioButtonSubtraction.AutoSize = true;
            this.radioButtonSubtraction.Location = new System.Drawing.Point(135, 19);
            this.radioButtonSubtraction.Name = "radioButtonSubtraction";
            this.radioButtonSubtraction.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSubtraction.TabIndex = 11;
            this.radioButtonSubtraction.TabStop = true;
            this.radioButtonSubtraction.Text = "Subtract";
            this.radioButtonSubtraction.UseVisualStyleBackColor = true;
            this.radioButtonSubtraction.CheckedChanged += new System.EventHandler(this.radioButtonSubtraction_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(9, 343);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(85, 23);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonMatrixBIdentity
            // 
            this.buttonMatrixBIdentity.Location = new System.Drawing.Point(354, 257);
            this.buttonMatrixBIdentity.Name = "buttonMatrixBIdentity";
            this.buttonMatrixBIdentity.Size = new System.Drawing.Size(97, 23);
            this.buttonMatrixBIdentity.TabIndex = 13;
            this.buttonMatrixBIdentity.Text = "Make B Identity";
            this.buttonMatrixBIdentity.UseVisualStyleBackColor = true;
            this.buttonMatrixBIdentity.Click += new System.EventHandler(this.buttonMatrixBIdentity_Click);
            // 
            // buttonMatrixAllClear
            // 
            this.buttonMatrixAllClear.Location = new System.Drawing.Point(363, 343);
            this.buttonMatrixAllClear.Name = "buttonMatrixAllClear";
            this.buttonMatrixAllClear.Size = new System.Drawing.Size(104, 23);
            this.buttonMatrixAllClear.TabIndex = 14;
            this.buttonMatrixAllClear.Text = "Clear Matrices";
            this.buttonMatrixAllClear.UseVisualStyleBackColor = true;
            this.buttonMatrixAllClear.Click += new System.EventHandler(this.buttonMatrixAllClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(473, 343);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.radioButtonAddition);
            this.groupBoxOperations.Controls.Add(this.radioButtonSubtraction);
            this.groupBoxOperations.Controls.Add(this.radioButtonMultiply);
            this.groupBoxOperations.Location = new System.Drawing.Point(9, 285);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(211, 52);
            this.groupBoxOperations.TabIndex = 16;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Select Operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Matrix A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Matrix B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Matrix C";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(556, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMatrixAllClear);
            this.Controls.Add(this.buttonMatrixBIdentity);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxMatrixCDisplay);
            this.Controls.Add(this.textBoxMatrixBDisplay);
            this.Controls.Add(this.textBoxMatrixADisplay);
            this.Controls.Add(this.textBoxMatrixBColumns);
            this.Controls.Add(this.textBoxMatrixAColumns);
            this.Controls.Add(this.textBoxMatrixBRows);
            this.Controls.Add(this.textBoxMatrixARows);
            this.Controls.Add(this.buttonMatrixBGenerate);
            this.Controls.Add(this.buttonMatrixAGenerate);
            this.Controls.Add(this.groupBoxOperations);
            this.Name = "Form1";
            this.Text = "Matrix Ops";
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();



        }

        #endregion

        private System.Windows.Forms.Button buttonMatrixAGenerate;
        private System.Windows.Forms.Button buttonMatrixBGenerate;
        private System.Windows.Forms.TextBox textBoxMatrixARows;
        private System.Windows.Forms.TextBox textBoxMatrixBRows;
        private System.Windows.Forms.TextBox textBoxMatrixAColumns;
        private System.Windows.Forms.TextBox textBoxMatrixBColumns;
        private System.Windows.Forms.TextBox textBoxMatrixADisplay;
        private System.Windows.Forms.TextBox textBoxMatrixBDisplay;
        private System.Windows.Forms.TextBox textBoxMatrixCDisplay;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.RadioButton radioButtonSubtraction;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonMatrixBIdentity;
        private System.Windows.Forms.Button buttonMatrixAllClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

