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

namespace StudentGradingSystem
{
    public partial class StudentInformationLogin : Form
    {
        public StudentInformationLogin()
        {
            InitializeComponent();
        }
        private void login_bttn_Click(object sender, EventArgs e)
        {
            StudentInformation fr = new StudentInformation();
            fr.num = studentno_box.Text;
            this.Hide();
            fr.Show();
        }
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teacher_login_Click(object sender, EventArgs e)
        {
            TeacherOperations fr = new TeacherOperations();
            fr.num = teacher_box.Text;
            this.Hide();
            fr.Show();
        }
    }
}
