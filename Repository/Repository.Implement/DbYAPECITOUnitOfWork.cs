
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAPECITO.Repository.Repository.Implement
{
    public class DbYAPECITOUnitOfWork : IUnitOfWork
    {
        public DbYAPECITOUnitOfWork(string connectionString)
        {
            Clientes = new ClienteRepository(connectionString);
            Ubigeo = new UbigeoRepository(connectionString);
            ProductoCategoria = new ProductoCategoriaRepository(connectionString);
        }
        public IClienteRepository Clientes { get; private set; }
        public IUbigeoRepository Ubigeo { get; private set; }
        public IProductoCategoriaRepository ProductoCategoria { get; private set; }
    }
}
