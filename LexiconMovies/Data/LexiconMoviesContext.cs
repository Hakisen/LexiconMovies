using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LexiconMovies.Models
{
    public class LexiconMoviesContext : DbContext
    {
        public LexiconMoviesContext (DbContextOptions<LexiconMoviesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "AI", Genre = "Science Fiction", Price = 140, ReleaseDate = DateTime.Parse("2010-2-10"), Rating = 2.5f },
                new Movie { Id = 2, Title = "Explorer", Genre = "Science Fiction", Price = 230, ReleaseDate = DateTime.Parse("2010-2-10"), Rating = 2.2f },
                new Movie { Id = 3, Title = "Pink Panther", Genre = "Comedy", Price = 125, ReleaseDate = DateTime.Parse("1980-7-11"), Rating = 4.1f},
                new Movie { Id = 4, Title = "Saw 4", Genre = "Horror", Price = 220, ReleaseDate = DateTime.Parse("2003-12-18"), Rating = 1.7f },
                new Movie { Id = 5, Title = "Killer Tomatoes", Genre = "Splatter", Price = 99, ReleaseDate = DateTime.Parse("198-7-5"), Rating = 3.4f },
                new Movie { Id = 6, Title = "Horse Whisperer", Genre = "Drama", Price = 340, ReleaseDate = DateTime.Parse("2008-3-22"), Rating = 3.8f }
                );

            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<LexiconMovies.Models.Movie> Movie { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}
