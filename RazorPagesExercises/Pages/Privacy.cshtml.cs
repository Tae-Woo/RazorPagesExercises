using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesExercises.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string CurrentWeekDay { get; set; }

        public void OnGet()
        {
            CurrentWeekDay = DateTime.Now.DayOfWeek.ToString();

            var svenska = new CultureInfo("sv-SE");
            CurrentWeekDay = DateTime.Now.ToString("dddd", svenska);
        }
    }
}
