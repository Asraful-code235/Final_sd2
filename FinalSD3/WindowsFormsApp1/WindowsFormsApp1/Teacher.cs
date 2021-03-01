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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;
        private void Department()
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
            string query = "select * from  TeacherTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            tDataGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tid.Text == "" || Tname.Text == "" || GenderCb.Text == "" || tDateTime.Text == "" || tphone.Text == "" || DepCv.Text == "" || Taddress.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();

                    string query = "insert into TeacherTb1 values('" + Tid.Text + "','" + Tname.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + tDateTime.Text + "','" + tphone.Text + "','" + DepCv.SelectedValue.ToString() + "','" +Taddress.Text + "')";
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

        private void Teacher_Load(object sender, EventArgs e)
        {
            Department();
            populate();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Interface interfac = new Interface();
            interfac.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Tid.Text == "" || Tname.Text == "" || GenderCb.Text == "" || tDateTime.Text == "" || tphone.Text == "" || DepCv.Text == "" || Taddress.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    string query = "update TeacherTb1 set TeacherName ='" + Tname.Text + "',TeacherGender ='" + GenderCb.SelectedItem.ToString() + "',teacherDOB ='" + tDateTime.Text + "',TeacherPhone ='" + tphone.Text + "',TeacherAddress ='" + Taddress.Text + "', TeacherDep='" + DepCv.SelectedValue.ToString() + "' where TeacherId='" + Tid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated successfully");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("Ops ..Teacher not detected!");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (Tid.Text == "")
                {
                    MessageBox.Show("Enter Teachers id..");
                }
                else
                {
                    con.Open();
                    string query = "delete from TeacherTb1 where TeacherId ='" +Tid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show(" Teacher not detected");
            }
        }
    }
}
