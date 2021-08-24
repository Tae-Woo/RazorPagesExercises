using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExercises.Services;

namespace RazorPagesExercises.Pages
{
    public class ShowarticleModel : PageModel
    {
        private readonly IKrisInfo _krisInfoService;
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }

        public ShowarticleModel(IKrisInfo krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }

        public void OnGet(string articleid)
        {
            var krisInfo = _krisInfoService.GetKrisInformation(articleid);
            Title = krisInfo.Title;
            Text = krisInfo.Text;
            Link = krisInfo.LinkUrl;
        }
    }
}
