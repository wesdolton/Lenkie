﻿// <auto-generated />
using LenkieWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LenkieWebAPI.Migrations.BookDb
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20231214191937_lenkie-book-migrations")]
    partial class lenkiebookmigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LenkieWebAPI.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryCount")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookAuthor = "Peter",
                            BookName = "Networking Advanced course",
                            InventoryCount = 0
                        },
                        new
                        {
                            BookId = 2,
                            BookAuthor = "John",
                            BookName = "Investment Basics 101",
                            InventoryCount = 2
                        },
                        new
                        {
                            BookId = 3,
                            BookAuthor = "Same",
                            BookName = "Little Frog Princess",
                            InventoryCount = 2
                        },
                        new
                        {
                            BookId = 4,
                            BookAuthor = "Mary",
                            BookName = "Architecture design C#",
                            InventoryCount = 1
                        },
                        new
                        {
                            BookId = 5,
                            BookAuthor = "Tom",
                            BookName = "Bed time stories",
                            InventoryCount = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}