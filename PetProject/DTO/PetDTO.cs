using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PetDTO
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Characteristic { get; set; }
        public string Species { get; set; }
        public float Weight { get; set; }
        public string Location { get; set; }
        public int AddedBy { get; set; }
        public bool IsAdopted { get; set; }
        public DateTime AddedDate { get; set; }
        public UserDTO User { get; set; }
    }
}
