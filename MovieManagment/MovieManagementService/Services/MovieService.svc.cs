using MovieManagementDataAccess.DataAccess;
using MovieManagementDataAccess.Models;
using MovieManagementService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieManagementService.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class MovieService : IMovieService
    {
        private readonly MovieDataAccess movieDataAccess = new MovieDataAccess();

        public List<Movie> GetAllMovies()
        {
            return movieDataAccess.GetAllMovies();
        }

        public Movie GetMovieById(string movieID)
        {
            int id = int.Parse(movieID);
            return movieDataAccess.GetMovieById(id);
        }

        public void AddMovie(Movie movie)
        {
            movieDataAccess.AddMovie(movie);
        }

        public void UpdateMovie(string movieID, Movie movie)
        {
            int id = int.Parse(movieID);
            movie.MovieID = id;
            movieDataAccess.UpdateMovie(movie);
        }

        public void DeleteMovie(string movieID)
        {
            int id = int.Parse(movieID);
            movieDataAccess.DeleteMovie(id);
        }

        public List<Movie> SearchMoviesByTitle(string title)
        {
            return movieDataAccess.GetAllMovies()
                .Where(m => m.Title.IndexOf(title, System.StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Movie> FilterMovies(string title, string genre)
        {
            return movieDataAccess.GetAllMovies()
                .Where(m => (string.IsNullOrEmpty(title) || m.Title.IndexOf(title, System.StringComparison.OrdinalIgnoreCase) >= 0) &&
                            (string.IsNullOrEmpty(genre) || m.Genre.Equals(genre, System.StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
