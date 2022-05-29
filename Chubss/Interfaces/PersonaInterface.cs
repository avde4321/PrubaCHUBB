using Chubss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chubss.Interfaces
{
    public interface PersonaInterface
    {
        Task<string> InsetarPersona(Persona perProducto);
        Task<string> InsertarProducto(PersonaProducto producto, string identificacion);
        Task<dynamic> CansultProduct(string identificacion);
        Task<dynamic> ConsulPersona();
        Task<bool> ValidaExistPerson(string identificacion);
        Task<dynamic> TipoPersonas();
        Task<dynamic> Producto();
    }
}
