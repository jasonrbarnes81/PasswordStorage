using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage
{
    public class RetreiveItems
    {
        public DataTable SelectAll(string connectionString)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            DataTable dt = null;
            SqlDataAdapter da = null;

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (cmd = new SqlCommand { Connection = con, CommandType = CommandType.StoredProcedure })
                {
                    cmd.CommandText = "dbo.LoginInfo_SelectAll";
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }

            }

            
            
        }
    }
}
