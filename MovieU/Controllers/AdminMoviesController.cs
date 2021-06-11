using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieU.Data;
using MovieU.Models;

namespace MovieU.Controllers
{
    public class AdminMoviesController : Controller
    {
        private ApplicationDbContext db;

        public AdminMoviesController(ApplicationDbContext db)
        {
            db = db;
        }
        
        [Route("/admin/movies")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Movies.cshtml");
        }

        [Route("/admin/seed")]
        public IActionResult seedAdmin()
        {
            new SampleData(db).SeedAdminUser();
            return Json("Done");
        }

        
    }
}