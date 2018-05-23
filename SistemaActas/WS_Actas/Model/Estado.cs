using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Actas.Model
{
    [DataContract]
    public class Estado
    {
        [DataMember]
        public int id_estado { set; get; }
        [DataMember]
        public string nombre { set; get; }
        [DataMember]
        public string descripcion { set; get; }

        public Estado () { }

        public Estado (int id_estado, string nombre, string descripcion)
        {
            this.id_estado = id_estado;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}