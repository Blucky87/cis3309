using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace section2
{
    public partial class FormAddStudent : Form
    {
        //holds all the scores for the new student
        private List<int> scoreList;

        public FormAddStudent()
        {
            InitializeComponent();
            //initialize the scorelist
            scoreList = new List<int>();
        }

        //event when you click the OK button
        private void buttonOK_Click(object sender, EventArgs e)
        {
            //ensure there is a name
            if (textBoxName.Text != "")
            {
                //create a new student object based off the name textbox and the scorelist
                Tag = new Student(textBoxName.Text, scoreList);
                DialogResult = DialogResult.OK;
                Dispose();
            }
            else
            {
                //display error
                MessageBox.Show("Student must have a name", "Warning");
            }
        }

        //event when add button is clicked
        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            int score = 0;
            //try to see if textbox with score has valid integer
            bool isValidScore = Int32.TryParse(textBoxScore.Text, out score);

            //check if the score entered is valid
            if (isValidScore && score >= 0 && score <= 100)
            {
                //add schore to scorelist
                AddScore(score);
            }
            else
            {
                //display error message
                MessageBox.Show("Score must be an integer between 0 and 100", "Warning");
            }
        }

        //helps format score text
        private void AddScore(int score)
        {
            //add new score to scoreList
            scoreList.Add(score);
            //update the scores textbox with new string
            textBoxScores.Text += String.Format("{0} ",score);
            //set score textbox as empty
            textBoxScore.Text = String.Empty;
            //set focus on score textbox
            textBoxScore.Focus();
        }

        //event when clear clicked
        private void buttonClearScores_Click(object sender, EventArgs e)
        {
            //clear the scores
            clearScores();
        }

        private void clearScores()
        {
            //clears the scorelist
            scoreList.Clear();
            //sets the scores textbox as empty;
            textBoxScores.Text = String.Empty;
        }
    }
}
