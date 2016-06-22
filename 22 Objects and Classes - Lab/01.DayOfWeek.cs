using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateElements = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            var date = new DateTime(dateElements[2], dateElements[1], dateElements[0]);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}