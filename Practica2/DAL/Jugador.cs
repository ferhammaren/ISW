using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Jugador
    {
        private MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        private MySqlCommand cmd; 
        private MySqlDataAdapter da;


        public DataSet selectJugador(int index)
        {
            DataSet ds=new DataSet();

            return ds;
        }

        public DataSet addJugador(string nombre)
        {
            DataSet ds = new DataSet();

            return ds;
        }

    }
}