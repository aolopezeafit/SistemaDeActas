using SistemaActas.UsuarioServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SistemaActas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Sistema de Actas";

            return View();
        }

        public ActionResult Actas()
        {
            ViewBag.Title = "Sistema de Actas - Actas";
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ServiceUsuariosClient service = new ServiceUsuariosClient();
                    Usuario usuario = service.AutenticarUsuario(int.Parse(login.Usuario), login.Password);
                    if (usuario == null)
                    {
                        throw new Exception("Usuario incorrecto.");
                    }
                    FormsAuthentication.SetAuthCookie(usuario.nombre, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    throw new Exception("Datos no válidos.");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(login);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
