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

        public Hamas(Terrorist Terrorists)
        {
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
                Console.WriteLine("terrorist name: " + Terrorists[i].GetName());
                Console.WriteLine("terrorist rating: " + Terrorists[i].GetSRating());
                Console.WriteLine("terrorist status: " + Terrorists[i].Getstatus());
                Console.WriteLine("terrorist amountreports: " + Terrorists[i].GetAmountreports());
                Console.WriteLine("First terrorist weapon: " + Terrorists[i].GetWeapon());

            }

        }
    }
}
