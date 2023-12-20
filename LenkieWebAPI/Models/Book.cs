using System.ComponentModel.DataAnnotations;

namespace LenkieWebAPI.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        public int InventoryCount { get; set; }
        public string imageUrl { get; set; } = "https://placehold.co/603x403";
        public string ShortDescription { get; set; }

    }
}
