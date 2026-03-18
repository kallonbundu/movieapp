using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data;

public class MovieAppContext : DbContext
{
    public MovieAppContext(DbContextOptions<MovieAppContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; } = default!;
}
