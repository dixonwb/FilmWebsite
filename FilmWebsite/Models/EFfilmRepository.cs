using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmWebsite.Models
{
    public class EFfilmRepository : IFilmRepository // This entity framework repository inherits from IFilm Repository
    {
        private FilmContext _context;

        public EFfilmRepository (FilmContext context)
        {
            _context = context; // We need to set the context here
        }

        public IQueryable<Film> FilmRepo => _context.Films;
    }
}
