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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;

        private void populate()
        {
            con.Open();
            string query = "select * from  UserTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDataGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserId.Text==""|| UserName.Text== "" || UserPassword.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();

                    string query = "insert into UserTable values('"+UserId.Text+"','" + UserName.Text + "','" + UserPassword.Text + "')";
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
        int counter = 0;
        int len = 0;
        string txt;

        private void User_Load(object sender, EventArgs e)
        {
            populate();
            txt = label4.Text;
            len = txt.Length;
            label4.Text = "";
            timer1.Start();
        }

        private void UserDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId.Text = UserDataGV.SelectedRows[0].Cells[1].Value.ToString();
            UserName.Text = UserDataGV.SelectedRows[0].Cells[2].Value.ToString();
            UserPassword.Text = UserDataGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if(UserId.Text=="")
                {
                    MessageBox.Show("Enter user id");
                }
               else{
                    con.Open();
                    string query = "delete from UserTable where UserId="+UserId.Text+";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("User not detected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (UserId.Text == "" || UserName.Text == "" || UserPassword.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    string query = "update UserTable set UserName ='"+UserName.Text+"',UserPassword ='"+UserPassword.Text+"' where UserId=" + UserId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("User not detected");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Login Form = new Login();
            Form.Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserId.Text == "" || UserName.Text == "" || UserPassword.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();

                    string query = "insert into UserTable values('" + UserId.Text + "','" + UserName.Text + "','" + UserPassword.Text + "')";
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

                if (UserId.Text == "" || UserName.Text == "" || UserPassword.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    string query = "update UserTable set UserName ='" + UserName.Text + "',UserPassword ='" + UserPassword.Text + "' where UserId=" + UserId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("User not detected");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (UserId.Text == "")
                {
                    MessageBox.Show("Enter user id");
                }
                else
                {
                    con.Open();
                    string query = "delete from UserTable where UserId=" + UserId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("User not detected");
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.Hide();
        }

        private void UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                timer1.Stop();

            }
            else
            {
                label4.Text = txt.Substring(0, counter);
            }
        }
    }
    }

