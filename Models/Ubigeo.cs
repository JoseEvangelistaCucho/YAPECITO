using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAPECITO.Models
{
    public class Ubigeo
    {
        public string id { get; set; }
        public string descripcion { get; set; }
        //public Distrito distrito { get; set; }
        //public Departamento departamento { get; set; }
        //public Provincia provincia { get; set; }
    }
    public class Distrito
    {
        public int IdDistrito { get; set; }
        public string Descripcion { get; set; }
    }
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Descripcion { get; set; }
    }
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; }
    }
}
