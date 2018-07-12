using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class FredBox
    {
        private List<Movie> Movies;

        public FredBox()
        {
            Initialize();
        }

        public FredBox(List<Movie> movies)
        {
            Initialize(movies);
        }

        public void Initialize(List<Movie> movies = null)
        {
            Movies = movies ?? new List<Movie>{ new Movie() };
        }

        public List<Movie> GetMovies()
        {
            return Movies;
        }

        public Movie MakeMovie(string title)
        {
            Movie movie = new Movie();
            try
            {
                if(string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentNullException(title, "title cannot be null or whitespace...");
                } else
                {
                    movie = new Movie()
                    {
                        Title = title
                    };
                }
            }
            catch (ArgumentNullException ex)
            {
                MakeMovie("not available"); //swallowing the error
            }
            catch (ArgumentException ex)
            {
                throw new Exception("not sure how it happened", ex);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                GC.Collect();
            }

            return movie;
            
        }

        public void DistributeMovie(Movie movie)
        {
            Movies.Add(movie);
        }
    }
}
