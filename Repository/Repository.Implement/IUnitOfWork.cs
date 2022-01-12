using YAPECITO.Repository.Repository;

namespace YAPECITO.Repository.Repository.Implement
{
    public interface IUnitOfWork
    {
        IClienteRepository Clientes { get; }
        IUbigeoRepository Ubigeo { get; }
        IProductoCategoriaRepository ProductoCategoria { get; }
    }
}
