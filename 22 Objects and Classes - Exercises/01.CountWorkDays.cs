using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDateTime = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(startDate);

            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2000,01,01),
                new DateTime(2000,03,03),
                new DateTime(2000,05,01),
                new DateTime(2000,05,06),
                new DateTime(2000,05,24),
                new DateTime(2000,09,06),
                new DateTime(2000,09,22),
                new DateTime(2000,11,01),
                new DateTime(2000,12,24),
                new DateTime(2000,12,25),
                new DateTime(2000,12,26)
            };

            int workingDays = 0;

            for (var date = startDate; date <= endDateTime; date = date.AddDays(1))
            {
                DateTime temp = new DateTime(2000, date.Month, date.Day);
                if ((date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday) && !holidays.Contains(temp))
                {
                    workingDays++;
                }
                //Console.WriteLine(date.DayOfWeek);
            }

            Console.WriteLine(workingDays);
            //Console.WriteLine(holidays[0].Day);
        }
    }
}
