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
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DB18UJA;Initial Catalog=Db_School;Integrated Security=True");
        void listvw()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Tbl_Clubs", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtClubs.DataSource = dt;
        }
        void clean()
        {
            txtID.Text = txtName.Text = ""; 
        }
        private void btnList_Click(object sender, EventArgs e)
        {
          listvw();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Clubs (clubName) values (@p1)", con);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adding new club successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listvw();
            clean();
        }

        private void dtClubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtClubs.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dtClubs.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You have not selected a club.","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Delete From Tbl_Clubs Where clubID=@p1", con);
            cmd2.Parameters.AddWithValue("@p1", txtID.Text);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Club deletion successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listvw();
            clean();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You have not selected a club.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Update Tbl_Clubs set clubName=@p1 Where clubID=@p2", con);
            cmd3.Parameters.AddWithValue("@p1", txtName.Text);
            cmd3.Parameters.AddWithValue("@p2", txtID.Text);
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Club update successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listvw();
            clean();
        }

        private void ClubForm_Load(object sender, EventArgs e)
        {
            listvw();
        }
    }
}
