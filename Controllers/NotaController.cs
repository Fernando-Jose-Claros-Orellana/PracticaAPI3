using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace FJCO20240904.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotaController : ControllerBase
    {
        static List<object> data = new List<object>();

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return data;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Post(string Nombre, string Nota)
        {
            data.Add(new { Nombre, Nota });
            return Ok();
        }
    }
}