using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementDataAccess.Models
{
    public class MovieActorRelationship
    {
        public int MovieID { get; set; }
        public int ActorID { get; set; }
        public string Role { get; set; }
    }
}
