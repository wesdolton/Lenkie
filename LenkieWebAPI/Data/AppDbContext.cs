using LenkieWebAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LenkieWebAPI.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<BookReservationTracking> BookReservationTracking { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                BookName = "Networking Advanced course",
                BookAuthor = "Peter",
                InventoryCount = 0
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                BookName = "Investment Basics 101",
                BookAuthor = "John",
                InventoryCount = 2
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                BookName = "Little Frog Princess",
                BookAuthor = "Same",
                InventoryCount = 2
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                BookName = "Architecture design C#",
                BookAuthor = "Mary",
                InventoryCount = 1
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                BookName = "Bed time stories",
                BookAuthor = "Tom",
                InventoryCount = 1
            });
        }

    }
}
