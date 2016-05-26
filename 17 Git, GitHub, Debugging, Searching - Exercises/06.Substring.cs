using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
                        
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 112)
                {
                    hasMatch = true;
                    int endIndex = jump + 1;

                    if (endIndex > text.Length - i)
                    {
                        endIndex = text.Length - i;
                    }
                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }

        }
    }
}
