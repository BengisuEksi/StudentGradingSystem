using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentGradingSystem
{
    public partial class TeacherOperations : Form
    {
        public TeacherOperations()
        {
            InitializeComponent();
        }
       
        public string num;
        private const string Format = "F2";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBGradeSystem;Integrated Security=True");
        private void TeacherOperations_Load(object sender, EventArgs e)
        {
            teacher_number.Text = num;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select TeacherName,TeacherSurname from Tbl_Teacher where TeacherNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", teacher_number.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                teacher_name.Text = dr[0].ToString() + " " + dr[1].ToString();
            }
            conn.Close();
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            string status;
            double e1, e2, e3;
            e1 = Convert.ToDouble(exam1_box.Text);
            e2 = Convert.ToDouble(exam2_box.Text);
            e3 = Convert.ToDouble(exam3_box.Text);
            double avg = (double)(e1 + e2 + e3) / 3;
            avg_lbl.Text = avg.ToString(Format);
            if (avg >= 50)
            {
                status = "True";
                status_lbl.Text = "Passed.";
            }
            else
            {
                status = "False";
                status_lbl.Text = "Failed.";
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_StudentGrades (StNumber,StName,StSurname,StE1,StE2,StE3,StAvg,StStatus) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);
            cmd.Parameters.AddWithValue("@p1", number_box.Text);
            cmd.Parameters.AddWithValue("@p2", name_box.Text);
            cmd.Parameters.AddWithValue("@p3",surname_box.Text);
            cmd.Parameters.AddWithValue("@p4",exam1_box.Text);
            cmd.Parameters.AddWithValue("@p5",exam2_box.Text);
            cmd.Parameters.AddWithValue("@p6",exam3_box.Text);
            cmd.Parameters.AddWithValue("@p7",decimal.Parse(avg_lbl.Text));
            cmd.Parameters.AddWithValue("@p8",status);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New student is added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //list();
        }

        private void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_StudentGrades", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nm = dataGridView1.SelectedCells[0].RowIndex;
            number_box.Text = dataGridView1.Rows[nm].Cells[1].Value.ToString();
            name_box.Text = dataGridView1.Rows[nm].Cells[2].Value.ToString();
            surname_box.Text = dataGridView1.Rows[nm].Cells[3].Value.ToString();
            exam1_box.Text = dataGridView1.Rows[nm].Cells[4].Value.ToString();
            exam2_box.Text = dataGridView1.Rows[nm].Cells[5].Value.ToString();
            exam3_box.Text = dataGridView1.Rows[nm].Cells[6].Value.ToString();
            double e1, e2, e3;
            string status;
            e1 = Convert.ToDouble(exam1_box.Text);
            e2 = Convert.ToDouble(exam2_box.Text);
            e3 = Convert.ToDouble(exam3_box.Text);
            double avg = (double)(e1 + e2 + e3) / 3;
            avg_lbl.Text = avg.ToString(Format);
            if (avg >= 50)
            {
                status = "Passed.";
            }
            else
            {
                status = "Failed.";
            }
            status_lbl.Text = status.ToString();
        }
        private double avg_calculation(double e1, double e2, double e3)
        {
            double average = (double)(e1 + e2 + e3) / 3;
            return average;
        }
        private void update_bttn_Click(object sender, EventArgs e)
        {
            string status;
            double e1, e2, e3;
            e1 = Convert.ToDouble(exam1_box.Text);
            e2 = Convert.ToDouble(exam2_box.Text);
            e3 = Convert.ToDouble(exam3_box.Text);
            double average = avg_calculation(e1, e2, e3);
            avg_lbl.Text = average.ToString(Format);
            if(average >= 50)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_StudentGrades set StE1=@p1,StE2=@p2,StE3=@p3,StAvg=@p4,StStatus=@p5 where StNumber=@p6", conn);
            cmd.Parameters.AddWithValue("@p1",exam1_box.Text);
            cmd.Parameters.AddWithValue("@p2", exam2_box.Text);
            cmd.Parameters.AddWithValue("@p3", exam3_box.Text);
            cmd.Parameters.AddWithValue("@p4",decimal.Parse(avg_lbl.Text));
            cmd.Parameters.AddWithValue("@p5",status);
            cmd.Parameters.AddWithValue("@p6", number_box.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Information is updated.", "Grades Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_out_bttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StudentInformationLogin fr = new StudentInformationLogin();
                this.Hide();
                fr.Show();
            }
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            number_box.Text = "";
            name_box.Text = "";
            surname_box.Text = "";
            exam1_box.Text = "";
            exam2_box.Text = "";
            exam3_box.Text = "";
            avg_lbl.Text = "0";
            status_lbl.Text = "";
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_StudentGrades where StNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", number_box.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data is deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void list_bttn_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBGradeSystemDataSet.Tbl_StudentGrades' table. You can move, or remove it, as needed.
            this.tbl_StudentGradesTableAdapter.Fill(this.dBGradeSystemDataSet.Tbl_StudentGrades);
            pass_lbl.Text = dBGradeSystemDataSet.Tbl_StudentGrades.Count(x => x.StStatus == true).ToString();
            fail_lbl.Text = dBGradeSystemDataSet.Tbl_StudentGrades.Count(y => y.StStatus == false).ToString();
        }
    }
}
