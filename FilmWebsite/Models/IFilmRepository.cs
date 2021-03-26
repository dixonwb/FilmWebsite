using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The repository method is not required, but it makes things easier
// we will make a rempository of films that is queryable (able to query from)

namespace FilmWebsite.Models
{
    public interface IFilmRepository
    {
        IQueryable<Film> FilmRepo { get; }
    }
}
