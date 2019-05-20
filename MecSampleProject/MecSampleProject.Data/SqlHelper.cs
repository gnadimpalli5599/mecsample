using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MecSampleProject.Data
{
    public class SqlHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;

        internal static DataTable ExecuteSelectCommand(string CommandName, CommandType cmdType, List<SqlParameter> parameters)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using(SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;

                    if(parameters != null)
                    {

                        foreach (var item in parameters)
                        {
                            cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                        }
                    }

                    try
                    {
                        if(con.State != ConnectionState.Open){
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }


        internal void ExecuteNonQuery(string CommandName, CommandType cmdType, List<SqlParameter> parameters)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                    }

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
       }


    }
}
