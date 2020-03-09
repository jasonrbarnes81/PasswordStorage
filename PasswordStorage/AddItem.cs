using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage
{
    public class AddItem
    {
        public bool InsertItem(string connectionString, string userName, string password, string description)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
           
            bool itemAdded = false;

            using (con = new SqlConnection(connectionString))
            {
               con.Open();
                using (cmd = new SqlCommand { Connection = con, CommandType = CommandType.StoredProcedure })
                {
                    cmd.CommandText = "dbo.LoginInfo_Insert";

                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Description", description);
                    

                    
                    try
                    {
                        cmd.ExecuteNonQuery();
                        
                        itemAdded = true;
                    }
                    catch (Exception ex)
                    {
                        
                       return itemAdded;
                    };

                    con.Close();
                    return itemAdded;
                    
                }
                    
            }


                
        }
    }
}
