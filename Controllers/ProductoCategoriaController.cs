using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YAPECITO.Models;
using YAPECITO.ModelService;
using YAPECITO.Repository.Repository.Implement;

namespace YAPECITO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoCategoriaController : BaseController
    {
        public ProductoCategoriaController(IUnitOfWork unit) : base(unit)
        {
        }

        [HttpGet("Listar/{idCategoria}")]
        public ResponseHeader GetListarProductoPorCategoria(int idCategoria)
        {
            return _unit.ProductoCategoria.ListarProductoCategoria(idCategoria);
        }
        [HttpGet("Eliminar/{idProducto}")]
        public ResponseHeader EliminarProducto(int idProducto)
        {
            return _unit.ProductoCategoria.EliminarProducto(idProducto);
        }
        [HttpPost("insertarProducto")]
        public ResponseHeader InsertarProducto(Producto producto) //El [FromBody] es opcional
        {
            return _unit.ProductoCategoria.InsertarProducto(producto);
        }
    }
}