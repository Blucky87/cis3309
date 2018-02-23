using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace section2
{
    public partial class FormUpdateStudent : Form
    {
        private BindingList<int> scoreList;

        public FormUpdateStudent(Student student)
        {
            InitializeComponent();
            scoreList = new BindingList<int>();

            student.ScoreList.ForEach(score => scoreList.Add(score));

            textBoxName.Text = student.Name;
            listBoxScores.DataSource = scoreList;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormScore score = new FormScore("Add");
            DialogResult result = score.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    scoreList.Add((int)score.Tag);
                    break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxScores.SelectedIndex;
            int selectedScore = (int) listBoxScores.SelectedItem;

            FormScore score = new FormScore("Update", selectedScore.ToString());
            DialogResult result = score.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    scoreList.RemoveAt(selectedIndex);
                    scoreList.Insert(selectedIndex, (int)score.Tag);
                    break;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Tag = new Student(textBoxName.Text, scoreList.Select(x => x).ToList());
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            scoreList.RemoveAt(listBoxScores.SelectedIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            scoreList.Clear();
        }
    }
}
