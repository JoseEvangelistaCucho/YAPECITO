
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
        }

        public IClienteRepository Clientes { get; private set; }
    }
}
