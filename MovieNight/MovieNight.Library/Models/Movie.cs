using MovieNight.Library.Abstracts;
using MovieNight.Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public string _title;

        public List<Actor> Actors { get; set; }
        public string Title { get; set; }
        public EGenre Genre
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                _title = value;
            }
        }

        public Movie()
        {
            Initialize();
        }

        public Movie(string title)
        {
            Initialize(title);
        }

        public Movie(string title, EGenre genre)
        {
            Initialize(title, genre);
        }

        public Movie(string title, EGenre genre, List<Actor> actors)
        {
            Initialize(title, genre, actors);
        }

        public void Initialize(string title = "(no title)", EGenre genre = EGenre.Romantic,List<Actor> actors = null)
        {
            Title = title;
            Genre = genre;
            Actors = actors ?? new List<Actor> { new Actor() };
        }
    }
}
