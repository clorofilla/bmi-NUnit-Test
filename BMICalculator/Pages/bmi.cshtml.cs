using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMICalculator.Pages
{
    public class BmiModel : PageModel
    {
        [BindProperty]
        [ExcludeFromCodeCoverage]
        public BMI BMI { get; set; }
    }
}