using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Practica1.DAL
{
    public class Usuarios
    {
        public object getUsuario(string NomUsuario, string PassUsuario)
        {

            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("practica1_getUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uN", NomUsuario);
                    cmd.Parameters.AddWithValue("@uP", PassUsuario);
                }

            }
    }
}