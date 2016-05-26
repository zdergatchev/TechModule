using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbersNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var digits = SumOfDigits(i);
                bool isSpecial = 
                    (digits == 5) ||
                    (digits == 7) ||
                    (digits == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }        
         }
        private static int SumOfDigits(int num)
        {
            int digits = 0;
            while (num > 0)
            {
                digits += num % 10;
                num /= 10;
            }
            return digits;
        }
    }
}
