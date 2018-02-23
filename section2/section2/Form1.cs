using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace section2
{
    public partial class FormStudentScores : Form
    {
        //holds the students in the program
        private BindingList<Student> studentList;

        public FormStudentScores()
        {
            InitializeComponent();

            //sets the initial students
            loadStudents(new BindingList<Student>());
        }

        private void loadStudents(BindingList<Student> studentList)
        {
            //set the student list
            this.studentList = studentList;
            //set the student listbox's datasource
            listBoxStudents.DataSource = this.studentList;
        }

        //event when item selected in listbox changes
        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if no selected item return
            if(listBoxStudents.SelectedIndex == -1 ) return;
            //create a student from the selected index in the listbox
            Student student = studentList[listBoxStudents.SelectedIndex];
            //update the scores
            UpdateScoreStats(student);
        }

        //updates the 3 score stats 
        private void UpdateScoreStats(Student student)
        {
            //if no student clear data
            if (student == null)
            {
                clearScoreStats();
                return;
            }

            //sets the textbox text to approptiate student fields
            textBoxScoreTotal.Text = student.ScoreTotal.ToString();
            textBoxScoreAverage.Text = student.ScoreAverage.ToString();
            textBoxScoreCount.Text = student.ScoreList.Count.ToString();
        }

        //clear score stats
        private void clearScoreStats()
        {
            //sets score stats textbox texts as empty strings
            textBoxScoreTotal.Text = String.Empty;
            textBoxScoreAverage.Text = String.Empty;
            textBoxScoreCount.Text = String.Empty;
        }

        //event when add is clicked
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //create add student form
            FormAddStudent addStudent = new FormAddStudent();
            //display form
            DialogResult result = addStudent.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    //add new student to studentList
                    studentList.Add((Student)addStudent.Tag);
                    //select the new student
                    selectStudent((Student)addStudent.Tag);
                    break;
            }

        }

        //event when update clicked
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Student student = (Student) listBoxStudents.SelectedItem;
            //if no student, return
            if (student == null) return;

            //get listbox selected item index
            int index = listBoxStudents.SelectedIndex;

            //create new update student form
            FormUpdateStudent updateStudent = new FormUpdateStudent(student);
            //display form
            DialogResult result = updateStudent.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    //remove old student entry
                    studentList.RemoveAt(index);
                    //add new updated student entry at old position
                    studentList.Insert(index,(Student) updateStudent.Tag);
                    //select the new student
                    selectStudent((Student)updateStudent.Tag);
                    break;
            }
        }

        //select a student
        private void selectStudent(Student student)
        {
            //check if student exists
            if (student != null)
            {
                //update the 3 score stats
                UpdateScoreStats(student);
                //have the student highlighted in the listbox
                listBoxStudents.SelectedIndex = studentList.IndexOf(student);
            }
        }

        //event when delete is clicked
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //check if a valid index was selected
            if(listBoxStudents.SelectedIndex != -1)
                //remove the student at the selected index
                studentList.RemoveAt(listBoxStudents.SelectedIndex);

            if (studentList.Count == 0)
                clearScoreStats();
        }
    }
}
