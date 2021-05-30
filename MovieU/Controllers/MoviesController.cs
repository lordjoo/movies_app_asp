using Microsoft.AspNetCore.Mvc;
using MovieU.Data;

namespace MovieU.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        private ApplicationDbContext holder;

        public MoviesController()
        {
            holder = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            holder.Dispose();
        }

        public IActionResult getMovie(int id)
        {
            return View();
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}