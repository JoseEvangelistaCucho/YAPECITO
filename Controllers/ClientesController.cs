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
// private readonly YAPECITOContext _context;
       /* public ClientesController(YAPECITOContext context)
        {
            _context = context;
        }*/
        public ClientesController(IUnitOfWork unit) : base(unit)
        {
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
           
            return _unit.Clientes.GetList();
        }

        [HttpGet("{tipo}/{nroDocumento}")]
        public IActionResult Get(string tipo, string nroDocumento)
        {


            return Ok(_unit.Clientes.GetByDocumento(tipo, nroDocumento));
        }

        [HttpPost("crearCliente")]
        public ResponseHeader CrearCliente([FromBody] Cliente cliente) //El [FromBody] es opcional
        {

            return _unit.Clientes.CrearCliente(cliente);
        }
        [HttpPut]
        [Route("actualizarCliente")]
        public ResponseHeader ActualizarCliente([FromBody] Cliente cliente)
        {
            return _unit.Clientes.ActualizarCliente(cliente);
        }


       /* [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _unit.Clientes.Delete(_unit.Clientes.GetById(id));
        }*/
    }
}
