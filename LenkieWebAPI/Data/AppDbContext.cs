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
                InventoryCount = 0,
                imageUrl = "https://placehold.co/603x403",
                ShortDescription = "Unravel the mysteries of a celestial library where stories transcend space and time. Chronicles of the Celestial Scribe weaves a tapestry of cosmic adventures, where a humble scribe holds the key to unlocking the boundless tales of the universe, each word etching the destiny of worlds yet unknown."
            }); ;

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                BookName = "Investment Basics 101",
                BookAuthor = "John",
                InventoryCount = 2,
                imageUrl = "https://placehold.co/603x403",
                ShortDescription = "Venture into the quantum frontier where reality blurs and possibilities multiply. Quantum Paradox explores a world where science collides with the surreal, and choices create branching timelines. As the protagonist grapples with the consequences of their decisions, a mind-bending adventure unfolds across the multiverse."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                BookName = "Little Frog Princess",
                BookAuthor = "Same",
                InventoryCount = 2,
                imageUrl = "https://placehold.co/603x403",
                ShortDescription = "Amidst the mystical mists of Azurea, a forgotten prophecy stirs the winds of change. Mists of Azurea unfolds the tale of a reluctant hero, chosen by ancient forces, as they navigate a realm where illusions dance and destinies intertwine. Will they unravel the secrets veiled in the ethereal mist?"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                BookName = "Architecture design C#",
                BookAuthor = "Mary",
                InventoryCount = 1,
                imageUrl = "https://placehold.co/603x403",
                ShortDescription = "Dive into a world where music is magic and melodies hold the power to shape reality. Ephemeral Symphony follows the journey of a young prodigy navigating the harmonious landscapes of a city that resonates with enchanting tunes. A symphony of love, loss, and the transcendent notes that echo through the ages."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                BookName = "Bed time stories",
                BookAuthor = "Tom",
                InventoryCount = 1,
                imageUrl = "https://placehold.co/603x403",
                ShortDescription = "In a realm where ancient magic collides with the technological wonders of tomorrow, a reluctant hero discovers a hidden legacy. Whispers of the Forgotten invites readers on an epic journey through forgotten cities and forbidden realms, where secrets buried in time awaken to reshape destinies."
            });
        }

    }
}
