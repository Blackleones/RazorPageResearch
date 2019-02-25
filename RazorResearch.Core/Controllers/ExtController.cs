using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorResearch.Core.Controllers
{
    [Route("[controller]/[action]",  Order = 1)]
    public class ExtController : Controller
    {
        [HttpGet]
        public IActionResult A()
        {
            return Ok("ext a");
        }
    }
}
