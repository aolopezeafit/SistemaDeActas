using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.ServicioSistemaActas;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.Id = 1;
            proyecto.Nombre = "Proyecto 1";
            Service1Client client = new Service1Client();
            Proyecto respuesta = client.CrearProyecto(proyecto);
            var str = respuesta.Nombre;
            client.Close();
        }
    }
}
