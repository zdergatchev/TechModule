using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            char[] separators = " .,:;=()&[]\"'\\/!?".ToCharArray();
            string[] words = sentence
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            Array.Reverse(words);
            char[] newSeparator = string.Join("", words).ToCharArray();            
            string[] punctuation = sentence
                             .Split(newSeparator, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join(" ", sentence.Split(' ').Reverse()));          
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(string.Join("", words[i], punctuation[i]));
            }
            Console.WriteLine();
        }
    }
}
