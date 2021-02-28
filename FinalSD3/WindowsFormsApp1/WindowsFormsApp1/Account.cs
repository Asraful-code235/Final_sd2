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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASRAFUL;Initial Catalog=Sd2;Integrated Security=True");
        SqlCommand cmd;
        private void populate()
        {
            con.Open();
            string query = "select * from  FeesTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void stdidhere()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select stdid from studentTb1", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("stdid", typeof(int));
            dt.Load(rdr);
            stdidshow.ValueMember = "stdid";
            stdidshow.DataSource = dt;
            con.Close();

        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface interfa = new Interface();
             interfa.Show();
               this.Hide();
        }

        private void PaymentDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int counter = 0;
        int len = 0;
        string txt;

        private void Account_Load(object sender, EventArgs e)
        {
            
            populate();
            stdidhere();
            txt = label6.Text;
            len = txt.Length;
            label6.Text = "";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                label6.Text = txt.Substring(0, counter);
            }
        }
     

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Interface interfa = new Interface();
            interfa.Show();
            this.Hide();
        }
        private void updated()
        {
            con.Open();
            string query = "update StudentTb1 set StdFees ='" + AmountTb.Text + "' where Stdid=" + stdidshow.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
         
            con.Close();
        }
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (num.Text == "" || stdidshow.Text == "" || stdName.Text == "" || pdate.Text == "" || AmountTb.Text == "" )
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    string date = pdate.Value.Year.ToString();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from FeesTb1 where Stdid="+stdidshow.SelectedValue.ToString()+" and Period='"+date+"'",con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows[0][0].ToString() =="1")
                    {
                        MessageBox.Show("This student has paid.");
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        string query = "insert into FeesTb1 values('" + num.Text + "','" + stdidshow.SelectedValue.ToString() + "','" + stdName.Text + "','" + date + "','" + AmountTb.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added");
                        con.Close();
                        populate();
                        updated();
                    }
                   
                }

            }
            catch
            {
                MessageBox.Show("somethig went missing");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void stdidshow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from StudentTb1 where Stdid=" + stdidshow.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                stdName.Text = dr["stdName"].ToString();
            }

            con.Close();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            //nodueavailable();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
