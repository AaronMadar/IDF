using System;
using System.Collections.Generic; // ← NÉCESSAIRE POUR Dictionary

namespace ProjectClassIDF
{
    public class AMAN
    {
        private static Dictionary<string, int> terroristReported = new Dictionary<string, int>();



        public static void CreateReportMsg(Terrorist terrorist, string place, DateTime specificDate)
        {
            Console.WriteLine($"{terrorist.Name} is at {place}, {specificDate:dd/MM/yyyy HH:mm}");

            if (terroristReported.ContainsKey(terrorist.Name))
                terroristReported[terrorist.Name]++;
            else
                terroristReported[terrorist.Name] = 1;
        }




        public static void DisplayMostReportedTarget()
        {

            string mostReported = null;
            int maxReports = -1;

            foreach (var entry in terroristReported)
            {
                if (entry.Value > maxReports)
                {
                    mostReported = entry.Key.Name;
                    maxReports = entry.Value;
                }
            }

            Console.WriteLine($"The terrorist the most reported is  {mostReported} with {maxReports} reports.");
        }


    }
}
