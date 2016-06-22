using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09.Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                char a = char.ToUpper(words[i][0]);
                char[] letters = words[i].ToCharArray();
                letters[0] = a;
                words[i] = string.Join("", letters);
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
