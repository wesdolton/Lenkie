using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LenkieWebAPI.Models
{
    public class BorrowedBookDTO
    {     
        public int BorrowedBookId { get; set; }
        public string CustomerEmail { get; set; }
        public Customer Customer { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime ReturnDate { get; set; }
        public Boolean isBookReturned { get; set; }
    }
}
