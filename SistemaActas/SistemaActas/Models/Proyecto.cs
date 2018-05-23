﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaActas.Models
{
    public class Proyecto
    {
        private int id;
        private string nombre;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}