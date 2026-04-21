using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SMS_V3
{
    public static class DatabaseHelper
    {
        // This is the "Bridge" to your SSMS database
        private static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=False";

        // This method opens a connection for us to use
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        // OPTIONAL: A quick method to run a command without returning data (like saving attendance)
        public static void ExecuteQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}