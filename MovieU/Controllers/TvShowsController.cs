using Microsoft.AspNetCore.Mvc;

namespace MovieU.Controllers
{
    public class TvShowsController : Controller
    {
        // GET
        
        public IActionResult Index()
        {
            
            return View();
        }
    }
}