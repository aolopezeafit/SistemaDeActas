﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS_Actas.Data;
using WS_Actas.Model;

namespace WS_Actas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProyectos : IServiceProyectos
    {
        public void CrearProyecto(string nombre, string descripcion)
        {
            Data_proyectos.CrearProyecto(new Proyecto(0, nombre, descripcion));
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return Data_proyectos.ObtenerProyectos();
        }

        public Proyecto ObtenerProyecto(string idProyecto)
        {
            return Data_proyectos.ObtenerProyecto(idProyecto);
        }

        public void ActualizarProyecto(Proyecto proyecto)
        {
            Data_proyectos.ActualizarProyecto(proyecto);
        }
    }
}
