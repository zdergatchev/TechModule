using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.MaxMethod
{
    class Program
    {
        static int GetMax(int num1, int num2)
        {
            int numbers = Math.Max(num1, num2);
            return numbers;
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(num1, num2);
            Console.WriteLine(Math.Max(num3, maxNumber));
        }
    }
}
