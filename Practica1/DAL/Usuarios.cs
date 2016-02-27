using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace Practica1.DAL
{
    public class Usuarios
    {



        public static bool validarUsuario(string NomUsuario, string PassUsuario)
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            DataSet ds = new DataSet();
            //IDataReader a = null;
            MySqlCommand cmd;
            MySqlDataAdapter da;
            using (con)
            {
                try
                {
                    cmd = new MySqlCommand("prac1_getUsuario", con);
                    da = new MySqlDataAdapter(cmd);   
                    con.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@uN", NomUsuario);
                    da.SelectCommand.Parameters.AddWithValue("@uP", PassUsuario);
                    Debug.WriteLine(da.ToString());
                    da.Fill(ds);
                    //a = cmd.ExecuteReader();


                }
                catch (MySqlException ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                // con.Close();

            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public /*IDataReader*/ DataSet getUsuario(string NomUsuario, string PassUsuario)
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            DataSet ds = new DataSet();
            //IDataReader a = null;
            MySqlCommand cmd;
            MySqlDataAdapter da;
            using (con)
            {
                try
                {
                    using (da = new MySqlDataAdapter())
                        con.Open();
                    using (cmd = new MySqlCommand("prac1_getUsuario", con))
                    {

                        da.SelectCommand = cmd;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@uN", NomUsuario);
                        da.SelectCommand.Parameters.AddWithValue("@uP", PassUsuario);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        // cmd.Parameters.AddWithValue("@uN", NomUsuario);
                        // cmd.Parameters.AddWithValue("@uP", PassUsuario);
                        da.Fill(ds);
                        //a = cmd.ExecuteReader();

                    }
                }
                catch (MySqlException ex)
                {

                }
                // con.Close();

            }

            return ds;
        }
    }
}