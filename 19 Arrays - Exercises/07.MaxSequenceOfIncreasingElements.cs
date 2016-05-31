using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int maxLength = -1;
            int startIndex = -1;
            for (int index = 0; index < sequence.Length; index++)
            {
                int prevIndex = index;
                int currLength = 1;
                for (int nextIndex = index + 1; nextIndex < sequence.Length; nextIndex++)
                {
                    if (sequence[prevIndex] < sequence[nextIndex])
                    {
                        currLength++;
                    }
                    else
                    {
                        break;
                    }

                    prevIndex++;
                }

                if (currLength > maxLength)
                {
                    maxLength = currLength;
                    startIndex = index;
                }
            }

            for (int num = 0; num < maxLength; num++)
            {
                Console.Write(sequence[startIndex + num] + " ");
            }

            Console.WriteLine();
        }
    }
}