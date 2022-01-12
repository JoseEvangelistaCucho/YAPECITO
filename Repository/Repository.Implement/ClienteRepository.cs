using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YAPECITO.Models;
using YAPECITO.ModelService;

namespace YAPECITO.Repository.Repository.Implement
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(string connectionString) : base(connectionString)
        {
        }

        public ResponseHeader ActualizarCliente(Cliente clientes, int IdClientes)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.NombreCompleto, clientes.NombreCompleto);
                parameters.Add(Constante.DNI, clientes.DNI);
                parameters.Add(Constante.telefono, clientes.telefono);
                parameters.Add(Constante.email, clientes.email);
                parameters.Add(Constante.Contraseña, clientes.contraseña);
                parameters.Add(Constante.Direccion, clientes.Direccion);
                parameters.Add(Constante.Pais, clientes.Pais);
                parameters.Add(Constante.ubigeo, clientes.ubigeo);
                parameters.Add(Constante.estado, clientes.estado);
                parameters.Add(Constante.IDCLIENTES, IdClientes);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_ACTUALIZARCLIENTES, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
                respuesta.Detalle.Add(clientes.GetType().Name, clientes);
                return respuesta;
            }
        }

        public ResponseHeader Actualizarestado(int IdClientes, int estado)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.IDCLIENTES, IdClientes);
                parameters.Add(Constante.estado, estado);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_ACTUALIZARESTADO, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
   
                return respuesta;
            }
        }

        public ResponseHeader buscardni(string NOMBRE_o_DNI)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
             
                parameters.Add(Constante.NombreCompleto, NOMBRE_o_DNI);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                IEnumerable<Cliente> responsedetail = connection.Query<Cliente>
               (Constante.NAME_USP_busardni, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }

        public ResponseHeader CrearCliente(Cliente clientes)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();

                parameters.Add(Constante.NombreCompleto, clientes.NombreCompleto);
                parameters.Add(Constante.DNI, clientes.DNI);
                parameters.Add(Constante.telefono, clientes.telefono);
                parameters.Add(Constante.email, clientes.email);
                parameters.Add(Constante.Contraseña, clientes.contraseña);
            
                parameters.Add(Constante.Direccion, clientes.Direccion);
                parameters.Add(Constante.Pais, clientes.Pais);
                parameters.Add(Constante.ubigeo, clientes.ubigeo);
                parameters.Add(Constante.estado, clientes.estado);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                connection.Query(Constante.NAME_USP_CREARCLIENTES, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
         
                respuesta.Detalle.Add(clientes.GetType().Name, clientes);

                return respuesta;
            }
        }

        public ResponseHeader GetByDocumento(string NombreCompleto)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.NombreCompleto, NombreCompleto);
       
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                 IEnumerable<Cliente> responsedetail = connection.Query<Cliente>
                (Constante.NAME_USP_BUSCAR_CLIENTES, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }

        public ResponseHeader getClientes( )
        {
            string sql = "Select * from clientes";
            using (var connection = new SqlConnection(_connectionString))
            {
                var res = new ResponseHeader();
                var Opedido = connection.Query<Cliente>(sql);

                if (Opedido.Count() > 0)
                {
                    res.Estado = "0";
                    res.Mensaje = "todo esta perfecto ";
                    res.Detalle.Add("Pedido", Opedido);
                }
                else if (Opedido.Count() < 0)
                {
                    res.Estado = "1";
                    res.Mensaje = "error al Procesar";
                }
              
                return res;
            }
        }
    }
}