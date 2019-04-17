using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BSport.Funciones
{
    class ConexionBD
    {
        public MySqlConnection con;
        public ConexionBD()
        {

        }
        public bool ConectaBD()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "db4free.net";
            conn_string.UserID = "VLeonBar";
            conn_string.Password = "localhost";
            conn_string.Database = "testbsport";

            try
            {
                con = new MySqlConnection(conn_string.ToString());
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("PATATA" + ex.Message);
                return false;
            }
        }
    }
}
