namespace Lenkie.Web.Models.DTO
{
    public class BorrowedBookDTO
    {     
        public int BorrowedBookId { get; set; }
        public string CustomerEmail { get; set; }
        public int BookId { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Boolean isBookReturned { get; set; }
    }
}
