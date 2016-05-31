using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine().ToLower();

            foreach (char letter in letters)
            {
                if (char.IsLetter(letter))
                {                      
                    char result = letter.ToString()[0];
                    Console.WriteLine($"{letter} -> {(result - 97)}");
                }
            }
        }
    }
}