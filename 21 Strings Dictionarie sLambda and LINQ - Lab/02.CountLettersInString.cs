using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int[] counts = new int[char.MaxValue + 1];
            foreach (var letter in str)
            {
                counts[letter]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    var letter = (char)i;
                    var occurences = counts[i];
                    Console.WriteLine("{0} -> {1}", letter, occurences);
                }
            }
        }
    }
}
