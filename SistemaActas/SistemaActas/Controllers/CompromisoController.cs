using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaActas.ActaServices;
using SistemaActas.CompromisoServices;

namespace SistemaActas.Controllers
{
    public class CompromisoController : Controller
    {
        // GET: Compromiso
        public ActionResult Index(string id)
        {
            if (id == null) Redirect("/Proyecto/AllProyecto");
            ServiceActasClient service = new ServiceActasClient();
            VersionCompromiso[] compromisos = service.ObtenerCompromisosPorActa(id);
            ViewBag.acta = service.ObtenerActa(id);
            return View(compromisos);
        }

        public ActionResult Create(string id)
        {
            CompromisoService.VersionCompromiso compromiso = new CompromisoService.VersionCompromiso();
            return View(compromiso);
        }
        [HttpPost]
        public ActionResult Create(VersionCompromiso compromiso)
        {
            ServiceCompromisosClient service = new ServiceCompromisosClient();
            service.CrearCompromiso(1);
            return View(compromiso);
        }

        public ActionResult Detail()
        {
            ServiceCompromisosClient service = new ServiceCompromisosClient();
            return View();
        }
    }
}