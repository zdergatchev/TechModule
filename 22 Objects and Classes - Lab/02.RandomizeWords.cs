using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();
            var result = new List<string>();
            while (words.Count() > 0)
            {
                var randPos = rnd.Next(0, words.Count());
                result.Add(words[randPos]);
                words.RemoveAt(randPos);
            }
            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
