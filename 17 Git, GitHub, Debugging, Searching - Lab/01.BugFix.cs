using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BugFix
{
    class Program
    {
        static void Main(string[] args)
        {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
        int holidaysCount = 0;
            for (var date = startDate; date <= endDate;date = date.AddDays(1))
            //while (startDate <= endDate)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    //startDate = startDate.AddDays(1);
                   // continue;
                    holidaysCount++;
                }
                
               // startDate = startDate.AddDays(1);
               // holidaysCount++;
            }
            Console.WriteLine("{0}", holidaysCount);
        }
    }
}
