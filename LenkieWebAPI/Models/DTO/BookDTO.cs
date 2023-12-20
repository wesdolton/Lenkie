using System.ComponentModel.DataAnnotations;

namespace LenkieWebAPI.Models.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int InventoryCount { get; set; }
        public string imageUrl { get; set; }
        public string ShortDescription { get; set; }
    }
}
