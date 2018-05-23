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
    public class Data_Compromisos
    {
        private static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public static void CrearCompromiso(Compromiso compromiso)
        {
            string query = string.Format("insert into compromiso (id_acta) values ({0})", compromiso.id_acta);
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
                    throw new Exception("Error creando el compromiso.");
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

        public static List<Compromiso> ObtenerCompromisos()
        {
            List<Compromiso> listaCompromisos = new List<Compromiso>();
            string query = "select * from compromiso";
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
                    listaCompromisos.Add(new Compromiso(reader.GetInt16(0), reader.GetInt16(1)));
                }

                return listaCompromisos;
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

        public static Compromiso ObtenerCompromiso(string idCompromiso)
        {
            Compromiso compromiso = new Compromiso();
            string query = "select * from compromiso where id_compromiso = " + idCompromiso;
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
                    compromiso = new Compromiso(reader.GetInt16(0), reader.GetInt16(1));
                }

                return compromiso;
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

        public static void ActualizarCompromiso(Compromiso compromiso)
        {
            string query = string.Format("UPDATE compromiso SET id_acta = {0} WHERE id_compromiso = {1}", compromiso.id_acta, compromiso.id_compromiso);
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
                    throw new Exception("Error actualizando el compromiso.");
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

        public static Usuario ObtenerUsuarioCompromiso(string idCompromiso)
        {
            Usuario usuario = new Usuario();
            string query = string.Format("select u.* from usuario u where u.id_usuario = (select vc.id_usuario_asignado from version_compromiso vc where vc.id_compromiso = {0} order by id_version_compromiso desc limit 1)", idCompromiso);
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