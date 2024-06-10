using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementDataAccess.DataAccess
{
    public class MovieDataAccess
    {

        private List<Movie> movies = new List<Movie>();
        private int nextMovieID = 1;

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieById(int movieID)
        {
            return movies.Find(m => m.MovieID == movieID);
        }

        public void AddMovie(Movie movie)
        {
            movie.MovieID = nextMovieID++;
            movies.Add(movie);
        }

        public void UpdateMovie(Movie movie)
        {
            int index = movies.FindIndex(m => m.MovieID == movie.MovieID);
            if (index != -1)
            {
                movies[index] = movie;
            }
        }

        public void DeleteMovie(int movieID)
        {
            movies.RemoveAll(m => m.MovieID == movieID);
        }
    }
}
