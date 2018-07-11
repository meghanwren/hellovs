using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Person : APerson
    {
        public History History { get; set; }
        public Person()
        {
            History = new History();
        }
    }
}
