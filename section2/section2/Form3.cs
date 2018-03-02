using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace section2
{
    public partial class FormUpdateStudent : Form
    {
        //holds list of scores for student displayed in listbox
        private BindingList<int> scoreList;

        //constructor to update a specific student
        public FormUpdateStudent(Student student)
        {
            InitializeComponent();
            //initialize the list
            scoreList = new BindingList<int>();

            //add each score held by the student into the scorelist for listbox display
            student.ScoreList.ForEach(score => scoreList.Add(score));

            //set the textbox to display the student's name
            textBoxName.Text = student.Name;
            //bind the listbox datasource to the scorelist
            listBoxScores.DataSource = scoreList;
        }

        //event when the add button is clicked
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //create a form with action "Add"
            FormScore score = new FormScore("Add");
            //display the form
            DialogResult result = score.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    //add the score from the dialog form to the scorelist
                    scoreList.Add((int)score.Tag);
                    break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //get listbox's selected item's index
            int selectedIndex = listBoxScores.SelectedIndex;

            //if there is an invalid index selected, return
            if(selectedIndex == -1) return;

            //get the score to update
            int selectedScore = (int) listBoxScores.SelectedItem;

            //create a form with action "Update" and the current score to be updated prefilled
            FormScore score = new FormScore("Update", selectedScore.ToString());
            //show dialog
            DialogResult result = score.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    //remove the old score
                    scoreList.RemoveAt(selectedIndex);
                    //put new score where the old one was in scorelist
                    scoreList.Insert(selectedIndex, (int)score.Tag);
                    break;
            }
        }

        //event when clicking the ok button
        private void buttonOK_Click(object sender, EventArgs e)
        {
            //create a new student using the scorelist and save it in the tag
            Tag = new Student(textBoxName.Text, scoreList.Select(x => x).ToList());
            DialogResult = DialogResult.OK;
            Dispose();
        }

        //event when the cancel button is clicked
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //cancel out of form
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        //event for when remove button is clicked
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //remove the selected score at selected index
            scoreList.RemoveAt(listBoxScores.SelectedIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //remove all elements from the scorelist
            scoreList.Clear();
        }

        private void listBoxScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
