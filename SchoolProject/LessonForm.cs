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
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_LessonsTableAdapter ds = new DataSet1TableAdapters.Tbl_LessonsTableAdapter();
        private void btnList_Click(object sender, EventArgs e)
        {
          
            dtLesson.DataSource = ds.LessonList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You entered an empty value", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            ds.UpdateQuery(txtName.Text,Convert.ToByte(txtID.Text));
            MessageBox.Show("Update lesson successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtLesson.DataSource = ds.LessonList();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
            dtLesson.DataSource = ds.LessonList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You entered an empty value","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            ds.InsertQuery(txtName.Text);
            MessageBox.Show("Adding lesson successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtLesson.DataSource = ds.LessonList();
        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You entered an empty value", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            ds.DeleteQuery(Convert.ToByte(txtID.Text));
            MessageBox.Show("Adding lesson successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtLesson.DataSource = ds.LessonList();
           
        }

        private void dtLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtLesson.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dtLesson.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
