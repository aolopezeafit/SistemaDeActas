using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Actas.Model
{
    [DataContract]
    public class Compromiso
    {
        [DataMember]
        public int id_compromiso { set; get; }
        [DataMember]
        public int id_acta { set; get; }

        public Compromiso () { }

        public Compromiso (int id_compromiso, int id_acta)
        {
            this.id_compromiso = id_compromiso;
            this.id_acta = id_acta;
        }
    }
}