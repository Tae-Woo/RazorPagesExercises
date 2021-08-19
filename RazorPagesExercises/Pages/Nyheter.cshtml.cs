using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExercises.Pages
{
    public class NyheterModel : PageModel
    {
        public List<NewsListItem> News { get; set; }
        public class NewsListItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public void OnGet()
        {
            News = new List<NewsListItem> {
            new NewsListItem { Name = "Lorem Ipsum 1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec molestie sagittis elit, a sodales justo sagittis eget." },
            new NewsListItem { Name = "Lorem Ipsum 2", Description = "Nam faucibus enim pellentesque pulvinar pulvinar." },
            new NewsListItem { Name = "Lorem Ipsum 3", Description = "Etiam pulvinar massa dui, non luctus dui interdum in. Aliquam a vehicula velit, nec tincidunt ipsum." },
            new NewsListItem { Name = "Lorem Ipsum 4", Description = "Morbi faucibus faucibus justo, ultricies egestas odio interdum sit amet. Curabitur dictum urna urna, imperdiet porta justo lacinia non." }
        };
        }
    }
}
