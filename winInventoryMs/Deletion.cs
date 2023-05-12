using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winInventoryMs
{
    internal class Deletion
    {
        public Deletion(int id) 
        {
            SqlCommand cmd = new SqlCommand("delete_users", MainClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();
        }
        
    }
}
