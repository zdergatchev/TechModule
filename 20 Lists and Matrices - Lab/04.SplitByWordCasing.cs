using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var separators = " ,;:.!( )\"'/\\[ ] ".ToArray();
            var words = s.Split(separators);
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            foreach (var w in words)
            {
                if (w != "")
                {
                    var lowerLetter = 0;
                    var upperLetter = 0;
                    foreach (var letter in w)
                    {
                        if (char.IsLower(letter)) lowerLetter++;
                        if (char.IsUpper(letter)) upperLetter++;
                    }
                    if (upperLetter == w.Length)
                    {
                        upperCaseWords.Add(w);
                    }
                    else if (lowerLetter == w.Length)
                    {
                        lowerCaseWords.Add(w);
                    }
                    else
                    {
                        mixedCaseWords.Add(w);
                    }
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
            
        }
    }
}

