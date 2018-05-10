using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Actas.Model
{
    [DataContract]
    public class Acta
    {
        [DataMember]
        public int id_acta { set; get; }
        [DataMember]
        public string nombre { set; get; }
        [DataMember]
        public string descripcion { set; get; }
        [DataMember]
        public string anotaciones { set; get; }
        [DataMember]
        public string fecha { set; get; }
        [DataMember]
        public int id_proyecto { set; get; }

        public Acta() { }

        public Acta(int id_acta, string nombre, string descripcion, string anotaciones, string fecha, int id_proyecto)
        {
            this.id_acta = id_acta;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.anotaciones = anotaciones;
            this.fecha = fecha;
            this.id_proyecto = id_proyecto;
        }
    }
}