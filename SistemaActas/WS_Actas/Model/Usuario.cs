using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Actas.Model
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int id_usuario { set; get; }
        [DataMember]
        public string nombre { set; get; }
        [DataMember]
        public string contraseña { set; get; }
        [DataMember]
        public int identificacion { set; get; }

        public Usuario () { }

        public Usuario (int id_usuario, string nombre, string contraseña, int identificacion)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.identificacion = identificacion;
        }
    }
}