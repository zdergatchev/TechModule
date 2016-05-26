using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._1.FibonacchiNumbers
{
    class Program
    {

        static int Fib(int n)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            for (var i = 0; i < 100; i++)
            {
                int fNext = firstNumber + secondNumber;
                if (i == n)
                {
                    return firstNumber;
                }
                firstNumber = secondNumber;
                secondNumber = fNext;
            }
            return n;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int neededNum = Fib(n);

            Console.WriteLine(neededNum);         
        }
    }
}
