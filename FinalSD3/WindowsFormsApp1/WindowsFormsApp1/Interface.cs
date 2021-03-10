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
           
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
         
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
          
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Interface_Load(object sender, EventArgs e)
        {

            //con.Open();
            //SqlDataAdapter sda1 = new SqlDataAdapter("select count(*)from StudentTb1", con);
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);
            //stdlv.Text = dt1.Rows[0][0].ToString();
            //SqlDataAdapter sda2 = new SqlDataAdapter("select count(*)from TeacherTb1", con);
            //DataTable dt2 = new DataTable();
            //sda2.Fill(dt2);
            //Teacherlv.Text = dt2.Rows[0][0].ToString();
            //SqlDataAdapter sda3 = new SqlDataAdapter("select count(*)from DepartmentTb1", con);
            //DataTable dt3 = new DataTable();
            //sda3.Fill(dt3);
            //Departmentlv.Text = dt3.Rows[0][0].ToString();
            //SqlDataAdapter sda4 = new SqlDataAdapter("select count(*)from FeesTb1", con);
            //DataTable dt4 = new DataTable();
            //sda4.Fill(dt4);
            //Feeslv.Text = dt4.Rows[0][0].ToString();
            //SqlDataAdapter sda5 = new SqlDataAdapter("select count(*)from UserTable", con);
            //DataTable dt5 = new DataTable();
            //sda5.Fill(dt5);
            //Userlv.Text = dt5.Rows[0][0].ToString();
            //con.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void Interface_Load_1(object sender, EventArgs e)
        {
            this.timer1.Start();
            Studentpanel.Visible = false;
            Teacherpanel.Visible = false;
            Departmentpanel.Visible = false;
            Paymentpanel.Visible = false;
            Userpanel.Visible = false;
            guna2GradientButton1.Visible = false;
            guna2GradientButton2.Visible = false;
            guna2GradientButton3.Visible = false;
            guna2GradientButton4.Visible = false;
            guna2GradientButton5.Visible = false;

            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*)from StudentTb1", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            stdlv.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*)from TeacherTb1", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
           teacherlv.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*)from DepartmentTb1", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            deplv.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*)from FeesTb1", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            paymentlv.Text = dt4.Rows[0][0].ToString();
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*)from UserTable", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            userlv.Text = dt5.Rows[0][0].ToString();
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
            if (progressBar1.Value >=20)
            {
                 
                Studentpanel.Visible = true;
                guna2GradientButton1.Visible = true;
             

            }
            if (progressBar1.Value >= 40)
            {
                Teacherpanel.Visible = true;
                guna2GradientButton2.Visible = true;
               
            }
            if(progressBar1.Value>=60)
            {
                Departmentpanel.Visible = true;
                guna2GradientButton3.Visible = true;
             

            }
            if (progressBar1.Value >= 80)
            {
           
                Paymentpanel.Visible = true;
                guna2GradientButton4.Visible = true;
              


            }
            if (progressBar1.Value >= 100)
            {
               
                Userpanel.Visible = true;
                guna2GradientButton5.Visible = true;
                progressBar1.Visible = false;
            }


        }

        private void guna2GradientButton1_Click_2(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click_2(object sender, EventArgs e)
        {
            Teacher teach = new Teacher();
            teach.Show();
            this.Hide();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            Department Dep = new Department();
            Dep.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            Account Ac = new Account();
            Ac.Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deplv_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Teacherpanel_Paint(object sender, PaintEventArgs e)
        {
            this.BringToFront();
        }
    }
}
