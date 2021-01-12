using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BenITHome.Data;
using BenITHome.Models;

namespace BenITHome.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly BenITHome.Data.BenITHomeContext _context;

        public IndexModel(BenITHome.Data.BenITHomeContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Article.ToListAsync();
        }
    }
}
