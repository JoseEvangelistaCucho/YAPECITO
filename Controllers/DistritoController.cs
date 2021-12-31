using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAPECITO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
