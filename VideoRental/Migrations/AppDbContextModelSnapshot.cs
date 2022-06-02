﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoRental.Data;

namespace VideoRental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VideoRental.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            ActorName = "Johnny Depp",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 2,
                            ActorName = "Tom Hanks",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 3,
                            ActorName = "Emma Watson",
                            Gender = "Female"
                        },
                        new
                        {
                            ActorId = 4,
                            ActorName = "Angelina Jolie",
                            Gender = "Female"
                        },
                        new
                        {
                            ActorId = 5,
                            ActorName = "Daniel Radcliffe",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 6,
                            ActorName = "Meryl Streep",
                            Gender = "Female"
                        },
                        new
                        {
                            ActorId = 7,
                            ActorName = "Will Smith",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 8,
                            ActorName = "Natalie Portman",
                            Gender = "Female"
                        },
                        new
                        {
                            ActorId = 9,
                            ActorName = "Kate Winslet",
                            Gender = "Female"
                        },
                        new
                        {
                            ActorId = 10,
                            ActorName = "Helena Bonham Carter",
                            Gender = "Female"
                        },
                        new
                        {
                            ActorId = 11,
                            ActorName = "Robert Downey Jr",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 12,
                            ActorName = "Leonardo DiCaprio",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 13,
                            ActorName = "Brad Pitt",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 14,
                            ActorName = "Morgan Freemen",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 15,
                            ActorName = "Tommy Lee Jones",
                            Gender = "Male"
                        },
                        new
                        {
                            ActorId = 16,
                            ActorName = "Alan Rickman",
                            Gender = "Male"
                        });
                });

            modelBuilder.Entity("VideoRental.Models.ActorDvd", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("DvdId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "DvdId");

                    b.HasIndex("DvdId");

                    b.ToTable("ActorDvds");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            DvdId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            DvdId = 3
                        },
                        new
                        {
                            ActorId = 4,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 5,
                            DvdId = 3
                        },
                        new
                        {
                            ActorId = 6,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 7,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 8,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 9,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 10,
                            DvdId = 3
                        },
                        new
                        {
                            ActorId = 11,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 12,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 13,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 14,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 15,
                            DvdId = 1
                        },
                        new
                        {
                            ActorId = 16,
                            DvdId = 3
                        });
                });

            modelBuilder.Entity("VideoRental.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "USA"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Italy"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "UK"
                        },
                        new
                        {
                            CountryId = 5,
                            CountryName = "Spain"
                        });
                });

            modelBuilder.Entity("VideoRental.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Age = 34,
                            CustomerName = "Elise Bryan"
                        },
                        new
                        {
                            CustomerId = 2,
                            Age = 43,
                            CustomerName = "Hayden Rowley"
                        },
                        new
                        {
                            CustomerId = 3,
                            Age = 31,
                            CustomerName = "Emma Morrison"
                        },
                        new
                        {
                            CustomerId = 4,
                            Age = 28,
                            CustomerName = "Archie Hammond"
                        },
                        new
                        {
                            CustomerId = 5,
                            Age = 52,
                            CustomerName = "Robert Davison"
                        },
                        new
                        {
                            CustomerId = 6,
                            Age = 14,
                            CustomerName = "Charles McLean"
                        },
                        new
                        {
                            CustomerId = 7,
                            Age = 10,
                            CustomerName = "Melissa Wilkinson"
                        },
                        new
                        {
                            CustomerId = 8,
                            Age = 36,
                            CustomerName = "Rebecca Middleton"
                        });
                });

            modelBuilder.Entity("VideoRental.Models.DVD", b =>
                {
                    b.Property<int>("DvdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DvdId");

                    b.HasIndex("CountryId");

                    b.ToTable("DVDs");

                    b.HasData(
                        new
                        {
                            DvdId = 1,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Men in Black",
                            ReleaseYear = "1997"
                        },
                        new
                        {
                            DvdId = 2,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Forrest Gump",
                            ReleaseYear = "1994"
                        },
                        new
                        {
                            DvdId = 3,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Harry Potter",
                            ReleaseYear = "2001"
                        },
                        new
                        {
                            DvdId = 4,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Leon: The Proffesional",
                            ReleaseYear = "1994"
                        },
                        new
                        {
                            DvdId = 5,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Django Unchained",
                            ReleaseYear = "2012"
                        },
                        new
                        {
                            DvdId = 6,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Avengers:Endgame",
                            ReleaseYear = "2019"
                        },
                        new
                        {
                            DvdId = 7,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Full Metal Jacket",
                            ReleaseYear = "1987"
                        },
                        new
                        {
                            DvdId = 8,
                            Available = true,
                            CountryId = 1,
                            MovieName = "The Wolf of Wall Street",
                            ReleaseYear = "2013"
                        },
                        new
                        {
                            DvdId = 9,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Pan's Labyrinth",
                            ReleaseYear = "2006"
                        },
                        new
                        {
                            DvdId = 10,
                            Available = true,
                            CountryId = 1,
                            MovieName = "The Sixth Sence",
                            ReleaseYear = "1999"
                        },
                        new
                        {
                            DvdId = 11,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Catch Me If You Can",
                            ReleaseYear = "2002"
                        },
                        new
                        {
                            DvdId = 12,
                            Available = true,
                            CountryId = 1,
                            MovieName = "The Big Lebowski",
                            ReleaseYear = "1998"
                        },
                        new
                        {
                            DvdId = 13,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Monsters Inc.",
                            ReleaseYear = "2001"
                        },
                        new
                        {
                            DvdId = 14,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Groundhog Day",
                            ReleaseYear = "1993"
                        },
                        new
                        {
                            DvdId = 15,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Pirates of the Carribean",
                            ReleaseYear = "2003"
                        },
                        new
                        {
                            DvdId = 16,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Aladdin",
                            ReleaseYear = "2019"
                        },
                        new
                        {
                            DvdId = 17,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Beauty and the Beast",
                            ReleaseYear = "2017"
                        },
                        new
                        {
                            DvdId = 18,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Inception",
                            ReleaseYear = "2010"
                        },
                        new
                        {
                            DvdId = 19,
                            Available = true,
                            CountryId = 1,
                            MovieName = "The Lord of the Rings",
                            ReleaseYear = "2002"
                        },
                        new
                        {
                            DvdId = 20,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Fantastic Beasts",
                            ReleaseYear = ""
                        },
                        new
                        {
                            DvdId = 21,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Murder on the Orient Express",
                            ReleaseYear = "2017"
                        },
                        new
                        {
                            DvdId = 22,
                            Available = true,
                            CountryId = 1,
                            MovieName = "The Hobbit",
                            ReleaseYear = "2013"
                        },
                        new
                        {
                            DvdId = 23,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Alice through the Looking Glass",
                            ReleaseYear = "2016"
                        },
                        new
                        {
                            DvdId = 24,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Evan Almighty",
                            ReleaseYear = "2007"
                        },
                        new
                        {
                            DvdId = 25,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Deep Sea",
                            ReleaseYear = "2006"
                        },
                        new
                        {
                            DvdId = 26,
                            Available = true,
                            CountryId = 1,
                            MovieName = "I am Legend",
                            ReleaseYear = "2007"
                        },
                        new
                        {
                            DvdId = 27,
                            Available = true,
                            CountryId = 1,
                            MovieName = "I, Robot",
                            ReleaseYear = "2004"
                        },
                        new
                        {
                            DvdId = 28,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Into The Woods",
                            ReleaseYear = "2014"
                        },
                        new
                        {
                            DvdId = 29,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Sweeney Todd",
                            ReleaseYear = "2002"
                        },
                        new
                        {
                            DvdId = 30,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Finding Neverland",
                            ReleaseYear = "2004"
                        },
                        new
                        {
                            DvdId = 31,
                            Available = true,
                            CountryId = 1,
                            MovieName = "The Fifth Element",
                            ReleaseYear = "1997"
                        },
                        new
                        {
                            DvdId = 32,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Maleficent",
                            ReleaseYear = "2014"
                        },
                        new
                        {
                            DvdId = 33,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Mr. and Mrs. Smith",
                            ReleaseYear = "2005"
                        },
                        new
                        {
                            DvdId = 34,
                            Available = true,
                            CountryId = 1,
                            MovieName = "Horns",
                            ReleaseYear = "2013"
                        },
                        new
                        {
                            DvdId = 35,
                            Available = true,
                            CountryId = 1,
                            MovieName = "SpongeBob Square Pants",
                            ReleaseYear = "1999"
                        });
                });

            modelBuilder.Entity("VideoRental.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeLimit")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            AgeLimit = 12,
                            Description = "Some material may not be suitable for children.",
                            GenreName = "Action"
                        },
                        new
                        {
                            GenreId = 2,
                            AgeLimit = 0,
                            Description = "All ages admitted.",
                            GenreName = "Comedy"
                        },
                        new
                        {
                            GenreId = 3,
                            AgeLimit = 12,
                            Description = "Some material may not be suitable for children.",
                            GenreName = "Drama"
                        },
                        new
                        {
                            GenreId = 4,
                            AgeLimit = 0,
                            Description = "All ages admitted.",
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            GenreId = 5,
                            AgeLimit = 16,
                            Description = "Requires parent accompanying.",
                            GenreName = "Horror"
                        },
                        new
                        {
                            GenreId = 6,
                            AgeLimit = 12,
                            Description = "Some material may not be suitable for children.",
                            GenreName = "Thriller"
                        },
                        new
                        {
                            GenreId = 7,
                            AgeLimit = 0,
                            Description = "All ages admitted.",
                            GenreName = "Western"
                        },
                        new
                        {
                            GenreId = 8,
                            AgeLimit = 12,
                            Description = "Some material may not be suitable for children.",
                            GenreName = "Romantic"
                        },
                        new
                        {
                            GenreId = 9,
                            AgeLimit = 0,
                            Description = "All ages admitted.",
                            GenreName = "Family"
                        },
                        new
                        {
                            GenreId = 10,
                            AgeLimit = 0,
                            Description = "All ages admitted.",
                            GenreName = "Cartoon"
                        });
                });

            modelBuilder.Entity("VideoRental.Models.GenreDvd", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("DvdId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "DvdId");

                    b.HasIndex("DvdId");

                    b.ToTable("GenreDvds");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            DvdId = 1
                        },
                        new
                        {
                            GenreId = 2,
                            DvdId = 1
                        },
                        new
                        {
                            GenreId = 3,
                            DvdId = 2
                        },
                        new
                        {
                            GenreId = 4,
                            DvdId = 3
                        },
                        new
                        {
                            GenreId = 5,
                            DvdId = 1
                        },
                        new
                        {
                            GenreId = 6,
                            DvdId = 1
                        },
                        new
                        {
                            GenreId = 7,
                            DvdId = 1
                        },
                        new
                        {
                            GenreId = 8,
                            DvdId = 2
                        },
                        new
                        {
                            GenreId = 9,
                            DvdId = 3
                        },
                        new
                        {
                            GenreId = 10,
                            DvdId = 13
                        },
                        new
                        {
                            GenreId = 10,
                            DvdId = 35
                        });
                });

            modelBuilder.Entity("VideoRental.Models.ActorDvd", b =>
                {
                    b.HasOne("VideoRental.Models.Actor", "Actor")
                        .WithMany("ActorDvds")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoRental.Models.DVD", "DVD")
                        .WithMany("ActorDvds")
                        .HasForeignKey("DvdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VideoRental.Models.DVD", b =>
                {
                    b.HasOne("VideoRental.Models.Country", "Country")
                        .WithMany("DVDs")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VideoRental.Models.GenreDvd", b =>
                {
                    b.HasOne("VideoRental.Models.DVD", "DVD")
                        .WithMany("GenreDvds")
                        .HasForeignKey("DvdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoRental.Models.Genre", "Genre")
                        .WithMany("GenreDvds")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
