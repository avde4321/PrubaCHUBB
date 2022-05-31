using System;
using System.Collections.Generic;

#nullable disable

namespace Chubss.Models
{
    public partial class PersonaProducto
    {
        public decimal IdPersonaProducto { get; set; }
        public decimal? IdPersona { get; set; }
        public string IdProducto { get; set; }
        public decimal? Prima { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
    }
}
