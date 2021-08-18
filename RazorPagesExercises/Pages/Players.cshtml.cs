using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExercises.Pages
{
    public class PlayersModel : PageModel
    {
        public List<string> Players { get; set; }

        public PlayersModel()
        {
            Players = new List<string>
            {
                "Player 1",
                "Player 2",
                "Player 3",
                "Player 4"
            };
        }
        public void OnGet()
        {
        }
    }
}
