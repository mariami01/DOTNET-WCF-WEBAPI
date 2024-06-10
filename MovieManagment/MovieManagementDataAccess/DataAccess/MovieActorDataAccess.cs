using MovieManagementDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementDataAccess.DataAccess
{
    public class MovieActorDataAccess
    {
        private List<MovieActorRelationship> movieActorRelationships = new List<MovieActorRelationship>();

        public List<MovieActorRelationship> GetMovieActorRelationshipsByMovieId(int movieID)
        {
            return movieActorRelationships.FindAll(r => r.MovieID == movieID);
        }

        public List<MovieActorRelationship> GetMovieActorRelationshipsByActorId(int actorID)
        {
            return movieActorRelationships.FindAll(r => r.ActorID == actorID);
        }

        public void AddMovieActorRelationship(MovieActorRelationship relationship)
        {
            movieActorRelationships.Add(relationship);
        }
    }
}
