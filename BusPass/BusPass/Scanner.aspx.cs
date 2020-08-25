using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Services;

namespace BusPass
{
    public partial class Scanner : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                //   string title = Request.Form["title"];
                SqlConnection con = new SqlConnection
                              (@"Data Source=DANNY;database=BUSPASSSYSTEMDatabase;Integrated Security=True");
                string qry = "insert into Photos (Name,QR_Code) values(@Name, @QR_Code)";
                SqlCommand cmd = new SqlCommand(qry, con);
                // create Parameters
                cmd.Parameters.AddWithValue("@Name", Request.Form["Name"]);
                SqlParameter photoParam = new SqlParameter("@QR_Code", SqlDbType.Image);
                String source = Request.Form["QR_Code"];
                // remove extra chars at the beginning
                source = source.Substring(source.IndexOf(",") + 1);
                Response.Write("source = " + source + "<br>");
                //converting the image into byte array
                byte[] data = Convert.FromBase64String(source);
                photoParam.Value = data;
                cmd.Parameters.Add(photoParam);

                //Open connection and execute insert query.
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message);
            }


        }
    }

    
}
