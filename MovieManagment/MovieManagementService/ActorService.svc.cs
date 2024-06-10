using MovieManagementDataAccess.DataAccess;
using MovieManagementDataAccess.Models;
using MovieManagementService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ActorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ActorService.svc or ActorService.svc.cs at the Solution Explorer and start debugging.
    public class ActorService : IActorService
    {
        private ActorDataAccess actorDataAccess = new ActorDataAccess();

        public List<Actor> GetAllActors()
        {
            return actorDataAccess.GetAllActors();
        }

        public Actor GetActorById(int actorID)
        {
            return actorDataAccess.GetActorById(actorID);
        }

        public void AddActor(Actor actor)
        {
            actorDataAccess.AddActor(actor);
        }

        public void UpdateActor(Actor actor)
        {
            actorDataAccess.UpdateActor(actor);
        }

        public void DeleteActor(int actorID)
        {
            actorDataAccess.DeleteActor(actorID);
        }
    }
}
