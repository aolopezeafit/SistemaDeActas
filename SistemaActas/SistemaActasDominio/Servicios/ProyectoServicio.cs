using Eafit.Clase.SistemaActas.Dominio.Entidades.Base;
using Eafit.Clase.SistemaActas.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eafit.Clase.SistemaActas.Dominio.Servicios
{
    public class ProyectoServicio:IServicio
    {
        public void Agregar(Proyecto proyecto)
        {
            //lógica del negocio y guardar con repo
            ProyectoRepositorio repo = new ProyectoRepositorio();
            repo.Agregar(proyecto);
        }
        public void Modificar(Proyecto proyecto)
        {
            //lógica del negocio y guardar con repo
        }
        public void Eliminar(Proyecto proyecto)
        {
            //lógica del negocio y guardar con repo
        }
        public List<Proyecto> Seleccionar()
        {
            //lógica del negocio y seleccionar con repo
            return null;
        }
        public Proyecto SeleccionarPorId(Proyecto proyecto)
        {
            //lógica del negocio y seleccionar con repo
            return null;
        }
    }
}
