using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day5SimpleMVCApp.Models
{
    public class Repository
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie> 
            {
                new Movie { Title = "Star Wars", Director = "Lucas" },
                new Movie { Title = "King King", Director = "Jackson" },
                new Movie { Title = "Memento", Director = "Nolan" }
            };
        }
    }
}