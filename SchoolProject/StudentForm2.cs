using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolProject
{
    public partial class StudentForm2 : Form
    {
        public StudentForm2()
        {
            InitializeComponent();
        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DB18UJA;Initial Catalog=Db_School;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void StudentForm2_Load(object sender, EventArgs e)
        {
            dtStudent.DataSource = ds.StudentList();
            gender = "Boy";
         
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Clubs",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbxClub.DisplayMember = "clubName";
            cbbxClub.ValueMember = "clubID";
            cbbxClub.DataSource = dt;


        }
        string gender;
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
           
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text) )
            {
                MessageBox.Show("Name and Surname Cannot Be Empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ds.InsertQuery(txtName.Text, txtSurname.Text, clubValue ,gender);
            MessageBox.Show("Add Student Successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtStudent.DataSource = ds.StudentList();
            clean();
        }

        private void rbtnBoy_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Boy";
        }

        private void rbtnGirl_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Girl";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dtStudent.DataSource = ds.StudentList();
        }
        byte clubValue;
        private void cbbxClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubValue = Convert.ToByte(cbbxClub.SelectedValue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You have not selected a student to delete","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ds.DeleteQuery(Convert.ToInt16(txtID.Text));
            MessageBox.Show("Delete Student Successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtStudent.DataSource = ds.StudentList();
            clean();
        }

        private void dtStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            if (gender == "Boy")
            {
                rbtnBoy.Checked = true;

            }
            if (gender == "Girl")
            {
                rbtnGirl.Checked = true;

            }

        }
        void clean()
        {
            txtID.Text = txtName.Text = txtSurname.Text = "";
            rbtnBoy.Checked = true;
            cbbxClub.SelectedIndex = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You have not selected a student to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ds.UpdateQuery(txtName.Text, txtSurname.Text, clubValue, gender,Convert.ToInt16(txtID.Text));
            MessageBox.Show("Update Student Successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtStudent.DataSource = ds.StudentList();
            clean();

        }

        private void StudentForm2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           dtStudent.DataSource = ds.searchStudent('%'+txtSearch.Text+'%');
        }
    }
}
