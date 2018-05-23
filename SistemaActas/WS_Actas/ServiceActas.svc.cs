using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Actas.Data;
using WS_Actas.Model;

namespace WS_Actas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceActas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceActas.svc o ServiceActas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceActas : IServiceActas
    {
        public void CrearActa(string nombre, string descripcion, string anotaciones, string fecha, int id_proyecto)
        {
            Data_Actas.CrearActa(new Acta(0, nombre, descripcion, anotaciones, fecha, id_proyecto));
        }        

        public List<Acta> ObtenerActas()
        {
            return Data_Actas.ObtenerActas();
        }

        public Acta ObtenerActa(string idActa)
        {
            return Data_Actas.ObtenerActa(idActa);
        }

        public void ActualizarActa(int id_acta, string nombre, string descripcion, string anotaciones, int id_proyecto)
        {
            Data_Actas.ActualizarActa(new Acta(id_acta, nombre, descripcion, anotaciones, "", id_proyecto));
        }

        public List<VersionCompromiso> ObtenerCompromisosPorActa(string idActa)
        {
            return Data_Actas.ObtenerCompromisosPorActa(idActa);
        }
    }
}
