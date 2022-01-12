using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YAPECITO.ModelService;
using YAPECITO.Models;

namespace YAPECITO.Repository.Repository
{
    public interface IUbigeoRepository: IRepository<Ubigeo>
    {
        ResponseHeader getBuscarUbigeo(string IdDepartamento);
    }
}