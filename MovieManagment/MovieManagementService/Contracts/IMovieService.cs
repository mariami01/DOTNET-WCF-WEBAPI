using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ServiceModel;
using MovieManagementDataAccess.Models;
using System.Web.Services.Description;
using System.ServiceModel.Web;

namespace MovieManagementService.Contracts
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "movies", ResponseFormat = WebMessageFormat.Json)]
        List<Movie> GetAllMovies();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "movies/{movieID}", ResponseFormat = WebMessageFormat.Json)]
        Movie GetMovieById(string movieID);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "movies", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddMovie(Movie movie);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "movies/{movieID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateMovie(string movieID, Movie movie);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "movies/{movieID}", ResponseFormat = WebMessageFormat.Json)]
        void DeleteMovie(string movieID);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "movies/search?title={title}", ResponseFormat = WebMessageFormat.Json)]
        List<Movie> SearchMoviesByTitle(string title);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "movies/filter?title={title}&genre={genre}", ResponseFormat = WebMessageFormat.Json)]
        List<Movie> FilterMovies(string title, string genre);
    }
}
