using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstHandsonMovie.Entities
{
    internal class MoviedbConxt:DbContext
    {
        //configure the connectionstring using app.config file
        public MoviedbConxt() : base("name=MovieConnection")
        {

        }
        //define the set
        public DbSet<Movies> Movies { get; set; }

    }
}
