using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Models
{
	public class Format
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<Product> Products { get; set; }
	}
}
