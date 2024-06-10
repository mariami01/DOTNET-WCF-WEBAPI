using MovieManagementDataAccess.DataAccess;
using MovieManagementDataAccess.Models;
using MovieManagementService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManagementService.Services
{
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

        public string AddActor(Actor actor)
        {
           actorDataAccess.AddActor(actor);
            return "hello";
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