using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAPECITO.Repository.Repository
{
    public interface IRepository<T> where T : class
    {
        int Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);       
        IEnumerable<T> GetList();
        T GetById(int id);
        T GetById(string id);
    }
}
