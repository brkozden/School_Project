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
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotesTableAdapter ds = new DataSet1TableAdapters.Tbl_NotesTableAdapter();
      

        private void btnFind_Click(object sender, EventArgs e)
        {
            dtNotes.DataSource = ds.NoteList(int.Parse(txtID.Text));
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DB18UJA;Initial Catalog=Db_School;Integrated Security=True");
        private void NotesForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Lessons", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbxLessons.DisplayMember = "lessonName";
            cbbxLessons.ValueMember = "lessonID";
            cbbxLessons.DataSource = dt;
        }
        int noteid;
        private void dtNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noteid =Convert.ToInt32((dtNotes.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtID.Text = dtNotes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExam2.Text = dtNotes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtExam1.Text = dtNotes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtExam3.Text = dtNotes.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbbxLessons.Text = dtNotes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProject.Text = dtNotes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtStatus.Text = dtNotes.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        bool status1;
        private void btnCalculation_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3,project;
            double avg;
           
           

            exam1 = Convert.ToInt16(txtExam1.Text);
            exam2 = Convert.ToInt16(txtExam2.Text);
            exam3 = Convert.ToInt16(txtExam3.Text);
            project = Convert.ToInt16(txtProject.Text);
            avg = (exam1 + exam2 + exam3 + project) / 4;
            txtAverage.Text = avg.ToString();
            if (avg >= 50)
            {
                txtStatus.Text = "Passed";
                status1 = true;


            }
            if (avg <= 50)
            {
                txtStatus.Text = "Stayed";
                status1 = false;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // byte lessonid;
           // lessonid = Convert.ToByte(cbbxLessons.SelectedValue.ToString());
           //ds.UpdateQuery(lessonid,int.Parse(txtID.Text),byte.Parse(txtExam1.Text),byte.Parse(txtExam2.Text),byte.Parse(txtExam3.Text),byte.Parse(txtProject.Text),
           //   decimal.Parse(txtAverage.Text),status1,noteid);
           // dtNotes.DataSource = ds.NoteList(int.Parse(txtID.Text));
        }
    }
}
