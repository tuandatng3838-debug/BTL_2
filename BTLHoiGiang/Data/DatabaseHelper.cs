using System;
using System.Data;
using System.Data.SqlClient;

namespace BTLHoiGiang.Data
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=HoiGiangDb;Trusted_Connection=True;MultipleActiveResultSets=true;";

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static object? ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteScalar();
        }
    }
}
