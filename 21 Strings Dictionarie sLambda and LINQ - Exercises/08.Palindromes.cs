using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();
            string[] words = Console.ReadLine()
              .Split(separators, StringSplitOptions.RemoveEmptyEntries)
              .OrderBy(x => x)
              .Distinct()
              .ToArray();

            List<string> palindromes = new List<string>();
            foreach (string word in words)
            {
                if (IsPalindrome(word)) 
                {
                    palindromes.Add(word);
                    
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }   

        static bool IsPalindrome(string words)
            {
                for (int i = 0; i < words.Length / 2; i++)
                {
                    if (words[i] != words[words.Length - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }
      }
}

