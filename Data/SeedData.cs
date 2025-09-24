using Microsoft.EntityFrameworkCore;
using MvcMovies.Models;

namespace MvcMovies.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMoviesContext>>())) 
        {
            if (context.Movie.Any()) return;

            context.Movie.AddRange(
                new Movie
                {
                    Title = "Cloud Atlas",
                    ReleaseDate = DateTime.Parse("2012-09-08"),
                    Genre = "Science Fiction",
                    Price = 12.99M,
                },
                new Movie
                {
                    Title = "Kill Bill (volume 1.)",
                    ReleaseDate = DateTime.Parse("2003-10-10"),
                    Genre = "Action",
                    Price = 8.49M,
                },
                new Movie
                {
                    Title = "Kill Bill (volume 2.)",
                    ReleaseDate = DateTime.Parse("2004-04-08"),
                    Genre = "Action",
                    Price = 8.49M,
                },
                new Movie
                {
                    Title = "Metropolis",
                    ReleaseDate = DateTime.Parse("1927-01-10"),
                    Genre = "Silent Sci-Fi",
                    Price = 4.99M,
                },
                new Movie
                {
                    Title = "Twelve Monkeys",
                    ReleaseDate = DateTime.Parse("1995-12-29"),
                    Genre = "Thriller",
                    Price = 14.99M,
                });
            context.SaveChanges();
        }
    }
}