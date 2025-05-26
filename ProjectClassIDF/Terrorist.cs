using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassIDF
{
    public class Terrorist
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Status { get; set; }
        public string Weapon { get; set; }
        public string LastLocation { get; set; }

        
        public Terrorist(string name, int rating, string status, string weapon, string lastLocation)
        {
            Name = name;
            Rating = rating;
            Status = status;
            Weapon = weapon;
            LastLocation = lastLocation;
        }
    }

}
