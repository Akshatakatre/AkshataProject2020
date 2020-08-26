using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string qr = "select count(*) from productTable";
                SqlCommand command = new SqlCommand(qr, con);
                int count = Convert.ToInt32(command.ExecuteScalar());
                label5.Text = "Total Records : " + count.ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }

        }
        SqlConnection con = new SqlConnection("data source=DANNY;integrated security=true;database=PracticeDatabase");
        private void button1_Click(object sender, EventArgs e)
        {
            //create an object of sqlconnection class for creating 
            //connection between this web page and sqlserver 
            //open the connection using open method of sqlconnection class
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pn = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "insert into productTable values(" + pid + ",'" + pn + "','" + cat + "')";
                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();
                label4.Text = "record saved ";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pn = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "update productTable set product_name='" + pn + "',category='" + cat + "' where product_id=" + pid + "";
                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();
                label4.Text = "record updated ";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pn = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "delete from productTable where product_id=" + pid + "";
                SqlCommand command = new SqlCommand(qr, con);
                command.ExecuteNonQuery();
                label4.Text = "record deleted";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int pid = Convert.ToInt32(textBox1.Text);
                string pn = textBox2.Text;
                string cat = textBox3.Text;
                string qr = "select * from productTable where product_id=" + pid + "";
                SqlCommand command = new SqlCommand(qr, con);
                SqlDataReader dr = command.ExecuteReader();
                int flag = 0;
                while (dr.Read())
                {
                    flag = 1;
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                }
                if (flag == 0)
                    label4.Text = "no record exist ";


            }
            catch (Exception ee)
            {
                label4.Text = ee.ToString();

            }
            finally
            {
                con.Close();
            }


        }
    }
}
