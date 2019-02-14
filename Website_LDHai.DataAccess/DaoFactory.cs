using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Website_LDHai.DataAccess
{
    public class DaoFactory
    {
        public static SqlConnection GetConnection
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
                return new SqlConnection(connectionString);
            }
        }


        public DataTable ExcuteQuery(string queryString, SqlConnection sqlConnection, SqlParameter[] sqlParameters)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(queryString, sqlConnection);
                if (sqlParameters != null)
                    cmd.Parameters.AddRange(sqlParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public int ExcuteNonQuery(string queryString, SqlConnection sqlConnection, SqlParameter[] sqlParameters)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(queryString, sqlConnection);
                if (sqlParameters != null)
                    cmd.Parameters.AddRange(sqlParameters);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
