using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStorage
{
    public class DeleteItem
    {
        public bool DeleteRow(string connectionString, int Id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
           bool completeDelete = false;

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (cmd = new SqlCommand { Connection = con, CommandType = CommandType.StoredProcedure })
                {
                    cmd.CommandText = "dbo.LoginInfo_Delete_ById";
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        completeDelete = true;
                    }  
                    catch
                    {
                       return completeDelete ;
                    }
                   
                    con.Close();
                    return completeDelete;
                }

            }
        }
    }
}
