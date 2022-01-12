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
    public class UbigeoRepository : Repository<Ubigeo>, IUbigeoRepository
    {
        public UbigeoRepository(string connectionString) : base(connectionString)
        {
        }
        public ResponseHeader getBuscarUbigeo(string IdDepartamento)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var respuesta = new ResponseHeader();
                var parameters = new DynamicParameters();
                parameters.Add(Constante.IDDEPARTAMENTO, IdDepartamento);
                parameters.Add(Constante.OV_ESTADO, Constante.OV_ESTADO, System.Data.DbType.String, System.Data.ParameterDirection.Output);
                parameters.Add(Constante.OV_MESSAGE, Constante.OV_MESSAGE, System.Data.DbType.String, System.Data.ParameterDirection.Output);

                Ubigeo responsedetail = connection.QueryFirstOrDefault<Ubigeo>
                (Constante.NAME_USP_BUSCAR_UBIGEO, parameters, commandType: System.Data.CommandType.StoredProcedure);

                respuesta.Estado = parameters.Get<string>(Constante.OV_ESTADO);
                respuesta.Mensaje = parameters.Get<string>(Constante.OV_MESSAGE);

                if (respuesta.Estado.Equals(Constante.OK))
                    respuesta.Detalle.Add(responsedetail.GetType().Name, responsedetail);

                return respuesta;
            }
        }
    }
}
