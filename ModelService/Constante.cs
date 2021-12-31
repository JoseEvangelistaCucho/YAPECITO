using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAPECITO.ModelService
{
    public class Constante
    {
        //cliente Parametros
        ////dbo.uspBuscarClienteByDocumento
        public const string NAME_USP_BUSCAR_BY_DOCUMENTO = "dbo.uspBuscarClienteByDocumento";
        public const string TIPO = "@tipo";
        public const string NRODOCUMENTO = "@nroDocumento";
        ///
        public const string OV_ESTADO = "@OV_ESTADO";
        public const string OV_MESSAGE = "@OV_MESSAGE";
        public const string OK = "0";
        ////dbo.uspCrearCliente
        public const string NAME_USP_CREAR_CLIENTE = "dbo.uspCrearCliente";
        public const string NAME_USP_ACTUALIZAR_CLIENTE = "dbo.uspActualizarCliente";
        public const string TIPODOCUMENTO = "@TIPODOCUMENTO";
        public const string PAISDOCUMENTO = "@PAISDOCUMENTO";
        public const string NOMBRE = "@PRIMERNOMBRE";
        public const string SEGUNDONOMBRE = "@SEGUNDONOMBRE";
        public const string APELLIDOPATERNO = "@APELLIDOPATERNO";
        public const string APELLIDOMATERNO = "@APELLIDOMATERNO";
        public const string NOMBREEMPRESA = "@NOMBREEMPRESA";
        public const string FECHANACIMIENTO = "@FECHANACIMIENTO";
        public const string FECHACADUCIDAD = "@FECHACADUCIDAD";
        public const string FECHAEMISION = "@FECHAEMISION";
        public const string CODPAISNACIMIENTO = "@CODPAISNACIMIENTO";
        public const string CODPAISNACIONALIDAD = "@CODPAISNACIONALIDAD";
        public const string SEXO = "@SEXO";
        public const string OCUPACION = "@OCUPACION";
        public const string PUESTOCARGO = "@PUESTOCARGO";
        public const string CODPAISRESIDENCIA = "@CODPAISRESIDENCIA";
        public const string DIRECCION1 = "@DIRECCION1";
        public const string FLAGOTROPAIS = "@FLAGOTROPAIS";
        public const string CODPOSTAL = "@CODPOSTAL";
        public const string DEPARTAMENTO = "@DEPARTAMENTO";
        public const string PROVINCIA = "@PROVINCIA";
        public const string DISTRITO = "@DISTRITO";
        public const string EMAIL = "@EMAIL";
        public const string FLAGTELEFONO = "@FLAGTELEFONO";
        public const string CODTELFPAIS = "@CODTELFPAIS";
        public const string NUMEROTELEFONO = "@NUMEROTELEFONO";
        public const string FLAGTELFMOVIL = "@FLAGTELFMOVIL";
        public const string CODMOVILPAIS = "@CODMOVILPAIS";
        public const string NUMEROTELFMOVIL = "@NUMEROTELFMOVIL";
        public const string PEP = "@PEP";
        public const string ESTADOCLIENTE = "@ESTADOCLIENTE";
        public const string IDCLIENTE = "@IDCLIENTE";
        public const int IDCLIENTEVALUE = 0;
    }
}
