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
        public bool conectaBD()
        {
            try
            {
                con = new MySqlConnection();
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
