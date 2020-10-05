using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcBookStoreManagement.Models
{
    public class BookListDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["BookStoreConString"].ToString();
            con = new SqlConnection(constring);
        }

        //---insert query---

        public bool InsertItem(booklist iList)
        {
            connection();
            string query = "INSERT INTO BookDetails VALUES('" + iList.BookName + "','" + iList.Mrp + "','" + iList.Author + "','" + iList.Category + "'," + iList.Publisher + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        //---get all book list-----

        public List<booklist> GetItemList()
        {
            connection();
            List<booklist> iList = new List<booklist>();

            string query = "SELECT * FROM BookDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new booklist
                {
                    //ID = Convert.ToInt32(dr["ID"]),
                    BookName = Convert.ToString(dr["Book_Name"]),
                    Mrp = Convert.ToString(dr["Mrp"]),
                    Author = Convert.ToString(dr["Author"]),
                    Category = Convert.ToString(dr["Category"]),
                    Publisher = Convert.ToString(dr["Publisher"])
                });
            }
            return iList;
        }

        //---update book details---

        public bool UpdateItem(booklist iList)
        {
            connection();
            string query = "UPDATE BookDetails SET Book_Name = '" + iList.BookName + "', Mrp = '" + iList.Mrp + "', Author = '" + iList.Author + "', Category = '" + iList.Category + "', Publisher = " + iList.Publisher + " WHERE ID = " + iList.ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        //---Delete book---

        public bool DeleteItem(int id)
        {
            connection();
            string query = "DELETE FROM BookDetails WHERE ID = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }



}
