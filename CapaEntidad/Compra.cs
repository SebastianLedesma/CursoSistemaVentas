﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra {  get; set; }
        public Usuario Usuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public string TipoDocumento {  get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal {  get; set; }
        public List<DetalleCompra> DetalleCompra {  get; set; }
        public string FechaRegistro { get; set; }
    }
}
