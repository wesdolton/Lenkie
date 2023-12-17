using Microsoft.AspNetCore.Mvc;

namespace Lenkie.Web.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
