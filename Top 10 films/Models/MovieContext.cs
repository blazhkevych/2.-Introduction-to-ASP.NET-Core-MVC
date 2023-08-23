using Microsoft.EntityFrameworkCore;

namespace Top_10_films.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                // 1.
                Movies.Add(new Movie 
                {
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Genre = "Drama",
                    ReleaseYear = 1994,
                    PosterUrl = "", // TODO: Add a URLs to a poster image
                    Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
                });
                // 2.
                Movies.Add(new Movie
                {
                    Title = "The Godfather",
                    Director = "Francis Ford Coppola",
                    Genre = "Crime",
                    ReleaseYear = 1972,
                    PosterUrl = "",
                    Description = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger."
                });
                // 3.
                Movies.Add(new Movie
                {
                    Title = "The Dark Knight",
                    Director = "Christopher Nolan",
                    Genre = "Action",
                    ReleaseYear = 2008,
                    PosterUrl = "",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
                });
                // 4.
                Movies.Add( new Movie
                {
                    Title = "The Godfather: Part II",
                    Director = "Francis Ford Coppola",
                    Genre = "Crime",
                    ReleaseYear = 1974,
                    PosterUrl = "",
                    Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate."
                });
                // 5.
                Movies.Add( new Movie
                {
                    Title = "12 Angry Men",
                    Director = "Sidney Lumet",
                    Genre = "Drama",
                    ReleaseYear = 1957,
                    PosterUrl = "",
                    Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence." 
                });
                // 6.
                Movies.Add(new Movie
                {
                    Title = "Schindler's List",
                    Director = "Steven Spielberg",
                    Genre = "Drama",
                    ReleaseYear = 1993,
                    PosterUrl = "",
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."
                });
                // 7.
                Movies.Add(new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    Director = "Peter Jackson",
                    Genre = "Adventure",
                    ReleaseYear = 2003,
                    PosterUrl = "",
                    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."
                });
                // 8.
                Movies.Add(new Movie
                {
                    Title = "Pulp Fiction",
                    Director = "Quentin Tarantino",
                    Genre = "Crime",
                    ReleaseYear = 1994,
                    PosterUrl = "",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
                });
                // 9.
                Movies.Add(new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Director = "Peter Jackson",
                    Genre = "Adventure",
                    ReleaseYear = 2001,
                    PosterUrl = "",
                    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."
                });
                // 10.
                Movies.Add(new Movie
                {
                    Title = "Il buono, il brutto, il cattivo",
                    Director = "Sergio Leone",
                    Genre = "Western",
                    ReleaseYear = 1966,
                    PosterUrl = "",
                    Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery."
                });

                SaveChanges();
            }
        }


    }
}
