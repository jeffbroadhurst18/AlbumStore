using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Models
{
	public class Album
	{
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public int Year { get; set; }
		public int ArtistID { get; set; }
		public int DecadeID { get; set; }

		public Artist Artist { get; set; }
		public Decade Decade { get; set; }
	}
}
