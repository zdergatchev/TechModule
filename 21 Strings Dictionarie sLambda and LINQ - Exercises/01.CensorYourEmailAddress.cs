using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CensorYourEmailAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailSource = Console.ReadLine();
            int censorString = emailSource.IndexOf('@');
            string replacement = new string('*', censorString);
            replacement = replacement + emailSource.Substring(censorString);

            string input = Console.ReadLine();
            input = input.Replace(emailSource, replacement);
            Console.WriteLine(input);
        }
    }
}
