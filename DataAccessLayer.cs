using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DA
{
   public class DataAccessLayer
    {
       SqlConnection con;
       SqlCommand cmd;
       SqlDataAdapter dap;
       public  DataAccessLayer()

       {
           con = new SqlConnection();
           cmd = new SqlCommand();
           dap = new SqlDataAdapter();
           cmd.Connection = con;
           dap.SelectCommand = cmd;
        }
       public void connect()
       {
           con.ConnectionString = "Data Source=.;Initial Catalog=zamani;Integrated Security=True";
           con.Open();
       }
       public void disconnect()
       {
           con.Close();
       }
       public DataTable select(string sql)
       {
           cmd.CommandText = sql;
           DataTable dt = new DataTable();
           dap.Fill(dt);
           return dt;
       }
       public void docommand(string sql)
       {
           cmd.CommandText = sql;
           cmd.ExecuteNonQuery();
       }

    }
    

}
