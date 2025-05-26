using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassIDF
{
    public class Hamas
    {
        public DateTime DateFormation { get; set; }
        public string Commander { get; set; }
        public List<Terrorist> Terrorists { get; set; }

        public Hamas()
        {
            Terrorists = new List<Terrorist>();
            Commander = "Yehia Sinwar ";
            DateFormation = new DateTime(1987, 12, 10);

        }
        public void addTerrorist(Terrorist terrorist)
        {
            Terrorists.Add(terrorist);
        }

        public void PrintTerrorist()
        {
            for (int i = 0; i < Terrorists.Count; i++)
            {
                Console.WriteLine("Terrorist name: " + Terrorists[i].Name);
                Console.WriteLine("Terrorist rating: " + Terrorists[i].Rating);
                Console.WriteLine("Terrorist status: " + Terrorists[i].Status);
                Console.WriteLine("Terrorist weapon: " + Terrorists[i].Weapon);
                Console.WriteLine("Last location: " + Terrorists[i].LastLocation);
                Console.WriteLine();

            }

        }
    }
}
