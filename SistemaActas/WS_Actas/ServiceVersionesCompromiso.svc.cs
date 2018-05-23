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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceVersionesCompromiso" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceVersionesCompromiso.svc o ServiceVersionesCompromiso.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceVersionesCompromiso : IServiceVersionesCompromiso
    {
        public void CrearVersionCompromiso(string descripcion, string fecha_compromiso, int id_compromiso, int id_estado, string anotacion, int id_usuario_asignado)
        {
            Data_VersionesCompromiso.CrearVersionCompromiso(new VersionCompromiso(0, descripcion, fecha_compromiso, id_compromiso, id_estado, anotacion, id_usuario_asignado));
        }

        public List<VersionCompromiso> ObtenerVersionesCompromisos()
        {
            return Data_VersionesCompromiso.ObtenerVersionesCompromisos();
        }

        public VersionCompromiso ObtenerVersionCompromiso(string idVersionCompromiso)
        {
            return Data_VersionesCompromiso.ObtenerVersionCompromiso(idVersionCompromiso);
        }

        public void ActualizarVersionCompromiso(int id_version_compromiso, string descripcion, string fecha_compromiso, int id_compromiso, int id_estado, string anotacion, int id_usuario_asignado)
        {
            Data_VersionesCompromiso.ActualizarCompromiso(new VersionCompromiso(id_version_compromiso, descripcion, fecha_compromiso, id_compromiso, id_estado, anotacion, id_usuario_asignado));
        }

        public List<Estado> ObtenerEstados()
        {
            return Data_VersionesCompromiso.ObtenerEstados();
        }

        public List<VersionCompromiso> ObtenerVersionesDeCompromiso(string idCompromiso)
        {
            return Data_VersionesCompromiso.ObtenerVersionesDeCompromiso(idCompromiso);
        }

        public VersionCompromiso ObtenerUltimaVersionDeCompromiso(string idCompromiso)
        {
            return Data_VersionesCompromiso.ObtenerUltimaVersionDeCompromiso(idCompromiso);
        }
    }
}
