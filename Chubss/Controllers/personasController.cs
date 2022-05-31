using Chubss.Interfaces;
using Chubss.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chubss.Controllers
{
    public class personasController : Controller
    {
        private readonly PersonaInterface _personaInterface;

        public personasController(PersonaInterface personaInterface)
        {
            this._personaInterface = personaInterface;
        }

        public IActionResult Index()
        {
            List<Catalogo> listTipoPersona = new List<Catalogo>();
            List<Producto> ListaProducto = new List<Producto>();
            listTipoPersona = TipoPersona().GetAwaiter().GetResult();
            ListaProducto = Producto().GetAwaiter().GetResult();

            ViewData["ListaTipoPersona"] = listTipoPersona;
            ViewData["ListaProducto"] = ListaProducto;
            return View();
        }

        [HttpGet]
        public async Task<List<Catalogo>> TipoPersona()
        {
            List<Catalogo> lisCatalogo = new List<Catalogo>();
            try
            {
                lisCatalogo = await _personaInterface.TipoPersonas();
                return lisCatalogo;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public async Task<List<Producto>> Producto()
        {
            List<Producto> lisProducto = new List<Producto>();
            try
            {
                lisProducto = await _personaInterface.Producto();
                return lisProducto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public async Task<IActionResult> ConsulPersona(string identificacion)
        {
            List<Persona> listPersona = new List<Persona>();
            try
            {
                listPersona = await _personaInterface.ConsulPersona(identificacion);
                return PartialView("ConsulPersona", listPersona);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Insertar(Persona persona, PersonaProducto producto)
        {
            var res = string.Empty;
            var valida = string.Empty;
            bool ExistePerd = false;
            var identificacion = persona.Identificacion;
            try
            {
                valida = ValidaCamp(persona, producto);
                ExistePerd = ValidaExistePer(identificacion).GetAwaiter().GetResult();
                if (valida == "OK")
                {
                    if (ExistePerd.Equals(true))
                    {
                        res = await _personaInterface.InsetarPersona(persona);

                        if (res == "OK")
                            res = await _personaInterface.InsertarProducto(producto, identificacion);

                        return base.Json("Persona y producto registrado correctamente");
                    }
                    else
                    {
                        return base.Json("La personas con Identificacion: "+ identificacion+" ya se encuentra registrada");
                    }
                    
                }
                else
                {
                    return base.Json(valida);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertarProducto(PersonaProducto producto, string Ident)
        {
            var res = string.Empty;
            var valida = string.Empty;
            var identificacion = Ident;
            try
            {
                res = await _personaInterface.InsertarProducto(producto, identificacion);
                
                return base.Json(res);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> ConstProducto(string Ident)
        {
            List<ConsultaProduc> listProducto = new List<ConsultaProduc>();
            try
            {
                listProducto = await _personaInterface.CansultProduct(Ident);

                return PartialView("ConstProduct", listProducto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditPerson(Persona persona)
        {
            var res = string.Empty;
            try
            {
                res = await _personaInterface.EditaPersona(persona);

                return base.Json(res);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> ValidaExistePer(string Ident)
        {
            bool res = false;
            try
            {
                res = await _personaInterface.ValidaExistPerson(Ident);
                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public string ValidaCamp(dynamic val1, dynamic val2)
        {
            try
            {
                if (val1.Identificacion == null)
                {
                    return "Campo Identificacion es obligatorio";
                }
                if (val1.NombreCliente == null)
                {
                    return "Campo Nombre del Cliente es obligatorio";
                }
                if (val1.Telefono == null)
                {
                    return "Campo Telefono es obligatorio";
                }
                if (val1.Edad == null)
                {
                    return "Campo Edad es obligatorio";
                }
                if (val2.Prima == null)
                {
                    return "Campo Prima es obligatorio";
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
