

using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace YAPECITO.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [ExplicitKey]//[Key] //Se pone "Key" cuando la llave es un id autogenerado por la BD, si no fuera así se pone "ExplicitKy"
        internal int IdCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string PaisDocumento { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaCaducidad { get; set; }
        public string FechaEmision { get; set; }
        public string CodPaisNacimiento { get; set; }
        public string CodPaisNacionalidad { get; set; }
        public string Sexo { get; set; }
        public string Ocupacion { get; set; }
        public string CodPaisResidencia { get; set; }
        public string Direccion1 { get; set; }
        public string CodPostal { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Email { get; set; }
        public string CodMovilPais { get; set; }
        public string NumeroTelfMovil { get; set; }
        public string CreadoFecha { get; set; }
        public string EstadoCliente { get; set; }

    }
}
