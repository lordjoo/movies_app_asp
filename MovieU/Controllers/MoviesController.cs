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
            // this will be applied in getItem view ... 
            var movies = holder.Movies.SingleOrDefault(x => x.Id == id);
            if (movies == null) return NotFound();
            ViewData["movies"] =  holder.Movies.OrderByDescending(t => t.Id).Take(4);
            return View(movies);
        }
        public IActionResult Index()
        {
            var movies  = holder.Movies.ToList();
            return View(movies);
        }
         
    }
}