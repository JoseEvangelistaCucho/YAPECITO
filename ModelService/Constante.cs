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
     
        ////dbo.uspCrearCliente
        public const string NAME_USP_CREARCLIENTES = "dbo.USP_CREARCLIENTES";
        public const string NAME_USP_ACTUALIZARCLIENTES = "dbo.USP_ACTUALIZARCLIENTES";
        public const string NAME_USP_ACTUALIZARESTADO= "dbo.USP_ACTUALIZARESTADO";
        public const string NAME_USP_ACTUALIZAcliente = "dbo.USP_ACTUALIZARcliente";
        public const string NAME_USP_busardni = "dbo.uspBuscardni";
        public const string IDCLIENTES = "@IdClientes";
        public const string email = "@email";
        public const string Contraseña = "@Contraseña";
        public const string Direccion = "@Direccion";
        public const string Pais = "@Pais";
        public const string ubigeo = "@ubigeo";
        public const string estado = "@estado";
        public const string DNI = "@DNI";
        public const string telefono = "@telefono";
        


        public const string NAME_SP_ListarClientes = "dbo.SP_ListarClientes";

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



        ////dbo.uspBuscarClienteByDocumento
        public const string NAME_USP_BUSCAR_CLIENTES = "dbo.uspBuscarClientes";
     
        public const string NombreCompleto = "@NombreCompleto";
        public const string OV_ESTADO = "@OV_ESTADO";
        public const string OV_MESSAGE = "@OV_MESSAGE";
        public const string OK = "0";
        ///

    }
}
