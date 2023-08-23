using Microsoft.AspNetCore.Mvc;

namespace Top_10_films.Controllers
{
    public class Top10FilmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
