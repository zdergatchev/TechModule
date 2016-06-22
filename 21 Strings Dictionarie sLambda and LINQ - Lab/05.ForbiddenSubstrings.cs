using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForbiddenSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            foreach (var w in words)
            {
                str = str.Replace(w, new string('*', w.Length));
            }
            Console.WriteLine(str);
        }
    }
}
