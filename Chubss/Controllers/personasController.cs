﻿using Chubss.Interfaces;
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
            List<Catalogo> ListaProducto = new List<Catalogo>();
            List<Persona> listPersonas = new List<Persona>();
            listTipoPersona = TipoPersona().GetAwaiter().GetResult();
            ListaProducto = Producto().GetAwaiter().GetResult();
            listPersonas = ConsulPersona().GetAwaiter().GetResult();

            ViewData["ListaTipoPersona"] = listTipoPersona;
            ViewData["ListaProducto"] = ListaProducto;
            ViewData["ListaPersona"] = listPersonas;
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
        public async Task<List<Catalogo>> Producto()
        {
            List<Catalogo> lisCatalogo = new List<Catalogo>();
            try
            {
                lisCatalogo = await _personaInterface.Producto();
                return lisCatalogo;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public async Task<List<Persona>> ConsulPersona()
        {
            List<Persona> listPersona = new List<Persona>();
            try
            {
                listPersona = await _personaInterface.ConsulPersona();
                return listPersona;
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
            var identificacion = persona.Identificacion;
            try
            {
                valida = ValidaCamp(persona, producto);
                if (valida == "OK")
                {
                    res = await _personaInterface.InsetarPersona(persona);

                    if (res == "OK")
                        res = await _personaInterface.InsertarProducto(producto, identificacion);

                    return base.Json("Persona y producto registrado correctamente");
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

                return base.Json("Persona y producto registrado correctamente");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> ConstProducto(string Ident)
        {
            List<PersonaProducto> listProducto = new List<PersonaProducto>();
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