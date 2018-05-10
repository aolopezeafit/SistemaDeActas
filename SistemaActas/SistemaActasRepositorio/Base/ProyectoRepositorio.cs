using Eafit.Clase.SistemaActas.Dominio.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eafit.Clase.SistemaActas.Repositorio.Base
{
    public class ProyectoRepositorio: IRepositorio
    {
        public void Agregar(Proyecto proyecto)
        {
            //guardar en la db proyecto y retornar
        }
        public void Modificar(Proyecto proyecto)
        {
            //modificar en la db proyecto y retornar
        }
        public void Eliminar(Proyecto proyecto)
        {
            //eliminar en la db proyecto y retornar
        }
        public List<Proyecto> Seleccionar()
        {
            //seleccionar todos los proyectos en la db
            return null;
        }
        public Proyecto SeleccionarPorId(Proyecto proyecto)
        {
            //buscar por proyecto.id en la db
            return null;
        }
    }
}
