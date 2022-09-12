using CodeFirstHandsonMovie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstHandsonMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add new movies
            MoviedbConxt db = new MoviedbConxt();
            Movies movie = new Movies() { Name = "Jannat" };
           
            db.Movies.Add(movie);
            db.SaveChanges();
        }
    }
}
