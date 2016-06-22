using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] template = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '!', '?', ' ' };

            string[] words = Console.ReadLine().ToLower().Split(template).ToArray();
            var results = words
                         .Where(w => w != "")
                         .Where(w => w.Length < 5)
                         .OrderBy(w => w)
                         .Distinct();
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
