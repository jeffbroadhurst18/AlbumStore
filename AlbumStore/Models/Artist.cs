using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Models
{
	public class Artist
	{
		public int ID { get; set; }

		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public int GenreID { get; set; }
		public string Country { get; set; }

		public Genre Genre { get; set; }
		public ICollection<Album> Albums { get; set; }
	}
}
