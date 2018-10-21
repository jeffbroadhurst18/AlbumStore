using AlbumStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Data
{
	public class DbInitialiser
	{
		public static async void Initialise(AlbumContext context)
		{
			if (context.Genres.Any())
			{
				return;
			}

			var genres = new Genre[]
			{
				new Genre { Name="Prog Rock"},
				new Genre { Name="Post Rock"},
				new Genre {Name = "Rap"},
				new Genre {Name = "New Wave"},
				new Genre { Name = "Punk"}
			};

			foreach (Genre g in genres)
			{
				context.Genres.Add(g);
			}
			context.SaveChanges();

			List<Genre> newGenres = await context.Genres.OrderBy(g => g.ID).ToListAsync();


			var artists = new Artist[]
			{
				new Artist { Name="Stereolab", Description="Formed in London in early nineties.",GenreID = newGenres[1].ID },
				new Artist { Name="Genesis", Description="Classic prog rockers who turned pop.", GenreID = newGenres[0].ID},
				new Artist { Name="Mogwai", Description="Glasgow band making instrumental music",GenreID = newGenres[1].ID},
				new Artist { Name="Wu Tang Clan", Description="Rap artists from Staten Island", GenreID = newGenres[2].ID},
				new Artist { Name="Sleaford Mods", Description="Nottingham based  shouters", GenreID = newGenres[2].ID},
				new Artist { Name="Sonic Youth", Description="New York No wavers", GenreID = newGenres[4].ID},
				new Artist { Name="Gang of Four", Description="Formed in Leeds in the late seventies.", GenreID = newGenres[3].ID}
			};
			foreach (Artist a in artists)
			{
				context.Artists.Add(a);
			}
			context.SaveChanges();

			var decades = new Decade[]
			{
				new Decade{ Name="Seventies",StartYear=1970,EndYear=1979},
				new Decade{ Name="Eighties",StartYear=1980,EndYear=1989},
				new Decade{ Name="Nineties",StartYear=1990,EndYear=1999},
				new Decade{ Name="Noughties",StartYear=2000,EndYear=2009},
				new Decade{ Name="Teens",StartYear=2010,EndYear=2019}
			};

			foreach (Decade d in decades)
			{
				context.Decades.Add(d);
			}
			context.SaveChanges();

			var formats = new Format[]
			{
				new Format { Name="CD",Description="Most popular physical medium"},
				new Format {Name="Vinyl", Description="Making a comeback"},
				new Format {Name="Casette",Description="Very rarely found"}
			};

			foreach (Format f in formats)
			{
				context.Formats.Add(f);
			}
			context.SaveChanges();
		}
	}
}
