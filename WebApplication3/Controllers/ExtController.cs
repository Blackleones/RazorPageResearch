using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("[controller]/[action]", Order = 0)]
    public class ExtController : Controller
    {
        [HttpGet]
        public IActionResult A()
        {
            return Ok("int a");
        }
    }
}