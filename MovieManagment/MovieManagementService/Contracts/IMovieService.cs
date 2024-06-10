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

namespace MovieManagementService.Contracts
{
        [ServiceContract]
        public interface IMovieService
        {
            [OperationContract]
            List<Movie> GetAllMovies();

            [OperationContract]
            Movie GetMovieById(int movieID);

            [OperationContract]
            void AddMovie(Movie movie);

            [OperationContract]
            void UpdateMovie(Movie movie);

            [OperationContract]
            void DeleteMovie(int movieID);
        }

}
