using Lenkie.Web.Models.DTO;

namespace Lenkie.Web.Service.IService
{
    public interface ITransactionService
    {
        Task<ResponseDTO?> GetBookReseversationTrackingAsync();
        Task<ResponseDTO?> GetBorrowedBooksAsync();
        Task<ResponseDTO?> AssignBookToCustomerAsync(BorrowedBookDTO borrowedBookDTO);
        Task<ResponseDTO?> ReserveBookForCustomerAsync(BookReservationTrackingDTO bookReservationTrackingDTO);
        Task<ResponseDTO?> ReturnBorrowedBookAsync(BorrowedBookDTO borrowedBookDTO);
        Task<ResponseDTO?> GetUserborrowedbooksAsync(string email);
    }
}
