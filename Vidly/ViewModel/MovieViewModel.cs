using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public Movie Movie { get; set; }
    }
}