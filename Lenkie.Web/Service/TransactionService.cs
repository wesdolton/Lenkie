using Lenkie.Web.Models.DTO;
using Lenkie.Web.Models.Utility;
using Lenkie.Web.Service.IService;

namespace Lenkie.Web.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly IBaseService _baseService;
        public TransactionService(IBaseService baseService) 
        {
            _baseService = baseService;
        }
        
        public async Task<ResponseDTO?> AssignBookToCustomerAsync(BorrowedBookDTO borrowedBookDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.LenkieWebAPIBase + "/api/transactionAPI/AssignBook",
                Data = borrowedBookDTO
            });
        }

        public async Task<ResponseDTO?> GetBookReseversationTrackingAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.LenkieWebAPIBase + "/api/transactionAPI/GetBookReseversationTracking"
            });
        }

        public async Task<ResponseDTO?> GetBorrowedBooksAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.LenkieWebAPIBase + "/api/transactionAPI/GetBorrowedBooks"
            });
        }

        public async Task<ResponseDTO?> ReserveBookForCustomerAsync(BookReservationTrackingDTO bookReservationTrackingDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.LenkieWebAPIBase + "/api/transactionAPI/AssignBook",
                Data = bookReservationTrackingDTO
            });
        }
    }
}
