using System;
using System.Collections.Generic;

#nullable disable

namespace Chubss.Models
{
    public partial class Catalogo
    {
        public decimal IdCatalogo { get; set; }
        public string TipoTabla { get; set; }
        public decimal? IdTabla { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
    }
}
