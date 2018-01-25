using System;
using System.Linq;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        private int[] scoreArray;
        private int scoreCount;
        private int scoreTotal;

        public Form1()
        {
            InitializeComponent();

            scoreArray = new int[50];
            scoreTotal = 0;
            scoreCount = 0;

            AcceptButton = buttonAdd;
            CancelButton = buttonExit;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int score = 0;

            try
            {
                bool validScore = int.TryParse(textboxScore.Text, out score);

                if (validScore)
                {
                    scoreArray[scoreCount] = score;
                    scoreCount += 1;
                    scoreTotal += score;
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
            scoreArray = new int[50];
            scoreTotal = 0;
            scoreCount = 0;

            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            textboxScore.Text = "";
            textboxScore.Focus();

            textboxTotal.Text = scoreTotal.ToString();
            textboxCount.Text = scoreCount.ToString();

            textboxAverage.Text = scoreCount != 0 ? (scoreTotal / scoreCount).ToString() : "0";
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
            string scoreString = scoreArray.Take(scoreCount)
                .OrderBy(score => score)
                .Aggregate("", (cScore, nScore) => cScore + (nScore.ToString() + "\n"));
                

            MessageBox.Show(scoreString, "Sorted Scores");
            textboxScore.Focus();
        }
    }
}