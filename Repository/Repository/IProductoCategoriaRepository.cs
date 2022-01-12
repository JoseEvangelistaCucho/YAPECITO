using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YAPECITO.ModelService;
using YAPECITO.Models;

namespace YAPECITO.Repository.Repository
{
    public interface IProductoCategoriaRepository:IRepository<ProductoCategoria>
    {
        ResponseHeader ListarProductoCategoria(int idCategoria);
        ResponseHeader EliminarProducto(int idProducto);
        ResponseHeader InsertarProducto(Producto producto);
    }
}