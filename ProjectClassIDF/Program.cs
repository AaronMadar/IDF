using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassIDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terrorist t1 = new Terrorist();
            t1.SetName("Muhamad");
            t1.SetRating(5);
            t1.SetStatus("hai");
            t1.SetWeapon("M16");
            

            Terrorist t2 = new Terrorist();
            t2.SetName("Amir");
            t2.SetRating(5);
            t2.SetStatus("hai");
            t2.SetWeapon("M16");
            



            Hamas hamas = new Hamas();
            hamas.Terrorists = new List<Terrorist>(); 
            hamas.addTerrorist(t1);
            hamas.addTerrorist(t2);

            // הדפסת מידע לבדיקה
            Console.WriteLine("Commander: " + hamas.Commander);
            Console.WriteLine("Date of Formation: " + hamas.DateFormation.ToString("dd/MM/yyyy"));
            Console.WriteLine("Terrorists count: " + hamas.Terrorists.Count);
            hamas.PrintTerrorist();


        }
    }
}
