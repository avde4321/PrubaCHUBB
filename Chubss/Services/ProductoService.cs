using Chubss.Interfaces;
using Chubss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chubss.Services
{
    public class ProductoService : ProductoInterface
    {
        private readonly dbpruebaschubbContext _context;

        public ProductoService(dbpruebaschubbContext context)
        {
            this._context = context;
        }

        public async Task<List<Producto>> ConsultaProd(string codProduc)
        {
            List<Producto> res = new List<Producto>();
            try
            {
                if (codProduc == null)
                {
                    res = _context.Productos.ToList();
                }
                else
                {
                    res = _context.Productos.Where(x => x.CodProducto == codProduc).ToList();
                }

                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<string> EditaProducto(Producto editProduc)
        {
            Producto producto = new Producto();
            var res = string.Empty;
            try
            {
                producto = _context.Productos.Where(x => x.IdProducto == editProduc.IdProducto).FirstOrDefault();

                producto.CodProducto = editProduc.CodProducto;
                producto.Descripcion = editProduc.Descripcion;
                producto.Estado = editProduc.Estado;

                _context.SaveChanges();

                return "Se actualiz el producto correctamente";
            }
            catch (Exception ex)
            {
                return "Se precenta error";
            }
        }

        public async Task<string> InsertarProducto(Producto editProduc)
        {
            var res = string.Empty;
            bool valida = false;
            try
            {
                valida = _context.Productos.Count(x => x.CodProducto == editProduc.CodProducto) == 0 ? true : false;
                if (valida)
                {
                    _context.Productos.Add(editProduc);

                    _context.SaveChanges();
                    return "Se Inserto el producto correctamente";
                }
                else
                {
                    return "CodProducto: "+ editProduc.CodProducto + " ya existe";
                }
                
            }
            catch (Exception ex)
            {
                return "Se precenta error";
            }
        }
    }
}
