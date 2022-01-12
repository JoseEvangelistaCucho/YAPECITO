using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using YAPECITO.Models;
using YAPECITO.ModelService;

namespace YAPECITO.Repository.Repository.Implement
{
    public class ProductoCategoriaRepository : Repository<ProductoCategoria>, IProductoCategoriaRepository
    {
        public ProductoCategoriaRepository(string connectionString) : base(connectionString)
        {
        }
        public ResponseHeader ListarProductoCategoria(int idCategoria)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.IDCATEGORIA, idCategoria);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                ProductoCategoria responsedetail = connection.QueryFirstOrDefault<ProductoCategoria>
                (Constante.NAME_USP_LISTAR_PRODUCTO_CATEGORIA, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }

        public ResponseHeader EliminarProducto(int idProducto)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.IDPRODUCTO, idProducto);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                Producto responsedetail = connection.QueryFirstOrDefault<Producto>
                (Constante.NAME_USP_ELIMINAR_PRODUCTO, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                //if (respuesta.Estado.Equals(Constante.OK))
                //    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }
        public ResponseHeader InsertarProducto(Producto producto)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                // int idClienteGenerado = 0;
                parameters.Add(Constante.NOMBREPRODUCTO, producto.nombreProducto);
                parameters.Add(Constante.PRECIO, producto.precio);
                parameters.Add(Constante.DESCRIPCION, producto.descripcion);
                //parameters.Add(Constante.FECHACREACION, producto.fechaCreacion);
                parameters.Add(Constante.STOCK, producto.stock);
               
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);
              //  parameters.Add(Constante.IDCLIENTE, idClienteGenerado, System.Data.DbType.Int32, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_INSERTAR_PRODUCTO, parameters, commandType: System.Data.CommandType.StoredProcedure);
                
                respuesta.Estado = parameters.Get<String>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
                respuesta.Detalle.Add(producto.GetType().Name, producto);

                return respuesta;
            }
        }
    }
}
