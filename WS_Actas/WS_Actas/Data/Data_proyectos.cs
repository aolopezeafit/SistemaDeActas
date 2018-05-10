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
    public class Data_proyectos
    {
        private static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public static void CrearProyecto(Proyecto proyecto)
        {
            string query = string.Format("insert into proyecto (nombre, descripcion) values ('{0}', '{1}')", proyecto.nombre, proyecto.descripcion);
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
                    throw new Exception("Error creando el proyecto.");
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

        public static List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> listaProyectos = new List<Proyecto>();
            string query = "select * from proyecto";
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
                    listaProyectos.Add(new Proyecto(reader.GetInt16(0), reader.GetString(1), reader.GetString(2)));
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

        public static Proyecto ObtenerProyecto(string idProyecto)
        {
            Proyecto proyecto = new Proyecto();
            string query = "select * from proyecto where id_proyecto = " + idProyecto;
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
                    proyecto = new Proyecto(reader.GetInt16(0), reader.GetString(1), reader.GetString(2));
                }

                return proyecto;
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

        public static void ActualizarProyecto(Proyecto proyecto)
        {
            string query = string.Format("UPDATE proyecto SET nombre = '{0}', descripcion = '{1}' WHERE id_proyecto = {2}", proyecto.nombre, proyecto.descripcion, proyecto.id_proyecto);
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
                    throw new Exception("Error actualizando el proyecto.");
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
    }
}