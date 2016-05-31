using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int mostFreqNum = array[0];
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < array.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFreqNum = array[j];
                    }
                }
            }
            Console.WriteLine(String.Join(" ", mostFreqNum));
        }
    }
}