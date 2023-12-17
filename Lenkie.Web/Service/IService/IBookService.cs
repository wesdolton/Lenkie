using Lenkie.Web.Models.DTO;

namespace Lenkie.Web.Service.IService
{
    public interface IBookService
    {
        Task<ResponseDTO?> GetBookAsync(int id);
        Task<ResponseDTO?> GetAllBooksAsync();
        Task<ResponseDTO?> GetBookByTitleAsync(string title);
        Task<ResponseDTO?> CreateBookAsync(BookDTO bookDTO);
        Task<ResponseDTO?> UpdateBookAsync(BookDTO bookDTO);
        Task<ResponseDTO?> DeleteBookByIdAsync(int id);
    }
}
