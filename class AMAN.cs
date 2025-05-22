using System;

namespace ProjectClassIDF
{
    public class AMAN
    {
        public static void CreateReportMsg(Terrorist terrorist, string place, DateTime specificDate)
        {
            Console.WriteLine($"{terrorist.Name} is at {place}, {specificDate:dd/MM/yyyy HH:mm}");
        }
    }
}
