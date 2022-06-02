﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoRental.Data;

namespace VideoRental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220601135850_Added Countries")]
    partial class AddedCountries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            CountryId = 6,
                            CountryName = "Denmark"
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

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("VideoRental.Models.DVD", b =>
                {
                    b.Property<int>("DvdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release")
                        .HasColumnType("datetime2");

                    b.HasKey("DvdId");

                    b.ToTable("DVDs");
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
                            AgeLimit = 10,
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
                            AgeLimit = 100,
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
                            AgeLimit = 100,
                            Description = "All ages admitted.",
                            GenreName = "Western"
                        },
                        new
                        {
                            GenreId = 8,
                            AgeLimit = 10,
                            Description = "Some material may not be suitable for children.",
                            GenreName = "Romantic"
                        },
                        new
                        {
                            GenreId = 9,
                            AgeLimit = 100,
                            Description = "All ages admitted.",
                            GenreName = "Family"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}