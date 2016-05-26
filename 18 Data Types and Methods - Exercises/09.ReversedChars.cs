using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[3];
            for (int i = 0; i < letters.Length; i++)
            {                
                letters[i] = char.Parse(Console.ReadLine());
            }
            Array.Reverse(letters);
            Console.WriteLine(string.Join("", letters));
        }
    }
}
