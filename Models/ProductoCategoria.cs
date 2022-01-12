using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAPECITO.Models
{
    public class ProductoCategoria
    {
        internal int IdProductoCategoria { get; set; }
        public string producto { get; set; }
        public string categoria { get; set; }
    }
    public class Producto
    {
        internal int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public double precio { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int stock { get; set; }
    }
    public class Categoria
    {
        internal int idCategorias { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
    }
}