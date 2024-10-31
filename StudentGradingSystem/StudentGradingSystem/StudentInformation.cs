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

namespace StudentGradingSystem
{
    public partial class StudentInformation : Form
    {
        public StudentInformation()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBGradeSystem;Integrated Security=True");
        public string num;
        private void StudentInformation_Load(object sender, EventArgs e)
        {
            number_lbl.Text = num;

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_StudentGrades where StNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1",number_lbl.Text);
            SqlDataReader dr = cmd.ExecuteReader();
               
            while (dr.Read())
            {
                name_srname_lbl.Text = dr[2].ToString() + " " + dr[3].ToString();
                exam1_lbl.Text = dr[4].ToString();
                exam2_lbl.Text = dr[5].ToString();
                exam3_lbl.Text = dr[6].ToString();
                avg_lbl.Text = dr[7].ToString();

                bool state = Convert.ToBoolean(dr[8]);
                if (state)
                {
                    status_lbl.Text = "Passed";
                }
                else
                {
                    status_lbl.Text = "Failed";
                }
            }
            conn.Close();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_out_bttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to sign out?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                StudentInformationLogin fr = new StudentInformationLogin();
                this.Hide();
                fr.Show();
            }
        }
    }
}
