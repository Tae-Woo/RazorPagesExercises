using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExercises.Pages
{
    public class MyPageModel : PageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public MyPageModel()
        {
            Name = "Kalle";
            Age = 27;
        }
        public void OnGet()
        {
            
        }
    }
}
