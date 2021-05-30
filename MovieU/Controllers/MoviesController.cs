using Microsoft.AspNetCore.Mvc;

namespace MovieU.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            
            return View();
        }
    }
}