using Chubss.Interfaces;
using Chubss.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chubss.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoInterface _productoInterface;

        public ProductoController(ProductoInterface productoInterface)
        {
            this._productoInterface = productoInterface;
        }

        public IActionResult Index()
        {   
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ConsultProduc(string codProduc)
        {
            List<Producto> listProducto = new List<Producto>();
            try
            {
                listProducto = await _productoInterface.ConsultaProd(codProduc);

                return PartialView("ConsulProducto", listProducto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditaProduct(Producto producto)
        {
            var res = string.Empty;
            try
            {
                res = await _productoInterface.EditaProducto(producto);
                return base.Json(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPut]
        public async Task<IActionResult> InsertarProduct(Producto producto)
        {
            var res = string.Empty;
            try
            {
                res = ValidaCamp(producto);
                if (res == "OK")
                {
                    res = await _productoInterface.InsertarProducto(producto);
                }
                
                return base.Json(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public string ValidaCamp(dynamic val1)
        {
            try
            {
                if (val1.CodProducto == null)
                {
                    return "Campo CodProducto es obligatorio";
                }
                if (val1.Descripcion == null)
                {
                    return "Campo Descripcion es obligatorio";
                }               

                return "OK";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
