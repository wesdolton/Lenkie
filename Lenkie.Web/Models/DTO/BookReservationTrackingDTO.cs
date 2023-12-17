namespace Lenkie.Web.Models.DTO
{
    public class BookReservationTrackingDTO
    {
        public int BookResevervationId { get; set; }
        public string CustomerEmail { get; set; }
        public int BookId { get; set; }
        public DateTime DateReserved { get; set; }
        //public DateTime ReturnDate { get; set; }
        //public Boolean isBookReturned { get; set; }
    }
}
