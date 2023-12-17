using Lenkie.Web.Models.DTO;
using Lenkie.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lenkie.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> BookIndex()
        {
            List<BookDTO>? list = new();

            ResponseDTO? response = await _bookService.GetAllBooksAsync();

            if (response != null && response.IsSuccessful)
            {
                list = JsonConvert.DeserializeObject<List<BookDTO>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(list);
        }

        public async Task<IActionResult> BookCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookCreate(BookDTO model)
        {
            if (ModelState.IsValid)
            {
                ResponseDTO? response = await _bookService.CreateBookAsync(model);

                if (response != null && response.IsSuccessful)
                {
                    TempData["success"] = "Book created successfully";
                    return RedirectToAction(nameof(BookIndex));
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
            }
            return View(model);
        }

        public async Task<IActionResult> BookDelete(int bookId)
        {
            ResponseDTO? response = await _bookService.GetBookAsync(bookId);

            if (response != null && response.IsSuccessful)
            {
                BookDTO? model = JsonConvert.DeserializeObject<BookDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> BookDelete(BookDTO bookDTO)
        {
            ResponseDTO? response = await _bookService.DeleteBookByIdAsync(bookDTO.BookId);

            if (response != null && response.IsSuccessful)
            {
                TempData["success"] = "Book deleted successfully";
                return RedirectToAction(nameof(BookIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(bookDTO);
        }

        public async Task<IActionResult> BookEdit(int bookId)
        {
            ResponseDTO? response = await _bookService.GetBookAsync(bookId);

            if (response != null && response.IsSuccessful)
            {
                BookDTO? model = JsonConvert.DeserializeObject<BookDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> BookEdit(BookDTO bookDTO)
        {
            ResponseDTO? response = await _bookService.UpdateBookAsync(bookDTO);

            if (response != null && response.IsSuccessful)
            {
                TempData["success"] = "Book upated successfully";
                return RedirectToAction(nameof(BookIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(bookDTO);
        }
    }
}
