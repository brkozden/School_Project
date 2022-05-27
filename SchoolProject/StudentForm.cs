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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DB18UJA;Initial Catalog=Db_School;Integrated Security=True");
        public string num;
        private void StudentForm_Load(object sender, EventArgs e)
        {
            lblStudentNumber2.Text = num.ToString();
            SqlCommand cmd = new SqlCommand("select lessonName,exam1,exam2,exam3,project,avg from Tbl_Notes inner join Tbl_Lessons on Tbl_Notes.lessonID=Tbl_Lessons.lessonID Where studentID=@p1", con);
            cmd.Parameters.AddWithValue("@p1",num.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("Select studentName,studentSurname From Tbl_Students Where studentID=@p1",con);
            con.Open();
            cmd2.Parameters.AddWithValue("@p1",num);
            SqlDataReader dr = cmd2.ExecuteReader();
            
            dr.Read();
            string nameSurname = dr[0].ToString() +" "+ dr[1].ToString();
            lblNameSurname.Text = nameSurname;
            con.Close();

        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
