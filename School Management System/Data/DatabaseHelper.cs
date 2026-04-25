using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace School_Management_System.Data
{
    /// <summary>
    /// Centralized helper for database access using ADO.NET.
    /// - Reads connection string named "schoolmanagement" from App.config by default.
    /// - Provides ExecuteNonQuery, ExecuteScalar and ExecuteDataTable helpers.
    /// - Always uses parameterized queries.
    /// </summary>
    public class DatabaseHelper
    {
        private readonly string _connString;

        public DatabaseHelper(string connectionString = null)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                _connString = connectionString;
                return;
            }

            // Try to read from config: <connectionStrings>
            var cs = ConfigurationManager.ConnectionStrings["schoolmanagement"];
            if (cs != null && !string.IsNullOrWhiteSpace(cs.ConnectionString))
            {
                _connString = cs.ConnectionString;
            }
            else
            {
                throw new InvalidOperationException(
                    "No connection string provided and 'schoolmanagement' not found in App.config.");
            }
        }

        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Bubble up with context; UI should catch and handle user-friendly message
                throw new DataException("ExecuteNonQuery failed.", ex);
            }
        }

        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new DataException("ExecuteScalar failed.", ex);
            }
        }

        public DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException ex)
            {
                throw new DataException("ExecuteDataTable failed.", ex);
            }
        }

        /// <summary>
        /// Create parameter helper to keep calling code concise.
        /// Example: db.ExecuteNonQuery("INSERT ... VALUES (@n)", DatabaseHelper.CreateParam("@n", name));
        /// </summary>
        public static SqlParameter CreateParam(string name, object value, SqlDbType? dbType = null)
        {
            var p = new SqlParameter(name, value ?? DBNull.Value);
            if (dbType.HasValue) p.SqlDbType = dbType.Value;
            return p;
        }
    }
}
