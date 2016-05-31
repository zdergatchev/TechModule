using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();     
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;           
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int currDifference = numbers[i] - numbers[j];
                    if (currDifference < 0)
                    {
                        currDifference *= -1;                        
                    }
                    if (currDifference == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}