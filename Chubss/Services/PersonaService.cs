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
            bool idproducto = false;
            try
            {
                idPer = _context.Personas.Where(x => x.Identificacion == identificacion).ToList();

                producto.IdPersona = idPer[0].IdPersona;

                idproducto = _context.PersonaProductos.Count(y => y.IdPersona == producto.IdPersona && y.IdProducto == producto.IdProducto) == 0?true:false;

                if (idproducto)
                {
                    await _context.PersonaProductos.AddAsync(producto);
                    await _context.SaveChangesAsync();
                    return res = "Persona y producto registrado correctamente";
                }
                else 
                {
                    return res = "Persona ya tiene asignado ese producto";
                }
                
            }
            catch (Exception ex)
            {
                return res = "BAD";
            }
        }

        public async Task<dynamic> ConsulPersona(string identificacion)
        {
            dynamic res = null;
            try
            {
                if(identificacion == null)
                {
                    res = _context.Personas.Where(x => x.Estado == "A").ToList();
                }
                else
                {
                    res = _context.Personas.Where(x => x.Identificacion == identificacion && x.Estado =="A").ToList();
                }
                
                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<dynamic> CansultProduct(string identificacion)
        {
            List<ConsultaProduc> res = new List<ConsultaProduc>();
            dynamic Listres = null;
            dynamic idPer = null;
            decimal identi = 0;
            try
            {
                idPer = _context.Personas.Where(x => x.Identificacion == identificacion).ToList();
                identi = idPer[0].IdPersona;
                Listres = _context.PersonaProductos.Where(x => x.IdPersona == identi).ToList();

                foreach (PersonaProducto item in Listres)
                {
                    ConsultaProduc json = new ConsultaProduc()
                    {
                        Descripcion = _context.Productos.Where(x => x.CodProducto == item.IdProducto).Select(x => x.Descripcion).FirstOrDefault(),
                        Prima = item.Prima.ToString()
                    };

                    res.Add(json);
                }

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

        public async Task<bool> ValidaExistPerson(string identificacion)
        {
            try
            {
                bool valPerson = _context.Personas.Count(x => x.Identificacion == identificacion) > 0 ? false: true ;

                return valPerson;
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
                dynamic listTipoPersona = _context.Productos.Where(x => x.Estado == "A").ToList();

                return listTipoPersona;
            }
            catch (Exception es)
            {

                throw;
            }
        }

        public async Task<string> EditaPersona(Persona editperson)
        {
            Persona persona = new Persona();
            try
            {
                persona = _context.Personas.Where(x => x.IdPersona == editperson.IdPersona).FirstOrDefault();

                persona.Identificacion = editperson.Identificacion;
                persona.NombreCliente = editperson.NombreCliente;
                persona.Telefono = editperson.Telefono;
                persona.Edad = editperson.Edad;
                persona.Estado = editperson.Estado;

                _context.SaveChanges();


                return "Registro Editado";
            }
            catch (Exception ex)
            {
                return "Se presento un error";
            }
        }
    }
}
