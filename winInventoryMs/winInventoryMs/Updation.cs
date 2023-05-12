using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winInventoryMs
{
    internal class Updation
    {
        public Updation(string name,string username, string pass,string phone,string email, Int16 status,int id) 
        {
            SqlCommand cmd = new SqlCommand("update_users",MainClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue ("@username", username);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            MainClass.con.Open();
            cmd.ExecuteNonQuery();
            MainClass.con.Close();
        }
    }
}
