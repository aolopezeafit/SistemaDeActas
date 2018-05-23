using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Actas.Model
{
    [DataContract]
    public class Proyecto
    {
        [DataMember]
        public int id_proyecto { set; get; }
        [DataMember]
        public string nombre { set; get; }
        [DataMember]
        public string descripcion { set; get; }

        public Proyecto () { }

        public Proyecto(int id_proyecto, string nombre, string descripcion)
        {
            this.id_proyecto = id_proyecto;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}