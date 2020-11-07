using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{

    class UserDAO
    {
        private MySqlConnection conn { get; set; }
        public UserDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public bool Login(String Username, String Password)
        {
            using (conn)
            {
                conn.Open();
                string sql = "Select * from User where `Username` = '@Username' && `Password` = MD5(@Password)";
                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.ExecuteNonQuery();
                MySqlDataReader md = command.ExecuteReader();
                if (md.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
        }
    }
}
