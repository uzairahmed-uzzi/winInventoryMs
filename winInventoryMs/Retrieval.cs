using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winInventoryMs
{
    internal class Retrieval
    {
        public Retrieval(int id) 
        {
            SqlCommand cmd = new SqlCommand("show_user_details");
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();
        }

    }
}
