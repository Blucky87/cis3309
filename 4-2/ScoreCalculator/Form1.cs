using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScoreCalculator {

    public partial class Form1 : Form {

        private readonly List<int> scoreList;
        private int scoreTotal;

        public Form1() {
            InitializeComponent();


            scoreList = new List<int>();
            scoreTotal = 0;

            AcceptButton = buttonAdd;
            CancelButton = buttonExit;

            UpdateTextBoxes();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            int score = int.Parse(textboxScore.Text);

            scoreList.Add(score);
            scoreTotal += score;

            UpdateTextBoxes();
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            scoreList.Clear();
            scoreTotal = 0;

            UpdateTextBoxes();
        }

        private void UpdateTextBoxes() {
            textboxScore.Text = "";
            textboxScore.Focus();

            textboxTotal.Text = scoreTotal.ToString();
            textboxCount.Text = scoreList.Count.ToString();
            textboxAverage.Text = scoreList.Count.Equals(0) ? "0" : (scoreTotal / scoreList.Count).ToString();
        }
    }
}