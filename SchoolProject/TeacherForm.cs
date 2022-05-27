using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        public string num;
        private void button2_Click(object sender, EventArgs e)
        {
         ClubForm clubForm = new ClubForm();
            clubForm.Show();
        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LessonForm lessonForm = new LessonForm();
            lessonForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentForm2 studentForm2 = new StudentForm2();
            studentForm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm();
            notesForm.Show();
        }
    }
}
