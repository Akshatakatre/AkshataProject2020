using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BusPass
{
    public partial class ScannedCode : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DANNY;database=BUSPASSSYSTEMDatabase;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("select * from QR_Code", con);
                ds = new DataSet();
                da.Fill(ds, "QR_Code");
                DataList1.DataSource = ds.Tables[0];
                DataList1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }


        }
        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            Image img = e.Item.FindControl("QR_Code") as Image;
            DataRow row = ds.Tables[0].Rows[e.Item.ItemIndex];
            byte[] bytes = (byte[])row["QR_Code"];

            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            img.ImageUrl = "data:image/png;base64," + base64String;


        }

    }
}