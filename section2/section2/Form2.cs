using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace section2
{
    public partial class FormAddStudent : Form
    {
        private List<int> scoreList;

        public FormAddStudent()
        {
            InitializeComponent();
            scoreList = new List<int>();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                Tag = new Student(textBoxName.Text, scoreList);
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            int score = 0;
            bool isValidScore = Int32.TryParse(textBoxScore.Text, out score);

            if (isValidScore && score >= 0 && score <= 100)
            {
                AddScore(score);
            }
            else
            {
                MessageBox.Show("Score must be an integer between 0 and 100", "Warning");
            }
        }

        private void AddScore(int score)
        {
            scoreList.Add(score);
            textBoxScores.Text += String.Format("{0} ",score);
        }

        private void buttonClearScores_Click(object sender, EventArgs e)
        {
            clearScores();
        }

        private void clearScores()
        {
            scoreList = new List<int>();
            textBoxScores.Text = String.Empty;
        }
    }
}
