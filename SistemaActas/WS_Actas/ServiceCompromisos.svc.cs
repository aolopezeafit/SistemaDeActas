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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCompromisos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCompromisos.svc o ServiceCompromisos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCompromisos : IServiceCompromisos
    {
        public void CrearCompromiso(int id_acta)
        {
            Data_Compromisos.CrearCompromiso(new Compromiso(0, id_acta));
        }

        public List<Compromiso> ObtenerCompromisos()
        {
            return Data_Compromisos.ObtenerCompromisos();
        }

        public Compromiso ObtenerCompromiso(string idCompromiso)
        {
            return Data_Compromisos.ObtenerCompromiso(idCompromiso);
        }

        public void ActualizarCompromiso(int id_compromiso, int id_acta)
        {
            Data_Compromisos.ActualizarCompromiso(new Compromiso(id_compromiso, id_acta));
        }

        public Usuario ObtenerUsuarioCompromiso(string idCompromiso)
        {
            return Data_Compromisos.ObtenerUsuarioCompromiso(idCompromiso);
        }
    }
}
