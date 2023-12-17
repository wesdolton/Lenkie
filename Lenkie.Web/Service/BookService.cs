using Lenkie.Web.Models.DTO;
using Lenkie.Web.Models.Utility;
using Lenkie.Web.Service.IService;

namespace Lenkie.Web.Service
{
    public class BookService : IBookService
    {
        private readonly IBaseService _baseService;
        public BookService(IBaseService baseService) 
        {
            _baseService = baseService;
        }
        public async Task<ResponseDTO?> CreateBookAsync(BookDTO bookDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.LenkieWebAPIBase + "/api/bookAPI",
                Data = bookDTO
            });
        }

        public async Task<ResponseDTO?> DeleteBookByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.LenkieWebAPIBase + "/api/bookAPI/"+id
            });
        }

        public async Task<ResponseDTO?> GetAllBooksAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.LenkieWebAPIBase + "/api/bookAPI"
            });
        }

        public async Task<ResponseDTO?> GetBookAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.LenkieWebAPIBase + "/api/bookAPI/" + id,
            });
        }

        public async Task<ResponseDTO?> GetBookByTitleAsync(string title)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.LenkieWebAPIBase + "/api/bookAPI/"+ title,
            });
        }

        public async Task<ResponseDTO?> UpdateBookAsync(BookDTO bookDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.PUT,
                Url = SD.LenkieWebAPIBase + "/api/bookAPI",
                Data = bookDTO
            });
        }
    }
}
