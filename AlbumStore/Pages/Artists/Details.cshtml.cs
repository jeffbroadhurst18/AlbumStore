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
    public class DetailsModel : PageModel
    {
        private readonly AlbumStore.Models.AlbumContext _context;

        public DetailsModel(AlbumStore.Models.AlbumContext context)
        {
            _context = context;
        }

        public Artist Artist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

			Artist = await _context.Artists.FirstOrDefaultAsync(m => m.ID == id);

			if (Artist == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
