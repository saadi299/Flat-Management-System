using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace FlatManagementSystem
{
    static class DataAccess
    {
        public static DataTable GetDataTable(string query)
        {
            SqlConnection con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);



            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            return dt;
        }

        public static void ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
    }
}
