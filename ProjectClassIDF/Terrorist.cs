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
        public string Name;
        public int Rating;
       public string Status;
        public string Weapon;





        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetRating(int rating)
        {
            Rating = rating;
        }
        public int GetSRating()
        {
            return Rating;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
        public string Getstatus()
        {
            return Status;
        }
        public void SetWeapon(String weapon)
        {
            Weapon = weapon;
        }
        public string GetWeapon()
        {
            return Weapon;
        }
       
    }
}
