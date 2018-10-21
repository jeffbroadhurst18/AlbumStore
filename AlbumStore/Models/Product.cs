using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.Models
{
	public class Product
	{
		public int ID { get; set; }

		[Required]
		public int AlbumID { get; set; }
		[Required]
		public int FormatID { get; set; }

		public Album Album { get; set; }
		public Format Format { get; set; }
	}
}
