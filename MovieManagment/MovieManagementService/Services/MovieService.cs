using MovieManagementDataAccess.DataAccess;
using MovieManagementDataAccess.Models;
using MovieManagementService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManagementService.Services
{
    public class MovieService : IMovieService
    {
        private MovieDataAccess movieDataAccess = new MovieDataAccess();

        public List<Movie> GetAllMovies()
        {
            return movieDataAccess.GetAllMovies();
        }

        public Movie GetMovieById(int movieID)
        {
            return movieDataAccess.GetMovieById(movieID);
        }

        public void AddMovie(Movie movie)
        {
            movieDataAccess.AddMovie(movie);
        }

        public void UpdateMovie(Movie movie)
        {
            movieDataAccess.UpdateMovie(movie);
        }

        public void DeleteMovie(int movieID)
        {
            movieDataAccess.DeleteMovie(movieID);
        }
    }
}