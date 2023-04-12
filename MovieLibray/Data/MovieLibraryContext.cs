using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieLibrary.Models;

namespace MovieLibrary.Data
{
    public class MovieLibraryContext : DbContext
    {
        public MovieLibraryContext (DbContextOptions<MovieLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<MovieLibrary.Models.Movie> Movie { get; set; } = default!;
    }
}
