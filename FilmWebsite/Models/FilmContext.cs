using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The database context class is necessary in order to create the database
// It inherits from the standard DbContext class

namespace FilmWebsite.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }
    }
}
