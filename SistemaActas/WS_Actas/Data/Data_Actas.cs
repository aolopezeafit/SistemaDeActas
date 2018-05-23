using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using WS_Actas.Model;
using System.Configuration;
using System.Globalization;

namespace WS_Actas.Data
{
    public class Data_Actas
    {
        private static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public static void CrearActa(Acta acta)
        {
            //string fecha2 = acta.fecha.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
            string query = string.Format("insert into acta (nombre, descripcion, anotaciones, fecha, id_proyecto) values ('{0}', '{1}', '{2}', STR_TO_DATE('{3}', '%d/%m/%Y %r'), {4})", acta.nombre, acta.descripcion, acta.anotaciones, acta.fecha, acta.id_proyecto);
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
                    throw new Exception("Error creando el acta.");
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

        public static List<Acta> ObtenerActas()
        {
            List<Acta> listaActas = new List<Acta>();
            string query = "select * from acta";
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
                    listaActas.Add(new Acta(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt16(5)));
                }

                return listaActas;
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

        public static Acta ObtenerActa(string idActa)
        {
            Acta acta = new Acta();
            string query = "select * from acta where id_acta = " + idActa;
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
                    acta = new Acta(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt16(5));
                }

                return acta;
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

        public static void ActualizarActa(Acta acta)
        {
            string query = string.Format("UPDATE acta SET nombre = '{0}', descripcion = '{1}', anotaciones = '{2}', id_proyecto = {3} WHERE id_acta = {4}", acta.nombre, acta.descripcion, acta.anotaciones, acta.id_proyecto, acta.id_acta);
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
                    throw new Exception("Error actualizando el acta.");
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

        public static List<VersionCompromiso> ObtenerCompromisosPorActa(string idActa)
        {
            List<VersionCompromiso> listaVersionCompromisos = new List<VersionCompromiso>();
            string query = string.Format("select vc.* from compromiso c, version_compromiso vc where c.id_acta = {0} and c.id_compromiso = vc.id_compromiso and vc.fecha_compromiso = (select max(fecha_compromiso) from version_compromiso vc2 where vc.id_compromiso = vc2.id_compromiso)", idActa);
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
                    listaVersionCompromisos.Add(new VersionCompromiso(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3), reader.GetInt16(4), reader.GetString(5), reader.GetInt32(6)));
                }

                return listaVersionCompromisos;
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