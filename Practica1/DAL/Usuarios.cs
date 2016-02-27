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


        /**
        Este metodo se utiliza para verificar que exista el usuario al que intentamos acceder.
            Tal vez se pudiera especificar para ver si puso mal el nombre de usuario o el password pero 
            ya se me hace mucho rollo xD
        **/
        public static bool validarUsuario(string NomUsuario, string PassUsuario)
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);//toma el connection
            //string de webconfig y lo convierte a mysqlconnection.
            DataSet ds = new DataSet(); //declara un nuevo dataset. El dataset contiene las tablas y filas que te regresa el query
            //IDataReader a = null;
            MySqlCommand cmd; //el comando que vas a ejecutar
            MySqlDataAdapter da; //este data adapter se utiliza para poder llenar el dataset. 
            //No se puede obtener directamente un dataset del query mysql, con oracle si se puede pero aqui necesitas un adaptador (ya veras
            //adaptadores en la unidad de patrones gof xD)
            using (con) //usando la conexion
            {
                try
                {
                    cmd = new MySqlCommand("prac1_getUsuario", con); //haces el parsing del comando, se tiene que mandar el comando que
                    //estas llamando y a donde, eso definido por la conexion
                    da = new MySqlDataAdapter(cmd);   //pones que va a contener el adaptador
                    con.Open(); //abres la conexion mysql
                    da.SelectCommand.CommandType = CommandType.StoredProcedure; //especificas que tipo de comando
                    //es el que se va a ejecutar. Esto se hace sobre el dataadapter para luego poder llenar nuestro dataset
                    da.SelectCommand.Parameters.AddWithValue("@uN", NomUsuario); //agregas los parametros que requiere el procedimiento
                    da.SelectCommand.Parameters.AddWithValue("@uP", PassUsuario);
                    Debug.WriteLine(da.ToString()); //debug porque me estaba dando problemas
                    da.Fill(ds);//llenas el data set y ya puedes hacer operaciones sobre lso datos
                    //a = cmd.ExecuteReader();


                }
                catch (MySqlException ex)
                {
                    Debug.WriteLine(ex.ToString()); //excepciones del diablo
                }
                // con.Close();

            }
            if (ds.Tables[0].Rows.Count > 0) //esta es la medula del metodo este xD verifica cuantas filas tiene el data set
                //si no tiene ninguna fila es porque no encontro el usuario
            {
                return true; //y si tiene filas entonces te regresa un true
            }
            else
            {
                return false;
            }
        }
         
        /*este es nuestro metodo para hacer el select del usuario*/
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
            //todo es lo mismo al metodo anterior para verificar el usuario hasta aqui. Este metodo te regresa el dataset para poder
            //asignarselo como DataSource al gridview de Index.
            return ds;
        }
    }
}