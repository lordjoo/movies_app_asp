using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieU.Data;

namespace MovieU.Controllers
{
    public class TvShowsController : Controller
    {
        
        private ApplicationDbContext holder;
        public TvShowsController(ApplicationDbContext db)
        {
            holder = db;
        }
        
        public IActionResult Index()
        {
            var movies  = holder.TvShows.ToList();
            return View(movies);
        }
        
        public IActionResult show(int id)
        {
            var show = holder.TvShows.SingleOrDefault(x => x.Id == id);
            if (show == null) return NotFound();
            return View(show);
        }
        
    }
}