using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaActas.ProyectoServices;

namespace SistemaActas.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult AllProyecto()
        {
            ServiceProyectosClient service = new ServiceProyectosClient();

            Proyecto[] proyectos = service.ObtenerProyectos();
            return View(proyectos);
        }

        public ActionResult Details(string id)
        {
            if (id == null) return Redirect("/Proyecto/AllProyecto");

            ServiceProyectosClient service = new ServiceProyectosClient();

            Proyecto proyecto = service.ObtenerProyecto(id);
            Acta[] actas = service.ObtenerActasPorProyecto(id);

            if (proyecto == null)
            {
                return Redirect("/Proyecto/AllProyecto");
            }

            proyecto.id_proyecto = Convert.ToInt32(id);
            ViewBag.proyecto = proyecto;
            return View(actas);
        }

        public ActionResult Create()
        {
            Proyecto proyecto = new Proyecto();
            return View(proyecto);
        }

        [HttpPost]
        public ActionResult Create(Proyecto proyecto)
        {
            ServiceProyectosClient service = new ServiceProyectosClient();
            service.CrearProyecto(proyecto.nombre, proyecto.descripcion);

            return Redirect("/Proyecto/AllProyecto");
        }

        public ActionResult Edit(string id)
        {
            ServiceProyectosClient service = new ServiceProyectosClient();
            Proyecto proyecto = service.ObtenerProyecto(id);

            if (proyecto == null)
            {
                return Redirect("/Proyecto/AllProyecto");
            }
            proyecto.id_proyecto = Convert.ToInt32(id);
            return View(proyecto);
        }
        [HttpPost]
        public ActionResult Edit(int id, Proyecto proyecto)
        {
            if (proyecto == null)
            {
                return Redirect("/Proyecto/AllProyecto");
            }
            ServiceProyectosClient service = new ServiceProyectosClient();
            service.ActualizarProyecto(id, proyecto.nombre, proyecto.descripcion);

            return Redirect("/Proyecto/AllProyecto");
        }

    }
}