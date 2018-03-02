namespace section2
{
    partial class FormStudentScores
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxScoreTotal = new System.Windows.Forms.TextBox();
            this.textBoxScoreCount = new System.Windows.Forms.TextBox();
            this.textBoxScoreAverage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.HorizontalScrollbar = true;
            this.listBoxStudents.ItemHeight = 25;
            this.listBoxStudents.Location = new System.Drawing.Point(24, 71);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(394, 279);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students:";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(434, 71);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(180, 44);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Add New...";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(434, 146);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(180, 44);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update...";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(434, 223);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(180, 44);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(464, 462);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 44);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxScoreTotal
            // 
            this.textBoxScoreTotal.Location = new System.Drawing.Point(342, 367);
            this.textBoxScoreTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxScoreTotal.Name = "textBoxScoreTotal";
            this.textBoxScoreTotal.ReadOnly = true;
            this.textBoxScoreTotal.Size = new System.Drawing.Size(76, 31);
            this.textBoxScoreTotal.TabIndex = 6;
            // 
            // textBoxScoreCount
            // 
            this.textBoxScoreCount.Location = new System.Drawing.Point(342, 417);
            this.textBoxScoreCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxScoreCount.Name = "textBoxScoreCount";
            this.textBoxScoreCount.ReadOnly = true;
            this.textBoxScoreCount.Size = new System.Drawing.Size(76, 31);
            this.textBoxScoreCount.TabIndex = 7;
            // 
            // textBoxScoreAverage
            // 
            this.textBoxScoreAverage.Location = new System.Drawing.Point(342, 467);
            this.textBoxScoreAverage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxScoreAverage.Name = "textBoxScoreAverage";
            this.textBoxScoreAverage.ReadOnly = true;
            this.textBoxScoreAverage.Size = new System.Drawing.Size(76, 31);
            this.textBoxScoreAverage.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average:";
            // 
            // FormStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(632, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxScoreAverage);
            this.Controls.Add(this.textBoxScoreCount);
            this.Controls.Add(this.textBoxScoreTotal);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudents);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormStudentScores";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxScoreTotal;
        private System.Windows.Forms.TextBox textBoxScoreCount;
        private System.Windows.Forms.TextBox textBoxScoreAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

