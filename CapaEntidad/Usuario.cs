﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idUsuario {  get; set; }
        public string Documento {  get; set; }
        public string NombreCompleto {  get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol Rol { get; set; }
        public bool Estado {  get; set; }
        public string FechaRegistro { get; set; }
    }
}
