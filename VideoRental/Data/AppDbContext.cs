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
                new Genre { GenreId = 1, GenreName = "Action", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreId = 2, GenreName = "Comedy", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreId = 3, GenreName = "Drama", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreId = 4, GenreName = "Fantasy", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreId = 5, GenreName = "Horror", Description = "Requires parent accompanying.", AgeLimit = 16},
                new Genre { GenreId = 6, GenreName = "Thriller", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreId = 7, GenreName = "Western", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreId = 8, GenreName = "Romantic", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreId = 9, GenreName = "Family", Description = "All ages admitted.", AgeLimit = 0 },      
                new Genre { GenreId = 10, GenreName = "Cartoon", Description = "All ages admitted.", AgeLimit = 0 }      
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
                new Country { CountryId = 5, CountryName = "Spain"}               
                );
            modelBuilder.Entity<DVD>().HasData
                (
                new DVD { DvdId = 1, MovieName = "Men in Black", ReleaseYear = "1997", Available = true, CountryId = 1, Language = "English" },
                new DVD { DvdId = 2, MovieName = "Forrest Gump", ReleaseYear = "1994", Available = true, CountryId = 1, Language = "English" },
                new DVD { DvdId = 3, MovieName = "Harry Potter", ReleaseYear = "2001", Available = true, CountryId = 1, Language = "English" },
                new DVD { DvdId = 4, MovieName = "Leon: The Proffesional", ReleaseYear = "1994", Available = true, CountryId = 3, Language = "French" },
                new DVD { DvdId = 5, MovieName = "Django Unchained", ReleaseYear = "2012", Available = true, CountryId = 1, Language = "English" },
                new DVD { DvdId = 6, MovieName = "Avengers:Endgame", ReleaseYear = "2019", Available = true, CountryId = 1 },
                new DVD { DvdId = 7, MovieName = "Full Metal Jacket", ReleaseYear = "1987", Available = true, CountryId = 1 },
                new DVD { DvdId = 8, MovieName = "The Wolf of Wall Street", ReleaseYear = "2013", Available = true, CountryId = 1 },
                new DVD { DvdId = 9, MovieName = "Pan's Labyrinth", ReleaseYear = "2006", Available = true, CountryId = 1 },
                new DVD { DvdId = 10, MovieName = "The Sixth Sence", ReleaseYear = "1999", Available = true, CountryId = 1 },
                new DVD { DvdId = 11, MovieName = "Catch Me If You Can", ReleaseYear = "2002", Available = true, CountryId = 1 },
                new DVD { DvdId = 12, MovieName = "The Big Lebowski", ReleaseYear = "1998", Available = true, CountryId = 1 },
                new DVD { DvdId = 13, MovieName = "Monsters Inc.", ReleaseYear = "2001", Available = true, CountryId = 1 },
                new DVD { DvdId = 14, MovieName = "Groundhog Day", ReleaseYear = "1993", Available = true, CountryId = 1 },
                new DVD { DvdId = 15, MovieName = "Pirates of the Carribean", ReleaseYear = "2003", Available = true, CountryId = 1 },
                new DVD { DvdId = 16, MovieName = "Aladdin", ReleaseYear = "2019", Available = true, CountryId = 1 },
                new DVD { DvdId = 17, MovieName = "Beauty and the Beast", ReleaseYear = "2017", Available = true, CountryId = 1 },
                new DVD { DvdId = 18, MovieName = "Inception", ReleaseYear = "2010", Available = true, CountryId = 1 },
                new DVD { DvdId = 19, MovieName = "The Lord of the Rings", ReleaseYear = "2002", Available = true, CountryId = 1 },
                new DVD { DvdId = 20, MovieName = "Fantastic Beasts", ReleaseYear = "", Available = true, CountryId = 1 },
                new DVD { DvdId = 21, MovieName = "Murder on the Orient Express", ReleaseYear = "2017", Available = true, CountryId = 1 },
                new DVD { DvdId = 22, MovieName = "The Hobbit", ReleaseYear = "2013", Available = true, CountryId = 1 },
                new DVD { DvdId = 23, MovieName = "Alice through the Looking Glass", ReleaseYear = "2016", Available = true, CountryId = 1 },
                new DVD { DvdId = 24, MovieName = "Evan Almighty", ReleaseYear = "2007", Available = true, CountryId = 1 },
                new DVD { DvdId = 25, MovieName = "Deep Sea", ReleaseYear = "2006", Available = true, CountryId = 1 },
                new DVD { DvdId = 26, MovieName = "I am Legend", ReleaseYear = "2007", Available = true, CountryId = 1 },
                new DVD { DvdId = 27, MovieName = "I, Robot", ReleaseYear = "2004", Available = true, CountryId = 1 },
                new DVD { DvdId = 28, MovieName = "Into The Woods", ReleaseYear = "2014", Available = true, CountryId = 1 },
                new DVD { DvdId = 29, MovieName = "Sweeney Todd", ReleaseYear = "2002", Available = true, CountryId = 1 },
                new DVD { DvdId = 30, MovieName = "Finding Neverland", ReleaseYear = "2004", Available = true, CountryId = 1 },
                new DVD { DvdId = 31, MovieName = "The Fifth Element", ReleaseYear = "1997", Available = true, CountryId = 3, Language = "French" },
                new DVD { DvdId = 32, MovieName = "Maleficent", ReleaseYear = "2014", Available = true, CountryId = 1 },
                new DVD { DvdId = 33, MovieName = "Mr. and Mrs. Smith", ReleaseYear = "2005", Available = true, CountryId = 1 },
                new DVD { DvdId = 34, MovieName = "Horns", ReleaseYear = "2013", Available = true, CountryId = 1 },
                new DVD { DvdId = 35, MovieName = "SpongeBob Square Pants", ReleaseYear = "1999", Available = true, CountryId = 1 }
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
            modelBuilder.Entity<ActorDvd>().HasData
                (
                new ActorDvd { ActorId = 1, DvdId = 15},
                new ActorDvd { ActorId = 1, DvdId = 20},
                new ActorDvd { ActorId = 1, DvdId = 21},
                new ActorDvd { ActorId = 1, DvdId = 23},
                new ActorDvd { ActorId = 1, DvdId = 25},
                new ActorDvd { ActorId = 1, DvdId = 28},
                new ActorDvd { ActorId = 1, DvdId = 29},
                new ActorDvd { ActorId = 1, DvdId = 30},
                new ActorDvd { ActorId = 2, DvdId = 2},
                new ActorDvd { ActorId = 2, DvdId = 11},
                new ActorDvd { ActorId = 3, DvdId = 3},
                new ActorDvd { ActorId = 3, DvdId = 17},
                new ActorDvd { ActorId = 4, DvdId = 32},
                new ActorDvd { ActorId = 4, DvdId = 33},
                new ActorDvd { ActorId = 5, DvdId = 3},
                new ActorDvd { ActorId = 5, DvdId = 34},
                new ActorDvd { ActorId = 6, DvdId = 28},
                new ActorDvd { ActorId = 7, DvdId = 1},
                new ActorDvd { ActorId = 7, DvdId = 16},
                new ActorDvd { ActorId = 7, DvdId = 26},
                new ActorDvd { ActorId = 7, DvdId = 27},
                new ActorDvd { ActorId = 8, DvdId = 4},
                new ActorDvd { ActorId = 9, DvdId = 25},
                new ActorDvd { ActorId = 9, DvdId = 30},
                new ActorDvd { ActorId = 10, DvdId = 3},
                new ActorDvd { ActorId = 10, DvdId = 23},
                new ActorDvd { ActorId = 10, DvdId = 29},
                new ActorDvd { ActorId = 11, DvdId = 6},
                new ActorDvd { ActorId = 12, DvdId = 5},
                new ActorDvd { ActorId = 12, DvdId = 8},
                new ActorDvd { ActorId = 12, DvdId = 11},
                new ActorDvd { ActorId = 12, DvdId = 18},
                new ActorDvd { ActorId = 13, DvdId = 33},
                new ActorDvd { ActorId = 14, DvdId = 24},
                new ActorDvd { ActorId = 15, DvdId = 1},
                new ActorDvd { ActorId = 16, DvdId = 3},
                new ActorDvd { ActorId = 16, DvdId = 29}
                );
            modelBuilder.Entity<GenreDvd>().HasData
                (
                new GenreDvd { GenreId = 1, DvdId = 1},
                new GenreDvd { GenreId = 1, DvdId = 4},
                new GenreDvd { GenreId = 1, DvdId = 6},
                new GenreDvd { GenreId = 1, DvdId = 15},
                new GenreDvd { GenreId = 1, DvdId = 18},
                new GenreDvd { GenreId = 1, DvdId = 27},
                new GenreDvd { GenreId = 1, DvdId = 33},
                new GenreDvd { GenreId = 2, DvdId = 1},
                new GenreDvd { GenreId = 2, DvdId = 8},
                new GenreDvd { GenreId = 2, DvdId = 12},
                new GenreDvd { GenreId = 2, DvdId = 14},
                new GenreDvd { GenreId = 2, DvdId = 24},
                new GenreDvd { GenreId = 3, DvdId = 2},
                new GenreDvd { GenreId = 3, DvdId = 4},
                new GenreDvd { GenreId = 3, DvdId = 7},
                new GenreDvd { GenreId = 3, DvdId = 9},
                new GenreDvd { GenreId = 3, DvdId = 11},
                new GenreDvd { GenreId = 4, DvdId = 3},
                new GenreDvd { GenreId = 4, DvdId = 19},
                new GenreDvd { GenreId = 4, DvdId = 20},
                new GenreDvd { GenreId = 4, DvdId = 22},
                new GenreDvd { GenreId = 4, DvdId = 23},
                new GenreDvd { GenreId = 4, DvdId = 28},
                new GenreDvd { GenreId = 4, DvdId = 32},
                new GenreDvd { GenreId = 5, DvdId = 26},
                new GenreDvd { GenreId = 5, DvdId = 29},
                new GenreDvd { GenreId = 5, DvdId = 34},
                new GenreDvd { GenreId = 6, DvdId = 10},
                new GenreDvd { GenreId = 6, DvdId = 26},
                new GenreDvd { GenreId = 7, DvdId = 5},
                new GenreDvd { GenreId = 8, DvdId = 2},        
                new GenreDvd { GenreId = 9, DvdId = 3},        
                new GenreDvd { GenreId = 9, DvdId = 16},        
                new GenreDvd { GenreId = 9, DvdId = 17},        
                new GenreDvd { GenreId = 9, DvdId = 19},        
                new GenreDvd { GenreId = 9, DvdId = 20},        
                new GenreDvd { GenreId = 9, DvdId = 21},        
                new GenreDvd { GenreId = 9, DvdId = 22},        
                new GenreDvd { GenreId = 9, DvdId = 23},        
                new GenreDvd { GenreId = 9, DvdId = 24},        
                new GenreDvd { GenreId = 9, DvdId = 30},        
                new GenreDvd { GenreId = 9, DvdId = 31},        
                new GenreDvd { GenreId = 10, DvdId = 13},        
                new GenreDvd { GenreId = 10, DvdId = 35}        
                );

            modelBuilder.Entity<ActorDvd>()
                .HasKey(ab => new { ab.ActorId, ab.DvdId });

            modelBuilder.Entity<ActorDvd>()
                .HasOne<DVD>(ab => ab.DVD)
                .WithMany(b => b.ActorDvds)
                .HasForeignKey(b => b.DvdId);

            modelBuilder.Entity<ActorDvd>()
                .HasOne<Actor>(ab => ab.Actor)
                .WithMany(a => a.ActorDvds)
                .HasForeignKey(a => a.ActorId);

            modelBuilder.Entity<GenreDvd>()
                .HasKey(ab => new { ab.GenreId, ab.DvdId });

            modelBuilder.Entity<GenreDvd>()
                .HasOne<DVD>(ab => ab.DVD)
                .WithMany(b => b.GenreDvds)
                .HasForeignKey(b => b.DvdId);

            modelBuilder.Entity<GenreDvd>()
                .HasOne<Genre>(ab => ab.Genre)
                .WithMany(a => a.GenreDvds)
                .HasForeignKey(a => a.GenreId);

        }
        public DbSet<DVD>DVDs { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Country>Countries { get; set; }
        public DbSet<Actor>Actors { get; set; }
        public DbSet<ActorDvd>ActorDvds { get; set; }
        public DbSet<GenreDvd>GenreDvds { get; set; }
        


    }
}
