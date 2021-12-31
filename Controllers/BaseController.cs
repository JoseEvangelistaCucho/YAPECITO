using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using YAPECITO.Repository.Repository.Implement;

namespace YAPECITO.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class BaseController : ControllerBase
    {
        protected IUnitOfWork _unit;
        public BaseController(IUnitOfWork unit)
        {
            _unit = unit;
        }
    }
}
