using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string maxSeq = string.Empty;

            int number = 0;    
            int sequence = 0;  
            int currentSequence = 0;

            for (int i = 1; i <= numbers.Length - 1; i++)   
            {
                if (numbers[i - 1] == numbers[i])   
                {
                    currentSequence++;
                }
                else   
                {
                    currentSequence = 0;                   
                }

                if (currentSequence > sequence)     
                {
                    sequence = currentSequence;
                    number = numbers[i];            
                }
            }
            
            for (int i = 0; i <= sequence; i++)
            {
                maxSeq += number + " ";
            }
            Console.WriteLine(maxSeq); 
        }
    }
}