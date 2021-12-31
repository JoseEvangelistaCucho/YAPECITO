using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAPECITO.ModelService
{
    public class ResponseHeader
    {
        public string Estado { get; set; }

        public string Mensaje { get; set; }

        public Dictionary<string, Object> Detalle { get; set; } = new Dictionary<string, object>();

    }
}
