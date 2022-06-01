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
                new Genre { GenreId = 1, GenreName = "Action", Description = "Some material may not be suitable for children.", AgeLimit = 10},
                new Genre { GenreId = 2, GenreName = "Comedy", Description = "All ages admitted.", AgeLimit = 0},
                new Genre { GenreId = 3, GenreName = "Drama", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreId = 4, GenreName = "Fantasy", Description = "All ages admitted.", AgeLimit = 100},
                new Genre { GenreId = 5, GenreName = "Horror", Description = "Requires parent accompanying.", AgeLimit = 16},
                new Genre { GenreId = 6, GenreName = "Thriller", Description = "Some material may not be suitable for children.", AgeLimit = 12},
                new Genre { GenreId = 7, GenreName = "Western", Description = "All ages admitted.", AgeLimit = 100},
                new Genre { GenreId = 8, GenreName = "Romantic", Description = "Some material may not be suitable for children.", AgeLimit = 10},
                new Genre { GenreId = 9, GenreName = "Family", Description = "All ages admitted.", AgeLimit = 100 }      
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
                new Actor { ActorId = 15, ActorName = "Tommy Lee Jones", Gender = "Male" }
                );

        }
        public DbSet<DVD>DVDs { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Genre>Genres { get; set; }
        public DbSet<Country>Countries { get; set; }
        public DbSet<Actor>Actors { get; set; }


    }
}
