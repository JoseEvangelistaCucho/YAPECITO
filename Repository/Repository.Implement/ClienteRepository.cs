using Dapper;
using Microsoft.Data.SqlClient;
using System;
using YAPECITO.Models;
using YAPECITO.ModelService;

namespace YAPECITO.Repository.Repository.Implement
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(string connectionString) : base(connectionString)
        {
        }

        public ResponseHeader GetByDocumento(string tipo, string nroDocumento)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.TIPO, tipo);
                parameters.Add(Constante.NRODOCUMENTO, nroDocumento);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                Cliente responsedetail = connection.QueryFirstOrDefault<Cliente>
                (Constante.NAME_USP_BUSCAR_BY_DOCUMENTO, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }

        public ResponseHeader CrearCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                int idClienteGenerado = 0;
                parameters.Add(Constante.TIPODOCUMENTO, cliente.TipoDocumento);
                parameters.Add(Constante.NRODOCUMENTO, cliente.NroDocumento);
                parameters.Add(Constante.PAISDOCUMENTO, cliente.PaisDocumento);
                parameters.Add(Constante.NOMBRE, cliente.Nombre);
                parameters.Add(Constante.APELLIDOPATERNO, cliente.ApellidoPaterno);
                parameters.Add(Constante.APELLIDOMATERNO, cliente.ApellidoMaterno);
                parameters.Add(Constante.FECHANACIMIENTO, cliente.FechaNacimiento);
                parameters.Add(Constante.FECHACADUCIDAD, cliente.FechaCaducidad);
                parameters.Add(Constante.FECHAEMISION, cliente.FechaEmision);
                parameters.Add(Constante.CODPAISNACIMIENTO, cliente.CodPaisNacimiento);
                parameters.Add(Constante.CODPAISNACIONALIDAD, cliente.CodPaisNacionalidad);
                parameters.Add(Constante.SEXO, cliente.Sexo);
                parameters.Add(Constante.OCUPACION, cliente.Ocupacion);
                parameters.Add(Constante.CODPAISRESIDENCIA, cliente.CodPaisResidencia);
                parameters.Add(Constante.DIRECCION1, cliente.Direccion1);
                parameters.Add(Constante.CODPOSTAL, cliente.CodPostal);
                parameters.Add(Constante.DEPARTAMENTO, cliente.Departamento);
                parameters.Add(Constante.PROVINCIA, cliente.Provincia);
                parameters.Add(Constante.DISTRITO, cliente.Distrito);
                parameters.Add(Constante.EMAIL, cliente.Email);
                parameters.Add(Constante.CODMOVILPAIS, cliente.CodMovilPais);
                parameters.Add(Constante.NUMEROTELFMOVIL, cliente.NumeroTelfMovil);
                parameters.Add(Constante.ESTADOCLIENTE, cliente.EstadoCliente);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.IDCLIENTE, idClienteGenerado, System.Data.DbType.Int32, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_CREAR_CLIENTE, parameters, commandType: System.Data.CommandType.StoredProcedure);

                idClienteGenerado = parameters.Get<Int32>(Constante.IDCLIENTE);
                respuesta.Estado = parameters.Get<String>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
                cliente.IdCliente = idClienteGenerado;
                respuesta.Detalle.Add(cliente.GetType().Name, cliente);

                return respuesta;
            }
        }


        public ResponseHeader ActualizarCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.IDCLIENTE, cliente.IdCliente);
                parameters.Add(Constante.TIPODOCUMENTO, cliente.TipoDocumento);
                parameters.Add(Constante.NRODOCUMENTO, cliente.NroDocumento);
                parameters.Add(Constante.PAISDOCUMENTO, cliente.PaisDocumento);
                parameters.Add(Constante.NOMBRE, cliente.Nombre);
                parameters.Add(Constante.APELLIDOPATERNO, cliente.ApellidoPaterno);
                parameters.Add(Constante.APELLIDOMATERNO, cliente.ApellidoMaterno);
                parameters.Add(Constante.FECHANACIMIENTO, cliente.FechaNacimiento);
                parameters.Add(Constante.FECHACADUCIDAD, cliente.FechaCaducidad);
                parameters.Add(Constante.FECHAEMISION, cliente.FechaEmision);
                parameters.Add(Constante.CODPAISNACIMIENTO, cliente.CodPaisNacimiento);
                parameters.Add(Constante.CODPAISNACIONALIDAD, cliente.CodPaisNacionalidad);
                parameters.Add(Constante.SEXO, cliente.Sexo);
                parameters.Add(Constante.OCUPACION, cliente.Ocupacion);
                parameters.Add(Constante.CODPAISRESIDENCIA, cliente.CodPaisResidencia);
                parameters.Add(Constante.DIRECCION1, cliente.Direccion1);
                parameters.Add(Constante.CODPOSTAL, cliente.CodPostal);
                parameters.Add(Constante.DEPARTAMENTO, cliente.Departamento);
                parameters.Add(Constante.PROVINCIA, cliente.Provincia);
                parameters.Add(Constante.DISTRITO, cliente.Distrito);
                parameters.Add(Constante.EMAIL, cliente.Email);
                parameters.Add(Constante.CODMOVILPAIS, cliente.CodMovilPais);
                parameters.Add(Constante.NUMEROTELFMOVIL, cliente.NumeroTelfMovil);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                connection.Query(Constante.NAME_USP_ACTUALIZAR_CLIENTE, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<String>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<String>(Constante.OV_MESSAGE);
                respuesta.Detalle.Add(cliente.GetType().Name, cliente);
                return respuesta;
            }
        }

    }
}