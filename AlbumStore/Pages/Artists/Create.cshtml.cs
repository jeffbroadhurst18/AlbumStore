using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlbumStore.Models;

namespace AlbumStore.Pages.Artists
{
    public class CreateModel : GenreNamePageModel
    {
        private readonly AlbumContext _context;

        public CreateModel(AlbumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
			PopulateGenresDropDownList(_context);
			return Page();
        }

        [BindProperty]
        public Artist Artist { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


			var emptyArtist = new Artist();

			if (await TryUpdateModelAsync(
				emptyArtist, "artist", s => s.Name, s => s.Description, s => s.Country, s => s.GenreID))
			{
				_context.Artists.Add(emptyArtist);
				await _context.SaveChangesAsync();
				return RedirectToPage("./Index");
			}

			PopulateGenresDropDownList(_context, emptyArtist.GenreID); //Re-display with the same value displayed

			return Page();
        }
    }
}