using MovieApp.Models;

namespace MovieApp.Data;

public static class MovieInitializer
{
    public static void Initialize(MovieAppContext context)
    {
        context.Database.EnsureCreated();

        // Check if movies already exist
        if (context.Movie.Any())
        {
            return;
        }

        var movies = new Movie[]
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                ReleaseDate = new DateTime(1994, 10, 14),
                Genre = "Drama",
                Price = 14.99m,
                Rating = "R"
            },
            new Movie
            {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 7, 18),
                Genre = "Action",
                Price = 12.99m,
                Rating = "PG-13"
            },
            new Movie
            {
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                Genre = "Sci-Fi",
                Price = 13.99m,
                Rating = "PG-13"
            },
            new Movie
            {
                Title = "Pulp Fiction",
                ReleaseDate = new DateTime(1994, 10, 14),
                Genre = "Crime",
                Price = 14.99m,
                Rating = "R"
            },
            new Movie
            {
                Title = "Forrest Gump",
                ReleaseDate = new DateTime(1994, 7, 6),
                Genre = "Drama",
                Price = 12.99m,
                Rating = "PG-13"
            },
            // JayCode's favorite movies
            new Movie
            {
                Title = "Interstellar",
                ReleaseDate = new DateTime(2014, 11, 7),
                Genre = "Sci-Fi",
                Price = 15.99m,
                Rating = "PG-13"
            },
            new Movie
            {
                Title = "The Matrix",
                ReleaseDate = new DateTime(1999, 3, 31),
                Genre = "Action",
                Price = 11.99m,
                Rating = "R"
            },
            new Movie
            {
                Title = "Spirited Away",
                ReleaseDate = new DateTime(2001, 7, 20),
                Genre = "Animation",
                Price = 10.99m,
                Rating = "PG"
            }
        };

        foreach (Movie movie in movies)
        {
            context.Movie.Add(movie);
        }
        context.SaveChanges();
    }
}
