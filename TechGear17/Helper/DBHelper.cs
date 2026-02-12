using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TechGear17.Helper
{
    internal class DBHelper
    {
        public static readonly string connectionString = "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=TechGearDatabase;Integrated Security=true;TrustServerCertificate=true";

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameter)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString)) 
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    if(parameter != null)
                    {
                        cmd.Parameters.AddRange(parameter);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed To Get Execution Query: " + e.Message);
                return -1;
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    if (parameter != null)
                    {
                        cmd.Parameters.AddRange(parameter);
                    }
                
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Failed To Get Data Table: " + e.Message);
                return new DataTable();
            }     
        }
    }
}
