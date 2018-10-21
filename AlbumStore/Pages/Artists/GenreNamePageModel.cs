using AlbumStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Pages.Artists
{
	public class GenreNamePageModel : PageModel
	{
		public SelectList GenreNameSL { get; set; }

		public void PopulateGenresDropDownList(AlbumContext _context, object selectedGenre = null)
		{
			var genresQuery = _context.Genres.OrderBy(d => d.Name);

			GenreNameSL = new SelectList(genresQuery.AsNoTracking(), "ID", "Name", selectedGenre);
			
		}
	}
}
