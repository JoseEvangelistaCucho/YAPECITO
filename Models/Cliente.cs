

using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace YAPECITO.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [ExplicitKey]//[Key] //Se pone "Key" cuando la llave es un id autogenerado por la BD, si no fuera así se pone "ExplicitKy"
        internal int IdClientes { get; set; }
        public string NombreCompleto { get; set; }
        public int DNI { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
       
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public string ubigeo { get; set; }
        public int estado { get; set; }



    }
}
