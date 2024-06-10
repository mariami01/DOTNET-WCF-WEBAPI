using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementService.Contracts
{

        [ServiceContract]
        public interface IActorService
        {
            [OperationContract]
            List<Actor> GetAllActors();

            [OperationContract]
            Actor GetActorById(int actorID);

            [OperationContract]
            string AddActor(Actor actor);

            [OperationContract]
            void UpdateActor(Actor actor);

            [OperationContract]
            void DeleteActor(int actorID);
        }
}
