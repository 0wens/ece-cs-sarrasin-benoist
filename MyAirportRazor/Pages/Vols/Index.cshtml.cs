using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PSB.MyAirport.EF;

namespace PSB.MyAirport.Razor.Pages.Vols
{
    public class IndexModel : PageModel
    {
        private readonly PSB.MyAirport.EF.MyAirportContext _context;

        public IndexModel(PSB.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Vol> Vol { get;set; }

        public async Task OnGetAsync()
        {
            Vol = await _context.Vols.ToListAsync();
        }
    }
}
