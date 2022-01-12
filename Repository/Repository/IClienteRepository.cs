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

        ResponseHeader getClientes();
        ResponseHeader GetByDocumento(string NombreCompleto);
        ResponseHeader buscardni( string NOMBRE_o_DNI);
        ResponseHeader CrearCliente(Cliente clientes);
        ResponseHeader ActualizarCliente(Cliente clientes,int IdClientes);
        ResponseHeader Actualizarestado( int IdClientes, int estado);


    }
}
