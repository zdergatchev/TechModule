using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();           
            
            bool isIndexFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                
                if (rightSum ==leftSum)
                {
                    Console.WriteLine(i);
                    isIndexFound = true;
                    break;
                }
            }            
            if (!isIndexFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
