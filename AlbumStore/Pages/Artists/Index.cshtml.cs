using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlbumStore.Models;

namespace AlbumStore.Pages.Artists
{
    public class IndexModel : PageModel
    {
        private readonly AlbumStore.Models.AlbumContext _context;

        public IndexModel(AlbumStore.Models.AlbumContext context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; }

        public async Task OnGetAsync()
        {
			Artist = await _context.Artists.Include(g => g.Genre).AsNoTracking().ToListAsync();
		}
    }
}
