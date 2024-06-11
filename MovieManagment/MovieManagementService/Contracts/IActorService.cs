using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementService.Contracts
{
    [ServiceContract]
    public interface IActorService
    {
            [OperationContract]
            [WebInvoke(Method = "GET", UriTemplate = "actors", ResponseFormat = WebMessageFormat.Json)]
            List<Actor> GetAllActors();

            [OperationContract]
            [WebInvoke(Method = "GET", UriTemplate = "actors/{actorID}", ResponseFormat = WebMessageFormat.Json)]
            Actor GetActorById(string actorID);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = "actors", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            void AddActor(Actor actor);

            [OperationContract]
            [WebInvoke(Method = "PUT", UriTemplate = "actors/{actorID}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            void UpdateActor(string actorID, Actor actor);

            [OperationContract]
            [WebInvoke(Method = "DELETE", UriTemplate = "actors/{actorID}", ResponseFormat = WebMessageFormat.Json)]
            void DeleteActor(string actorID);

            [OperationContract]
            [WebInvoke(Method = "GET", UriTemplate = "actors/search?name={name}", ResponseFormat = WebMessageFormat.Json)]
            List<Actor> SearchActorsByName(string name);

            [OperationContract]
            [WebInvoke(Method = "GET", UriTemplate = "actors/filter?startDate={startDate}&endDate={endDate}", ResponseFormat = WebMessageFormat.Json)]
            List<Actor> FilterActorsByDateOfBirth(string startDate, string endDate);
        }
}
