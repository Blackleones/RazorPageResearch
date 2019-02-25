using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Pages.Standard.SectionA;

namespace WebApplication3.Pages.Custom.SectionA
{
    public class CustomPageA : PageAModel
    {
        public override void OnGet()
        {
            Hi = "Hello from Custom";
        }
    }
}
