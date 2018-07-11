using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class History : AModel
    {
        public List<Movie> Movies { get; set; }

        public History()
        {
            Movies = new List<Movie>()
            {
            new Movie()
            };
        }
    }
}
