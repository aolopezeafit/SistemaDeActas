
using SistemaActas.ActaServices;
using SistemaActas.ProyectoServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaActas.Controllers
{
    public class ActasController : Controller
    {

        public ActionResult AllActas()
        {
           return View();
        }

        public ActionResult create(string idProyecto)
        {
            ServiceProyectosClient service = new ServiceProyectosClient();

            ViewBag.proyecto = service.ObtenerProyecto(idProyecto);
            ActaServices.Acta acta = new ActaServices.Acta();
            return View(acta);
        }

        [HttpPost]
        public ActionResult Create(ActaServices.Acta acta)
        {

            string fecha = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
            ServiceActasClient service = new ServiceActasClient();
            service.CrearActa(acta.nombre, acta.descripcion, acta.anotaciones, fecha, acta.id_proyecto);

            return Redirect("/Proyecto/Details/" + acta.id_proyecto );
        }

        public ActionResult Edit(string id)
        {
            ServiceActasClient service = new ServiceActasClient();
            ServiceProyectosClient proyectoService = new ServiceProyectosClient();
            ActaServices.Acta acta = service.ObtenerActa(id);
            Proyecto proyecto = proyectoService.ObtenerProyecto(acta.id_proyecto.ToString());
            ViewBag.proyecto = proyecto;

            return View(acta);
        }


        [HttpPost]
        public ActionResult Edit(int id, ActaServices.Acta acta)
        {
            if (acta == null)
            {
                return Redirect("/Proyecto/AllProyecto");
            }

            string fecha = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.CreateSpecificCulture("en-US"));
            ServiceActasClient service = new ServiceActasClient();
            service.ActualizarActa(id, acta.nombre, acta.descripcion, acta.anotaciones, acta.id_proyecto);

            return Redirect("/Proyecto/Details/" + acta.id_proyecto);
        }

    }
}