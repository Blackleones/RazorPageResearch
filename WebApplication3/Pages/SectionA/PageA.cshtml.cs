using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorResearch.Core.SectionA;

namespace WebApplication3.Pages.SectionA
{
    /// <summary>
    /// override partial
    /// </summary>
    public class CustomPageAModel : PageAModel
    {
        public override void OnGet()
        {
        }
    }
}