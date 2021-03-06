﻿using System;
using System.Windows.Forms;

namespace CalculateLetterGrade {

    public partial class frmCalculateGrade : Form {

        public frmCalculateGrade() {
            InitializeComponent();

            AcceptButton = btnCalculate;
            CancelButton = btnExit;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            string letterGrade = "";

            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
