using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieU.Data;
using MovieU.Models;

namespace MovieU.Controllers
{
    [Authorize]
    public class AdminTvShowsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminTvShowsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminTvShows
        public async Task<IActionResult> Index()
        {
            return View(await _context.TvShows.ToListAsync());
        }

        // GET: AdminTvShows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tvShows = await _context.TvShows
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tvShows == null)
            {
                return NotFound();
            }

            return View(tvShows);
        }

        // GET: AdminTvShows/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminTvShows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Photo,StreamUrl,Episode,Tags")] TvShows tvShows)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tvShows);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tvShows);
        }

        // GET: AdminTvShows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tvShows = await _context.TvShows.FindAsync(id);
            if (tvShows == null)
            {
                return NotFound();
            }
            return View(tvShows);
        }

        // POST: AdminTvShows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Photo,StreamUrl,Episode, Tags")] TvShows tvShows)
        {
            if (id != tvShows.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tvShows);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TvShowsExists(tvShows.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tvShows);
        }

        // GET: AdminTvShows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tvShows = await _context.TvShows
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tvShows == null)
            {
                return NotFound();
            }

            return View(tvShows);
        }

        // POST: AdminTvShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tvShows = await _context.TvShows.FindAsync(id);
            _context.TvShows.Remove(tvShows);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TvShowsExists(int id)
        {
            return _context.TvShows.Any(e => e.Id == id);
        }
    }
}
