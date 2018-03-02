
using System;
using System.Windows.Forms;

namespace section2
{
    public partial class FormScore : Form
    {
        //constructor to allow reuse of the dialog form
        public FormScore(string action)
        {
            InitializeComponent();
            //set the button and form text to the action string set in constructor
            buttonConfirm.Text = action;
            Text = action + " Score";
        }

        public FormScore(string action, string current)
        {
            InitializeComponent();
            //set the button and form text tot athe action string set in the constructor
            buttonConfirm.Text = action;
            Text = action + " Score";
            //set the textbox to the current value passed in the constructor
            textBoxScore.Text = current;
        }

        private void buttonConfirm_Click(object sender, System.EventArgs e)
        {
            int score = 0;
            //check if the textbox has a valid score
            if(Int32.TryParse(textBoxScore.Text, out score) && score >= 0 && score <= 100)
            {
                //set the form tag to the valid score
                Tag = score;
                DialogResult = DialogResult.OK;
                Dispose();
            }
            else
            {
                //show message box about input error
                MessageBox.Show("Score must be an integer between 0 and 100", "Warning");
            }
        }
    }
}
