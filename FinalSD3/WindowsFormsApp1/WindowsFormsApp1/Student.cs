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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;
        private void fillDepartment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select DepName from DepartmentTb1", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(rdr);
            DepCv.ValueMember = "DepName";
            DepCv.DataSource = dt;
            con.Close();

        }
        private void populate()
        {
            con.Open();
            string query = "select * from  StudentTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            stdcv.DataSource = ds.Tables[0];
            con.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
         

       // }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
     
      
       // private void nodueavailable()
        //{
         //   con.Open();
          //  string query = "select * from  StudentTb1 where StdFees >" + 0 + "";
          //  SqlDataAdapter sda = new SqlDataAdapter(query, con);
           // SqlCommandBuilder builder = new SqlCommandBuilder(sda);
           // var ds = new DataSet();
           // sda.Fill(ds);
          // StdDataGV.DataSource = ds.Tables[0];
          //  con.Close();

       // }
        private void button4_Click(object sender, EventArgs e)
        {
            Interface interfac = new Interface();
            interfac.Show();
            this.Hide();
        }

        //private void guna2GradientButton5_Click(object sender, EventArgs e)
        //{
           // try
            //{
                //if (stdid.Text == "" || stdName.Text == "" || GenderCb.Text == "" || stdDateTime.Text == "" || stdPhone.Text == "" || DepCv.Text == "" || stdFees.Text == "")
               // {
                   // MessageBox.Show("Missing information");
               // }
               // else
                //{
                  //  con.Open();

                   // string query = "insert into StudentTb1 values('" + stdid.Text + "','" + stdName.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + stdDateTime.Text + "','" + stdPhone.Text + "','" + DepCv.SelectedValue.ToString() + "','" + stdFees.Text + "')";
                  //  SqlCommand cmd = new SqlCommand(query, con);
                  //  cmd.ExecuteNonQuery();
                  //  MessageBox.Show("Added");
                  //  con.Close();
                   // populate();
               // }

            //}
            //catch
            //{
              //  MessageBox.Show("somethig went missing");
           // }
       // }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Interface interfac = new Interface();
            interfac.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
               try
             {
              if (stdid1.Text == "" || stdName1.Text == "" || GenderCv.Text == "" || stdDate.Text == "" || stdphone1.Text == "" || DepCv.Text == "" || stdFees1.Text == "" )
               {
                 MessageBox.Show("Missing information");
               }
              else
              {
                con.Open();

               string query = "insert into StudentTb1 values('" + stdid1.Text + "','" + stdName1.Text + "','" + GenderCv.SelectedItem.ToString() + "','" + stdDate.Text + "','" + stdphone1.Text + "','" + DepCv.SelectedValue.ToString() + "','" + stdFees1.Text + "')";
               SqlCommand cmd = new SqlCommand(query, con);
               cmd.ExecuteNonQuery();
                 MessageBox.Show("Added");
               con.Close();
                populate();
            }

             }
              catch
             {
              MessageBox.Show("somethig went missing");
             }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
               try
              {

               if(stdid1.Text == "" || stdName1.Text == "" || GenderCv.Text == "" || stdDate.Text == "" || stdphone1.Text == "" || DepCv.Text == "" || stdFees1.Text == "" )
               
              {
              MessageBox.Show("Missing Data");
              }
              else
             {
                con.Open();
                string query = "update StudentTb1 set StdName ='" + stdName1.Text + "',StdGender ='" + GenderCv.SelectedItem.ToString() + "',StdDOB ='" + stdDate.Text + "',StdPhone ='" + stdphone1.Text + "', StdDep='"+DepCv.SelectedValue.ToString()+"',StdFees ='" +stdFees1.Text + "' where Stdid='" + stdid1.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
               MessageBox.Show("student updated successfully");
                con.Close();
               populate();

              }
              }
              catch
            {
               MessageBox.Show("Ops ..student not detected!");
             }
        }
        int counter = 0;
        int len = 0;
        string txt;
        private void Student_Load_1(object sender, EventArgs e)
        {
            populate();
            fillDepartment();
          
            txt = guna2HtmlLabel1.Text;
            len = txt.Length;
            guna2HtmlLabel1.Text = "";
            timer1.Start();
            
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (stdid1.Text == "")
                {
                    MessageBox.Show("Enter  id..");
                }
                else
                {
                    con.Open();
                    string query = "delete from StudentTb1 where Stdid ='" + stdid1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show(" student not detected");
            }
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            Interface interfac = new Interface();
            interfac.Show();
            this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                timer1.Stop();

            }
            else
            {
                guna2HtmlLabel1.Text = txt.Substring(0, counter);
            }
        }
    }
}
