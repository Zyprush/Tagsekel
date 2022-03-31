#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tagsekel.Data;
using Tagsekel.classpage;

namespace Tagsekel.Pages.Drivers
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly Tagsekel.Data.TagsekelContext _context;

        public IndexModel(Tagsekel.Data.TagsekelContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get; set; }
            [BindProperty(SupportsGet = true)]
            public string SearchString { get; set; }
            public SelectList Name { get; set; }
            [BindProperty(SupportsGet = true)]
             string Address { get; set; }


        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
            var name = from m in _context.Class
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                name = name.Where(s => s.Name.Contains(SearchString));
            }

            Class = await name.ToListAsync();
        }
    }
#pragma warning disable CS8618
#pragma warning disable CS8604
}
