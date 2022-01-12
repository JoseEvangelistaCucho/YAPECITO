using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YAPECITO.Models;
using YAPECITO.ModelService;
using YAPECITO.Repository.Repository.Implement;

namespace YAPECITO.Controllers
{   [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : BaseController //Controller
    {
       // private readonly YAPECITOContext _context;

       /* public ClientesController(YAPECITOContext context)
        {
            _context = context;
        }*/
        public ClientesController(IUnitOfWork unit) : base(unit)
        {
        }

      

      

        [HttpGet("BUSCAR CLIENTE")]
        public IActionResult Get( string  NOMBRE_o_DNI)
        {


            return Ok(_unit.Clientes.buscardni(NOMBRE_o_DNI));
        }

        [HttpPost("crearClientes")]
        public ResponseHeader CrearCliente([FromBody] Cliente cliente) //El [FromBody] es opcional
        {

            return _unit.Clientes.CrearCliente(cliente);
        }
        [HttpPut]
        [Route("actualizarcliente")]
        public ResponseHeader ActualizarCliente([FromBody]   Cliente clientes, int IdClientes)
        {
            return _unit.Clientes.ActualizarCliente(clientes, IdClientes);
        }

        [HttpPut]
        [Route("ActualizarEstado")]
        public ResponseHeader ActualizarEstado(int IdClientes, int estado)
        {
            return _unit.Clientes.Actualizarestado( IdClientes, estado);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unit.Clientes.getClientes());
        }



        /* [HttpDelete("{id}")]
         public void Delete(int id)
         {
              _unit.Clientes.Delete(_unit.Clientes.GetById(id));
         }*/
    }
}
