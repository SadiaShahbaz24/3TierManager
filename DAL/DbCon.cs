using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DbCon
    {
        SqlConnection sqlcon;

        public DbCon()
        {
            sqlcon = new SqlConnection("Data Source=DESKTOP-138QU5L;Initial Catalog=crudOperations;Integrated Security=True");

        }
        public bool UDI(string qry)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(qry, sqlcon);
            bool check = cmd.ExecuteNonQuery() > 0;
            sqlcon.Close();
            return check;
        } 

        public DataTable Search(string qry)
        {
            SqlDataAdapter sda = new SqlDataAdapter(qry, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
    }
}
