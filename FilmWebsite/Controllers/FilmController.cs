using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmWebsite.Models;


// We must link the various methods (GET and POST) as well as the different Views here in the controller
namespace FilmWebsite.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmContext _context;

        public FilmController(FilmContext context)
        {
            _context = context;
        }

        // GET: Film
        public async Task<IActionResult> Index()
        {
            return View(await _context.Films.ToListAsync());
        }

        public IActionResult Home() // Home page View
        {
            return View();
        }

        public IActionResult Podcast() // Podcast page View
        {
            return View();
        }


        // GET: Film/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if(id==0)
                return View(new Film());
            else
                return View(_context.Films.Find(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("MovieId,Category,Title,Year,Director,Rating,Edited,PersonLent,Notes")] Film film)
        {
            if (ModelState.IsValid)
            {
                if(film.MovieId==0)
                    _context.Add(film);
                else
                    _context.Update(film);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // This is the method for delete

        // GET: Film/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
          

            var film = await _context.Films.FindAsync(id);
            _context.Films.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
