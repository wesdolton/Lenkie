using Lenkie.Web.Models;
using Lenkie.Web.Models.DTO;
using Lenkie.Web.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Lenkie.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
		private readonly IBookService _bookService;

		public HomeController(ILogger<HomeController> logger, IBookService bookService)
        {
            //_logger = logger;
            _bookService = bookService;
		}

        public async Task<IActionResult> Index()
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

        [Authorize]
        public async Task<IActionResult> BookDetails(int bookId)
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
        public async Task<IActionResult> BookDetails(BookDTO bookDTO)
        {
            ResponseDTO? response = await _bookService.GetBookAsync(bookDTO.BookId);

            if (response != null && response.IsSuccessful)
            {
                TempData["success"] = "Book deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(bookDTO);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}