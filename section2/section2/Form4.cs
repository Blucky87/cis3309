
using System;
using System.Windows.Forms;

namespace section2
{
    public partial class FormScore : Form
    {
        public FormScore(string action)
        {
            InitializeComponent();
            buttonConfirm.Text = action;
            Text = action + " Score";
        }

        public FormScore(string action, string current)
        {
            InitializeComponent();
            buttonConfirm.Text = action;
            textBoxScore.Text = current;
            Text = action + " Score";
        }

        private void buttonConfirm_Click(object sender, System.EventArgs e)
        {
            int score = 0;
            if(Int32.TryParse(textBoxScore.Text, out score) && score >= 0 && score <= 100)
            {
                Tag = score;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Score must be an integer between 0 and 100", "Warning");
            }
        }
    }
}
