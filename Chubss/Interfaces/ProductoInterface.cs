using Chubss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chubss.Interfaces
{
    public interface ProductoInterface
    {
        Task<List<Producto>> ConsultaProd(string codProduc);
        Task<string> EditaProducto(Producto editProduc);
        Task<string> InsertarProducto(Producto editProduc);
    }
}
