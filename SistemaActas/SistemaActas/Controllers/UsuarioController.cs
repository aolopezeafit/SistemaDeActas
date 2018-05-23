using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaActas.UsuarioServices;

namespace SistemaActas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult AllUsuario()
        {
            ServiceUsuariosClient service = new ServiceUsuariosClient();
            Usuario[] Usuarios = service.ObtenerUsuarios();
            return View(Usuarios);
        }

        public ActionResult Details(string id)
        {
            ServiceUsuariosClient service = new ServiceUsuariosClient();
            Usuario Usuario = service.ObtenerUsuario(id);
            if (Usuario == null)
            {
                return Redirect("/Usuario/AllUsuario");
            }
            Usuario.id_usuario = Convert.ToInt32(id);
            return View(Usuario);
        }

        public ActionResult Create()
        {
            Usuario Usuario = new Usuario();
            return View(Usuario);
        }

        [HttpPost]
        public ActionResult Create(Usuario Usuario)
        {
            ServiceUsuariosClient service = new ServiceUsuariosClient();
            service.CrearUsuario(Usuario.nombre, Usuario.contraseña, Usuario.identificacion);        
            
            return Redirect("/Usuario/AllUsuario");
        }

        public ActionResult Edit(string id)
        {
            ServiceUsuariosClient service = new ServiceUsuariosClient();
            Usuario Usuario = service.ObtenerUsuario(id);
       
            if(Usuario == null)
            {
                return Redirect("/Usuario/AllUsuario");
            }
            Usuario.id_usuario = Convert.ToInt32(id);
            return View(Usuario);
        }
        [HttpPost]
        public ActionResult Edit(int id, Usuario Usuario)
        {
            if (Usuario == null)
            {
                return Redirect("/Usuario/AllUsuario");
            }
            ServiceUsuariosClient service = new ServiceUsuariosClient();
            service.ActualizarUsuario(id, Usuario.nombre, Usuario.contraseña, Usuario.identificacion);

            return Redirect("/Usuario/AllUsuario");
        }
    }
}