using Microsoft.AspNetCore.Mvc;

namespace OrangeStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
