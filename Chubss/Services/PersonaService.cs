using Chubss.Interfaces;
using Chubss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chubss.Services
{
    public class PersonaService : PersonaInterface
    {
        public readonly dbpruebaschubbContext _context;

        public PersonaService(dbpruebaschubbContext context)
        {
            this._context = context;
        }

        public async Task<string> InsetarPersona(Persona perProducto)
        {
            var res = string.Empty;
            try
            {
                await _context.Personas.AddAsync(perProducto);
                await _context.SaveChangesAsync();

                return res = "OK";
            }
            catch (Exception ex)
            {
                return res = "BAD";
            }
        }

        public async Task<string> InsertarProducto(PersonaProducto producto, string identificacion)
        {
            var res = string.Empty;
            dynamic idPer = null;
            try
            {
                idPer = _context.Personas.Where(x => x.Identificacion == identificacion).ToList();

                producto.IdPersona = idPer[0].IdPersona;

                await _context.PersonaProductos.AddAsync(producto);
                await _context.SaveChangesAsync();

                return res = "OK";
            }
            catch (Exception ex)
            {
                return res = "BAD";
            }
        }

        public async Task<dynamic> ConsulPersona()
        {
            dynamic res = null;
            try
            {
                res = _context.Personas.ToList();
                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<dynamic> CansultProduct(string identificacion)
        {
            dynamic res = null;
            dynamic idPer = null;
            decimal identi = 0;
            try
            {
                idPer = _context.Personas.Where(x => x.Identificacion == identificacion).ToList();
                identi = idPer[0].IdPersona;
                res = _context.PersonaProductos.Where(x => x.IdPersona == identi).ToList();
                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<dynamic> TipoPersonas()
        {
            try
            {
                dynamic listTipoPersona =  _context.Catalogos.Where(x => x.TipoTabla == "Tipo_Identificacion").ToList();

                return listTipoPersona;
            }
            catch (Exception es)
            {

                throw;
            }
        }

        public async Task<dynamic> Producto()
        {
            try
            {
                dynamic listTipoPersona = _context.Catalogos.Where(x => x.TipoTabla == "Tipo_Producto").ToList();

                return listTipoPersona;
            }
            catch (Exception es)
            {

                throw;
            }
        }
    }
}
