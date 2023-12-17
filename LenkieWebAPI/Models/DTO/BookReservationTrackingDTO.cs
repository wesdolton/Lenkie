using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LenkieWebAPI.Models.DTO
{
    public class BookReservationTrackingDTO
    {
        public int BookResevervationId { get; set; }
        public string CustomerEmail { get; set; }
        public Customer Customer { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime DateReserved { get; set; }
        //public DateTime ReturnDate { get; set; }
        //public Boolean isBookReturned { get; set; }
    }
}
