using System.Linq;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MovieU.Data;


namespace MovieU.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        private ApplicationDbContext holder;

        public MoviesController(ApplicationDbContext db)
        {
            holder = db;
        }
        
        public IActionResult show(int id)
        {
            var movies = holder.Movies.SingleOrDefault(x => x.Id == id);
            if (movies == null) return NotFound();
            return View("~/Views/Shared/getItem.cshtml",movies);
        }
        public IActionResult Index()
        {
            var movies  = holder.Movies.ToList();
            return View(movies);
        }
         
    }
}