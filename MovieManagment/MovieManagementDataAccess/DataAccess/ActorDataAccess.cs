using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementDataAccess.DataAccess
{
    public class ActorDataAccess
    {
        private List<Actor> actors = new List<Actor>();
        private int nextActorID = 1;

        public List<Actor> GetAllActors()
        {
            return actors;
        }

        public Actor GetActorById(int actorID)
        {
            return actors.Find(a => a.ActorID == actorID);
        }

        public void AddActor(Actor actor)
        {
            actor.ActorID = nextActorID++;
            actors.Add(actor);
        }

        public void UpdateActor(Actor actor)
        {
            int index = actors.FindIndex(a => a.ActorID == actor.ActorID);
            if (index != -1)
            {
                actors[index] = actor;
            }
        }

        public void DeleteActor(int actorID)
        {
            actors.RemoveAll(a => a.ActorID == actorID);
        }
    }
}
