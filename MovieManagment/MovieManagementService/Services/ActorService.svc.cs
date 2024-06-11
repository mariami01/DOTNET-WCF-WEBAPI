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
    public class ActorService : IActorService
    {
        private readonly ActorDataAccess actorDataAccess = new ActorDataAccess();

        public List<Actor> GetAllActors()
        {
            return actorDataAccess.GetAllActors();
        }

        public Actor GetActorById(string actorID)
        {
            int id = int.Parse(actorID);
            return actorDataAccess.GetActorById(id);
        }

        public void AddActor(Actor actor)
        {
            actorDataAccess.AddActor(actor);
        }

        public void UpdateActor(string actorID, Actor actor)
        {
            int id = int.Parse(actorID);
            actor.ActorID = id;
            actorDataAccess.UpdateActor(actor);
        }

        public void DeleteActor(string actorID)
        {
            int id = int.Parse(actorID);
            actorDataAccess.DeleteActor(id);
        }

        public List<Actor> SearchActorsByName(string name)
        {
            return actorDataAccess.GetAllActors()
                .Where(a => a.FirstName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            a.LastName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Actor> FilterActorsByDateOfBirth(string startDate, string endDate)
        {
            DateTime? start = string.IsNullOrEmpty(startDate) ? (DateTime?)null : DateTime.Parse(startDate);
            DateTime? end = string.IsNullOrEmpty(endDate) ? (DateTime?)null : DateTime.Parse(endDate);

            return actorDataAccess.GetAllActors()
                .Where(a => (!start.HasValue || a.DateOfBirth >= start) &&
                            (!end.HasValue || a.DateOfBirth <= end))
                .ToList();
        }
    }
}
