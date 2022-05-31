using System;
using System.Collections.Generic;

#nullable disable

namespace Chubss.Models
{
    public partial class Producto
    {
        public decimal IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
    }
}
