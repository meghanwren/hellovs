using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Abstracts
{
    public class AModel
    {
        public Guid Id { get; }

        public AModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
