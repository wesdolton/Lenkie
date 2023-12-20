using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LenkieWebAPI.Models
{
    public class BorrowedBook
    {     
        [Key]
        public int BorrowedBookId { get; set; }
        public string CustomerEmail { get; set; }
        [ForeignKey("Email")]
        public Customer Customer { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Boolean isBookReturned { get; set; }
    }
}
