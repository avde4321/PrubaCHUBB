using System;
using System.Collections.Generic;

#nullable disable

namespace Chubss.Models
{
    public partial class Persona
    {
        public decimal IdPersona { get; set; }
        public string Identificacion { get; set; }
        public string NombreCliente { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
    }
}
