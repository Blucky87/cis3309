namespace ScoreCalculator
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textboxScore = new System.Windows.Forms.TextBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.textboxCount = new System.Windows.Forms.TextBox();
            this.textboxAverage = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.buttonDisplayScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(177, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(149, 148);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear Scores";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(177, 177);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textboxScore
            // 
            this.textboxScore.Location = new System.Drawing.Point(82, 31);
            this.textboxScore.Name = "textboxScore";
            this.textboxScore.Size = new System.Drawing.Size(75, 20);
            this.textboxScore.TabIndex = 4;
            // 
            // textboxTotal
            // 
            this.textboxTotal.Location = new System.Drawing.Point(82, 57);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.ReadOnly = true;
            this.textboxTotal.Size = new System.Drawing.Size(75, 20);
            this.textboxTotal.TabIndex = 5;
            // 
            // textboxCount
            // 
            this.textboxCount.Location = new System.Drawing.Point(82, 83);
            this.textboxCount.Name = "textboxCount";
            this.textboxCount.ReadOnly = true;
            this.textboxCount.Size = new System.Drawing.Size(75, 20);
            this.textboxCount.TabIndex = 6;
            // 
            // textboxAverage
            // 
            this.textboxAverage.Location = new System.Drawing.Point(82, 109);
            this.textboxAverage.Name = "textboxAverage";
            this.textboxAverage.ReadOnly = true;
            this.textboxAverage.Size = new System.Drawing.Size(75, 20);
            this.textboxAverage.TabIndex = 7;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(35, 34);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 60);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 13);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Score total:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(5, 86);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(68, 13);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Score count:";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(23, 112);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(50, 13);
            this.labelAverage.TabIndex = 11;
            this.labelAverage.Text = "Average:";
            // 
            // buttonDisplayScores
            // 
            this.buttonDisplayScores.Location = new System.Drawing.Point(8, 148);
            this.buttonDisplayScores.Name = "buttonDisplayScores";
            this.buttonDisplayScores.Size = new System.Drawing.Size(105, 23);
            this.buttonDisplayScores.TabIndex = 12;
            this.buttonDisplayScores.Text = "Display Scores";
            this.buttonDisplayScores.UseVisualStyleBackColor = true;
            this.buttonDisplayScores.Click += new System.EventHandler(this.buttonDisplayScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 215);
            this.Controls.Add(this.buttonDisplayScores);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textboxAverage);
            this.Controls.Add(this.textboxCount);
            this.Controls.Add(this.textboxTotal);
            this.Controls.Add(this.textboxScore);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textboxScore;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.TextBox textboxCount;
        private System.Windows.Forms.TextBox textboxAverage;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Button buttonDisplayScores;
    }
}

