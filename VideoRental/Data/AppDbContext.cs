using Microsoft.EntityFrameworkCore;
using VideoRental.Models;

namespace VideoRental.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData
                (
                new Genre { GenreKey = 1, GenreName = "Action", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreKey = 2, GenreName = "Comedy", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreKey = 3, GenreName = "Drama", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreKey = 4, GenreName = "Fantasy", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreKey = 5, GenreName = "Horror", Description = "Requires parent accompanying.", AgeLimit = 16},
                new Genre { GenreKey = 6, GenreName = "Thriller", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreKey = 7, GenreName = "Western", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreKey = 8, GenreName = "Romantic", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreKey = 9, GenreName = "Family", Description = "All ages admitted.", AgeLimit = 0 },      
                new Genre { GenreKey = 10, GenreName = "Cartoon", Description = "All ages admitted.", AgeLimit = 0 }      
                );
            modelBuilder.Entity<Actor>().HasData(
                new Actor { ActorId = 1, ActorName = "Johnny Depp",Gender = "Male" },
                new Actor { ActorId = 2, ActorName = "Tom Hanks", Gender = "Male" },
                new Actor { ActorId = 3, ActorName = "Emma Watson", Gender = "Female" },
                new Actor { ActorId = 4, ActorName = "Angelina Jolie", Gender = "Female" },
                new Actor { ActorId = 5, ActorName = "Daniel Radcliffe", Gender = "Male" },
                new Actor { ActorId = 6, ActorName = "Meryl Streep", Gender = "Female" },
                new Actor { ActorId = 7, ActorName = "Will Smith", Gender = "Male" },
                new Actor { ActorId = 8, ActorName = "Natalie Portman", Gender = "Female" },
                new Actor { ActorId = 9, ActorName = "Kate Winslet", Gender = "Female" },
                new Actor { ActorId = 10, ActorName = "Helena Bonham Carter", Gender = "Female" },
                new Actor { ActorId = 11, ActorName = "Robert Downey Jr", Gender = "Male" },
                new Actor { ActorId = 12, ActorName = "Leonardo DiCaprio", Gender = "Male" },
                new Actor { ActorId = 13, ActorName = "Brad Pitt", Gender = "Male" },
                new Actor { ActorId = 14, ActorName = "Morgan Freemen", Gender = "Male" },
                new Actor { ActorId = 15, ActorName = "Tommy Lee Jones", Gender = "Male" },
                new Actor { ActorId = 16, ActorName = "Alan Rickman", Gender = "Male" }
                );
            modelBuilder.Entity<Country>().HasData
                (
                new Country { CountryId = 1, CountryName = "USA"},
                new Country { CountryId = 2, CountryName = "Italy"},
                new Country { CountryId = 3, CountryName = "France"},
                new Country { CountryId = 4, CountryName = "UK"},
                new Country { CountryId = 5, CountryName = "Canada"}               
                );
            modelBuilder.Entity<DVD>().HasData
                (
                new DVD { DvdId = 1, MovieName = "Men in Black", ReleaseYear = "1997", Available = true, CountryId = 1, GenreKey = 1, ActorId = 7 },
                new DVD { DvdId = 2, MovieName = "Forrest Gump", ReleaseYear = "1994", Available = true, CountryId = 1, GenreKey = 8, ActorId = 2 },
                new DVD { DvdId = 3, MovieName = "Harry Potter", ReleaseYear = "2001", Available = true, CountryId = 4, GenreKey = 4, ActorId = 3},
                new DVD { DvdId = 4, MovieName = "Leon: The Proffesional", ReleaseYear = "1994", Available = true, CountryId = 3, GenreKey = 3, ActorId = 8},
                new DVD { DvdId = 5, MovieName = "Django Unchained", ReleaseYear = "2012", Available = true, CountryId = 1, GenreKey = 7, ActorId = 12},
                new DVD { DvdId = 6, MovieName = "Avengers:Endgame", ReleaseYear = "2019", Available = true, CountryId = 1, GenreKey = 1, ActorId = 11 },
                new DVD { DvdId = 7, MovieName = "Full Metal Jacket", ReleaseYear = "1987", Available = true, CountryId = 1, GenreKey = 3, ActorId = 1 },
                new DVD { DvdId = 8, MovieName = "The Wolf of Wall Street", ReleaseYear = "2013", Available = true, CountryId = 1, GenreKey = 2, ActorId = 12 },
                new DVD { DvdId = 9, MovieName = "Pan's Labyrinth", ReleaseYear = "2006", Available = true, CountryId = 1, GenreKey = 3, ActorId = 1 },
                new DVD { DvdId = 10, MovieName = "The Sixth Sence", ReleaseYear = "1999", Available = true, CountryId = 1, GenreKey = 6, ActorId = 1 },
                new DVD { DvdId = 11, MovieName = "Catch Me If You Can", ReleaseYear = "2002", Available = true, CountryId = 1, GenreKey = 3, ActorId = 2 },
                new DVD { DvdId = 12, MovieName = "The Big Lebowski", ReleaseYear = "1998", Available = true, CountryId = 1, GenreKey = 2, ActorId = 1 },
                new DVD { DvdId = 13, MovieName = "Monsters Inc.", ReleaseYear = "2001", Available = true, CountryId = 1, GenreKey = 10, ActorId = 1 },
                new DVD { DvdId = 14, MovieName = "Groundhog Day", ReleaseYear = "1993", Available = true, CountryId = 1, GenreKey = 2, ActorId = 1 },
                new DVD { DvdId = 15, MovieName = "Pirates of the Carribean", ReleaseYear = "2003", Available = true, CountryId = 1, GenreKey = 1, ActorId = 1 },
                new DVD { DvdId = 16, MovieName = "Aladdin", ReleaseYear = "2019", Available = true, CountryId = 1, GenreKey = 9, ActorId = 7 },
                new DVD { DvdId = 17, MovieName = "Beauty and the Beast", ReleaseYear = "2017", Available = true, CountryId = 4, GenreKey = 9, ActorId = 3 },
                new DVD { DvdId = 18, MovieName = "Inception", ReleaseYear = "2010", Available = true, CountryId = 1, GenreKey = 1, ActorId = 12 },
                new DVD { DvdId = 19, MovieName = "The Lord of the Rings", ReleaseYear = "2002", Available = true, CountryId = 4, GenreKey = 4, ActorId = 1 },
                new DVD { DvdId = 20, MovieName = "Fantastic Beasts", ReleaseYear = "2019", Available = true, CountryId = 4, GenreKey = 4, ActorId = 1 },
                new DVD { DvdId = 21, MovieName = "Murder on the Orient Express", ReleaseYear = "2017", Available = true, CountryId = 1, GenreKey = 9, ActorId = 1 },
                new DVD { DvdId = 22, MovieName = "The Hobbit", ReleaseYear = "2013", Available = true, CountryId = 4, GenreKey = 9, ActorId = 1 },
                new DVD { DvdId = 23, MovieName = "Alice through the Looking Glass", ReleaseYear = "2016", Available = true, CountryId = 1, GenreKey = 9, ActorId = 1 },
                new DVD { DvdId = 24, MovieName = "Evan Almighty", ReleaseYear = "2007", Available = true, CountryId = 1, GenreKey = 9, ActorId = 14 },
                new DVD { DvdId = 25, MovieName = "Deep Sea", ReleaseYear = "2006", Available = true, CountryId = 1, GenreKey = 9, ActorId = 1 },
                new DVD { DvdId = 26, MovieName = "I am Legend", ReleaseYear = "2007", Available = true, CountryId = 1, GenreKey = 5, ActorId = 7 },
                new DVD { DvdId = 27, MovieName = "I, Robot", ReleaseYear = "2004", Available = true, CountryId = 1, GenreKey = 1, ActorId = 7 },
                new DVD { DvdId = 28, MovieName = "Into The Woods", ReleaseYear = "2014", Available = true, CountryId = 1, GenreKey = 4, ActorId = 6 },
                new DVD { DvdId = 29, MovieName = "Sweeney Todd", ReleaseYear = "2002", Available = true, CountryId = 4, GenreKey = 5, ActorId = 1 },
                new DVD { DvdId = 30, MovieName = "Finding Neverland", ReleaseYear = "2004", Available = true, CountryId = 1, GenreKey = 9, ActorId = 1 },
                new DVD { DvdId = 31, MovieName = "The Fifth Element", ReleaseYear = "1997", Available = true, CountryId = 3, GenreKey = 9, ActorId = 1},
                new DVD { DvdId = 32, MovieName = "Maleficent", ReleaseYear = "2014", Available = true, CountryId = 1, GenreKey = 4, ActorId = 4 },
                new DVD { DvdId = 33, MovieName = "Mr. and Mrs. Smith", ReleaseYear = "2005", Available = true, CountryId = 1, GenreKey = 1, ActorId = 4 },
                new DVD { DvdId = 34, MovieName = "Horns", ReleaseYear = "2013", Available = true, CountryId = 5, GenreKey = 5, ActorId = 5 },
                new DVD { DvdId = 35, MovieName = "SpongeBob Square Pants", ReleaseYear = "1999", Available = true, CountryId = 1, GenreKey = 10, ActorId = 1 }
                );
            modelBuilder.Entity<Customer>().HasData
                (
                new Customer { CustomerId = 1, CustomerName = "Elise Bryan", Age = 34},
                new Customer { CustomerId = 2, CustomerName = "Hayden Rowley", Age = 43},
                new Customer { CustomerId = 3, CustomerName = "Emma Morrison", Age = 31},
                new Customer { CustomerId = 4, CustomerName = "Archie Hammond", Age = 28},
                new Customer { CustomerId = 5, CustomerName = "Robert Davison", Age = 52},
                new Customer { CustomerId = 6, CustomerName = "Charles McLean", Age = 14},
                new Customer { CustomerId = 7, CustomerName = "Melissa Wilkinson", Age = 10},
                new Customer { CustomerId = 8, CustomerName = "Rebecca Middleton", Age = 36}
                );
            
        }
        public DbSet<DVD>DVDs { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Country>Countries { get; set; }
        public DbSet<Actor>Actors { get; set; }

    }
}
