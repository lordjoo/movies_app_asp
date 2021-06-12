using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieU.Data;
using MovieU.Models;

namespace MovieU.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        private void PicRandomElement(IQueryable<Movies> movies, IQueryable<TvShows> tvshows)
        {
            // this function picks a random tv show or movie and add it to the view data ....
            var rand = new Random();
            int tmp = 0;
            int rand_conditioning = rand.Next(0, 2);
            if ( rand_conditioning == 1)
            {
                var idx = rand.Next(movies.Count());
                foreach (var element in movies)
                {
                    if (tmp == idx)
                    {
                        ViewData["TopMovie"] = element;
                        break;
                    }

                    tmp++;
                }

            }
            else
            {
                var idx = rand.Next(tvshows.Count());
                foreach (var element in tvshows)
                {
                    if (tmp == idx)
                    {
                        ViewData["TopMovie"] = element;
                        break;
                    }
                    tmp++;
                }
            }
        }
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var movies = _context.Movies.OrderByDescending(u => u.Id).Take(4);
            var tvshows = _context.TvShows.OrderByDescending(t => t.Id).Take(4);
            ViewData["movies"] = movies;
            ViewData["tvShows"] = tvshows;
            PicRandomElement(movies, tvshows);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}