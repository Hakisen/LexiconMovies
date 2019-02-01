﻿// <auto-generated />
using System;
using LexiconMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LexiconMovies.Migrations
{
    [DbContext(typeof(LexiconMoviesContext))]
    [Migration("20190131103349_Movie.Rating")]
    partial class MovieRating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LexiconMovies.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<float>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Science Fiction",
                            Price = 140m,
                            Rating = 2.5f,
                            ReleaseDate = new DateTime(2010, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "AI"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Science Fiction",
                            Price = 230m,
                            Rating = 2.2f,
                            ReleaseDate = new DateTime(2010, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Explorer"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Comedy",
                            Price = 125m,
                            Rating = 4.1f,
                            ReleaseDate = new DateTime(1980, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pink Panther"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Horror",
                            Price = 220m,
                            Rating = 1.7f,
                            ReleaseDate = new DateTime(2003, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Saw 4"
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Splatter",
                            Price = 99m,
                            Rating = 3.4f,
                            ReleaseDate = new DateTime(198, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Killer Tomatoes"
                        },
                        new
                        {
                            Id = 6,
                            Genre = "Drama",
                            Price = 340m,
                            Rating = 3.8f,
                            ReleaseDate = new DateTime(2008, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Horse Whisperer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
