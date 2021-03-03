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

namespace WindowsFormsApp1
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;

        private void Home_Click(object sender, EventArgs e)
        {
            Login login = new Login();
             login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
             Department  Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Account Ac = new Account();
            Ac.Show();
            this.Hide();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

    

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Account Ac = new Account();
            Ac.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            Teacher teach = new Teacher();
            teach.Show();
            this.Hide();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*)from StudentTb1", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            stdlv.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*)from TeacherTb1", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Teacherlv.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*)from DepartmentTb1", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            Departmentlv.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*)from FeesTb1", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            Feeslv.Text = dt4.Rows[0][0].ToString();
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*)from UserTable", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            Userlv.Text = dt5.Rows[0][0].ToString();
            con.Close();
        }
    }
}
