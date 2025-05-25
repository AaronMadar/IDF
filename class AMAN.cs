using System;
using System.Collections.Generic;

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
    }
}
