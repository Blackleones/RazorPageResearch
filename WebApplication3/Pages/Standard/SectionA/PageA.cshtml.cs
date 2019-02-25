using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages.Standard.SectionA
{
    public class PageAModel : PageModel
    {
        public string Hi = "Hello";

        public virtual void OnGet()
        {

        }
    }
}