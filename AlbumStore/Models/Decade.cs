using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Models
{
	public class Decade
	{
		public int ID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int StartYear { get; set; }

		[Required]
		public int EndYear { get; set; }
	}
}
