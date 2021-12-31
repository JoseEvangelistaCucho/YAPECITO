using YAPECITO.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAPECITO.ModelService;

namespace YAPECITO.Repository.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        ResponseHeader GetByDocumento(string tipo, string nroDocumento);
        ResponseHeader CrearCliente(Cliente cliente);
        ResponseHeader ActualizarCliente(Cliente cliente);
      
    }
}
