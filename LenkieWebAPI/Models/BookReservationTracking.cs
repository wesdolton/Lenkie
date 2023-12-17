using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LenkieWebAPI.Models
{
    public class BookReservationTracking
    {
        [Key]
        public int BookResevervationId { get; set; }
        public string CustomerEmail { get; set; }
        [ForeignKey("Email")]
        public Customer Customer { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public DateTime DateReserved { get; set; }
        //public DateTime ReturnDate { get; set; }
        //public Boolean isBookReturned { get; set; }
    }
}
