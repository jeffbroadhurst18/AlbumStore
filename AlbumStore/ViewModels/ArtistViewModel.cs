﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumStore.ViewModels
{
	public class ArtistViewModel
	{
		public int ArtistID {get;set;}
		public string Name { get; set; }
		public string Description { get; set; }
		public string GenreName { get; set; }
		public string Country { get; set; }
	}
}
