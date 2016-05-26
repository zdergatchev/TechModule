using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLettersNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char letter1 = 'a'; letter1 < 'a' + n; letter1++)
                for (char letter2 = 'a'; letter2 < 'a' + n; letter2++)
                    for (char letter3 = 'a'; letter3 < 'a' + n; letter3++)
                    {                        
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                   
                    }
        }
    }
}
