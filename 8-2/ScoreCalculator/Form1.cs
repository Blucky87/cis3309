using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        private List<int> scoreList;

        public Form1()
        {
            InitializeComponent();
            
            scoreList = new List<int>();

            AcceptButton = buttonAdd;
            CancelButton = buttonExit;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int score;

            try
            {
                bool validScore = int.TryParse(textboxScore.Text, out score);

                if (validScore)
                {
                    scoreList.Add(score);
                }
                else
                {
                    MessageBox.Show("Invalid Score Entry", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }

            UpdateTextBoxes();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            scoreList = new List<int>();

            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            int scoreCount = scoreList.Count;
            int scoreTotal = scoreList.Aggregate(0, (cScore, nScore) => cScore + nScore);
            double scoreAverage = scoreCount != 0 ? scoreList.Average() : 0;

            textboxScore.Text = "";
            textboxScore.Focus();

            textboxAverage.Text = scoreAverage.ToString();
            textboxCount.Text = scoreCount.ToString();
            textboxTotal.Text = scoreTotal.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDisplayScores_Click(object sender, EventArgs e)
        {
            string scoreString = scoreList.OrderBy(score => score)
                .Aggregate("", (cScore, nScore) => cScore + (nScore.ToString() + "\n"));
                
            MessageBox.Show(scoreString, "Sorted Scores");
            textboxScore.Focus();
        }
    }
}