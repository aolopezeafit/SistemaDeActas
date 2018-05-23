using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Actas.Model
{
    [DataContract]
    public class VersionCompromiso
    {
        [DataMember]
        public int id_version_compromiso { set; get; }
        [DataMember]
        public string descripcion { set; get; }
        [DataMember]
        public string fecha_compromiso { set; get; }
        [DataMember]
        public int id_compromiso { set; get; }
        [DataMember]
        public int id_estado { set; get; }
        [DataMember]
        public string anotacion { set; get; }
        [DataMember]
        public int id_usuario_asignado { set; get; }

        public VersionCompromiso () { }

        public VersionCompromiso(int id_version_compromiso, string descripcion, string fecha_compromiso, int id_compromiso, int id_estado, string anotacion, int id_usuario_asignado)
        {
            this.id_version_compromiso = id_version_compromiso;
            this.descripcion = descripcion;
            this.fecha_compromiso = fecha_compromiso;
            this.id_compromiso = id_compromiso;
            this.id_estado = id_estado;
            this.anotacion = anotacion;
            this.id_usuario_asignado = id_usuario_asignado;
        }
    }
}