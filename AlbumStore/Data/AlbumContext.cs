using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AlbumStore.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext (DbContextOptions<AlbumContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
		public DbSet<Artist> Artists { get; set; }
		public DbSet<Decade> Decades { get; set; }
		public DbSet<Format> Formats { get; set; }
		public DbSet<Album> Albums { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}

