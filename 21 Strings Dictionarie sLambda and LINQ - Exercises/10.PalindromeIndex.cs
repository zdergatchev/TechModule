using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();            
            if(IsPalindrome(word))
            {
                Console.WriteLine(-1);
            }
            else            
            {
                for (int i = 0; i < word.Length; i++)
                if (IsPalindrome(word.Remove(i, 1)))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
