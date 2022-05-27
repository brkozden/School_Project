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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible=false;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Herhangi bir Değer Girmediniz.");
                return;
            }
            studentForm.num = txtNumber.Text;
            studentForm.Show();
            this.Hide();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtNumber.Select();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Herhangi bir Değer Girmediniz.");
                return;
            }
            teacherForm.num = txtNumber.Text;
            teacherForm.Show();
            this.Hide();


        }
    }
}
