using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using WS_Actas.Model;
using System.Configuration;

namespace WS_Actas.Data
{
    public class Data_Usuarios
    {
        private static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public static void CrearUsuario(Usuario usuario)
        {
            string query = string.Format("insert into usuario (nombre, contraseña, identificacion) values ('{0}', '{1}', {2})", usuario.nombre, usuario.contraseña, usuario.identificacion);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            int resultado;

            try
            {
                databaseConnection.Open();
                resultado = commandDatabase.ExecuteNonQuery();

                 if(resultado != 1)
                {
                    throw new Exception("Error creando el usuario.");
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> listaProyectos = new List<Usuario>();
            string query = "select * from usuario";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    listaProyectos.Add(new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }

                return listaProyectos;
            }
            catch
            {
                throw;
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public static Usuario ObtenerUsuario(string idUsuario)
        {
            Usuario usuario = new Usuario();
            string query = "select * from usuario where id_usuario = " + idUsuario;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }

                return usuario;
            }
            catch
            {
                throw;
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public static void ActualizarUsuario(Usuario usuario)
        {
            string query = string.Format("UPDATE usuario SET nombre = '{0}', contraseña = '{1}', identificacion = '{2}' WHERE id_usuario = {3}", usuario.nombre, usuario.contraseña, usuario.identificacion, usuario.id_usuario);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            int resultado;

            try
            {
                databaseConnection.Open();
                resultado = commandDatabase.ExecuteNonQuery();

                if (resultado != 1)
                {
                    throw new Exception("Error actualizando el usuario.");
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public static Usuario AutenticarUsuario(int identificacion, string contraseña)
        {
            Usuario usuario = null;
            string query = string.Format("select * from usuario where identificacion = {0} and contraseña = '{1}'",  identificacion, contraseña);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }

                return usuario;
            }
            catch
            {
                throw;
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}