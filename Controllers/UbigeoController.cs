using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YAPECITO.Models;
using YAPECITO.ModelService;
using YAPECITO.Repository.Repository.Implement;

namespace YAPECITO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UbigeoController : BaseController
    {
        public UbigeoController(IUnitOfWork unit) : base(unit)
        {
        }   

        [HttpGet("{IdDepartamento}")]
        public IActionResult Get(string IdDepartamento)
        {
            return Ok(_unit.Ubigeo.getBuscarUbigeo(IdDepartamento));
        }
    }
}
