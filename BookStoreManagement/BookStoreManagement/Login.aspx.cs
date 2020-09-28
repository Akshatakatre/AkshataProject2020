using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BookStoreManagement
{
    public partial class Login : System.Web.UI.Page
    {
        public string Email_id { get; set; }
        public string Password { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cn = "data source=DANNY;integrated security=true;database=PracticeDatabase";
            SqlConnection con = new SqlConnection(cn);
            try
            {
                con.Open();
                string qr = "select count(*) from registration where Email_id='" + Email_id + "' and Password='" + Password + "'";
                SqlCommand command = new SqlCommand(qr, con);
       
                int r = Convert.ToInt32(command.ExecuteScalar());
                
            }
            catch (Exception ee)
            {
                
            }
            finally
            {
                con.Close();
            }



        }
    }
}