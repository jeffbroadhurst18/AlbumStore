using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlbumStore.Models;

namespace AlbumStore.Pages.Genres
{
    public class CreateModel : PageModel
    {
        private readonly AlbumStore.Models.AlbumContext _context;

        public CreateModel(AlbumStore.Models.AlbumContext context)
        {
            _context = context;
        }


		[BindProperty]
		public Genre Genre { get; set; }

		public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Genres.Add(Genre);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}