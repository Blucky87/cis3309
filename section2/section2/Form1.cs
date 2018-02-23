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
    public partial class FormStudentScores : Form
    {
        private BindingList<Student> studentList;

        public FormStudentScores()
        {
            InitializeComponent();


            loadStudents(new BindingList<Student>());
        }

        private void loadStudents(BindingList<Student> studentList)
        {
            this.studentList = studentList;
            listBoxStudents.DataSource = this.studentList;
        }



        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)listBoxStudents.SelectedItem;
            UpdateScoreStats(student);
        }

        private void UpdateScoreStats(Student student)
        {
            if (student == null)
            {
                clearScoreStats();
                return;
            }

            textBoxScoreTotal.Text = student.ScoreTotal.ToString();
            textBoxScoreAverage.Text = student.ScoreAverage.ToString();
            textBoxScoreCount.Text = student.ScoreList.Count.ToString();
        }

        private void clearScoreStats()
        {
            textBoxScoreTotal.Text = String.Empty;
            textBoxScoreAverage.Text = String.Empty;
            textBoxScoreCount.Text = String.Empty;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormAddStudent addStudent = new FormAddStudent();
            DialogResult result = addStudent.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    studentList.Add((Student)addStudent.Tag);
                    break;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Student student = (Student) listBoxStudents.SelectedItem;
            if (student == null) return;

            int index = listBoxStudents.SelectedIndex;
            FormUpdateStudent updateStudent = new FormUpdateStudent(student);
            DialogResult result = updateStudent.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    studentList.RemoveAt(index);
                    studentList.Insert(index,(Student)updateStudent.Tag);
                    break;
            }

        }
    }
}
