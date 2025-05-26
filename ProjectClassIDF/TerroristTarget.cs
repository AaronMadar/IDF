using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassIDF
{
    internal class TerroristTarget
    {
        public void DangerousTerrorist(Hamas hamas)
        {
            Dictionary<string, int> weaponPoints = new Dictionary<string, int>();
            weaponPoints.Add("knife", 1);
            weaponPoints.Add("gun", 2);
            weaponPoints.Add("aK47", 3);
            weaponPoints.Add("m16", 3);
            Terrorist DangersTerrorist = null;
            int maxpoints = 0;
            foreach (Terrorist t in hamas.Terrorists)
            {
                string[] weapons = t.Weapon.Split('+');
                int total = 0;

                foreach(string w in weapons)
                {
                    string weapon = w.Trim();
                    if (weaponPoints.ContainsKey(weapon))
                    {
                        total += weaponPoints[weapon];
                    }
                    total = total * t.Rating;
                }
                if (total > maxpoints)
                {
                    maxpoints = total;
                    DangersTerrorist = t;
                }
            }
            Console.WriteLine(DangersTerrorist);
            Console.WriteLine($"score:{maxpoints}");
            
        }
        
    }
}
