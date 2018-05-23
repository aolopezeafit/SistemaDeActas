using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS_Actas.Model;

namespace WS_Actas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceVersionesCompromiso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceVersionesCompromiso
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "CrearVersionCompromiso")]
        void CrearVersionCompromiso(string descripcion, string fecha_compromiso, int id_compromiso, int id_estado, string anotacion, int id_usuario_asignado);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ObtenerVersionesCompromisos")]
        List<VersionCompromiso> ObtenerVersionesCompromisos();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ObtenerVersionCompromiso/{idVersionCompromiso}")]
        VersionCompromiso ObtenerVersionCompromiso(string idVersionCompromiso);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ActualizarVersionCompromiso")]
        void ActualizarVersionCompromiso(int id_version_compromiso, string descripcion, string fecha_compromiso, int id_compromiso, int id_estado, string anotacion, int id_usuario_asignado);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ObtenerEstados")]
        List<Estado> ObtenerEstados();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ObtenerVersionesDeCompromiso/{idCompromiso}")]
        List<VersionCompromiso> ObtenerVersionesDeCompromiso(string idCompromiso);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ObtenerUltimaVersionDeCompromiso/{idCompromiso}")]
        VersionCompromiso ObtenerUltimaVersionDeCompromiso(string idCompromiso);
    }
}