using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExercises.Pages
{
    public class RNGModel : PageModel
    {
        Random rnd = new Random();
        public int RandomNumber { get; set; }
        public String Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToString("HH:mm");
            RandomNumber = rnd.Next(0, 300000);
        }
    }
}
