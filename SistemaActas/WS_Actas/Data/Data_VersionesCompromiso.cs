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
    public class Data_VersionesCompromiso
    {
        private static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public static void CrearVersionCompromiso(VersionCompromiso VersionCompromiso)
        {
            string query = string.Format("insert into version_compromiso (descripcion, fecha_compromiso, id_compromiso, id_estado, anotacion, id_usuario_asignado) values ('{0}', STR_TO_DATE('{1}', '%d/%m/%Y %r'), {2}, {3}, '{4}', {5})", VersionCompromiso.descripcion, VersionCompromiso.fecha_compromiso, VersionCompromiso.id_compromiso, VersionCompromiso.id_estado, VersionCompromiso.anotacion, VersionCompromiso.id_usuario_asignado);
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
                    throw new Exception("Error creando la versión del compromiso.");
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

        public static List<VersionCompromiso> ObtenerVersionesCompromisos()
        {
            List<VersionCompromiso> listaVersionesCompromisos = new List<VersionCompromiso>();
            string query = "select * from version_compromiso";
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
                    listaVersionesCompromisos.Add(new VersionCompromiso(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetInt16(4), reader.GetString(5), reader.GetInt32(6)));
                }

                return listaVersionesCompromisos;
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

        public static VersionCompromiso ObtenerVersionCompromiso(string idVersionCompromiso)
        {
            VersionCompromiso versionCompromiso = new VersionCompromiso();
            string query = "select * from version_compromiso where id_version_compromiso = " + idVersionCompromiso;
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
                    versionCompromiso = new VersionCompromiso(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetInt16(4), reader.GetString(5), reader.GetInt32(6));
                }

                return versionCompromiso;
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

        public static void ActualizarCompromiso(VersionCompromiso versionCompromiso)
        {
            string query = string.Format("UPDATE version_compromiso SET descripcion = '{0}', fecha_compromiso = STR_TO_DATE('{1}', '%d/%m/%Y %r'), id_compromiso = {2}, id_estado = {3}, anotacion = '{4}', id_usuario_asignado = {5} WHERE id_version_compromiso = {6}", versionCompromiso.descripcion, versionCompromiso.fecha_compromiso, versionCompromiso.id_compromiso, versionCompromiso.id_estado, versionCompromiso.anotacion, versionCompromiso.id_usuario_asignado, versionCompromiso.id_version_compromiso );
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
                    throw new Exception("Error actualizando la versión del compromiso.");
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

        public static List<Estado> ObtenerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            string query = "select * from estado";
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
                    listaEstados.Add(new Estado(reader.GetInt16(0), reader.GetString(1), reader.GetString(2)));
                }

                return listaEstados;
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

        public static List<VersionCompromiso> ObtenerVersionesDeCompromiso(string idCompromiso)
        {
            List<VersionCompromiso> listaVersionesCompromiso = new List<VersionCompromiso>();
            string query = string.Format("select * from version_compromiso where id_compromiso = {0} order by id_version_compromiso", idCompromiso);
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
                    listaVersionesCompromiso.Add(new VersionCompromiso(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetInt16(4), reader.GetString(5), reader.GetInt32(6)));
                }

                return listaVersionesCompromiso;
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

        public static VersionCompromiso ObtenerUltimaVersionDeCompromiso(string idCompromiso)
        {
            VersionCompromiso versionCompromiso = new VersionCompromiso();
            string query = string.Format("select * from version_compromiso where id_compromiso = {0} order by id_version_compromiso desc limit 1;", idCompromiso);
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
                    versionCompromiso = new VersionCompromiso(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetInt16(4), reader.GetString(5), reader.GetInt32(6));
                }

                return versionCompromiso;
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