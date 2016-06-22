using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string particular = Console.ReadLine().ToLower();
            string[] inputText = Console.ReadLine().Split('!', '.', '?');
            for (int j = 0; j < inputText.Length; j++)
            {
                char[] delimiters = { '.', ',', ';', ':', '(', ')', '[', ']', '/', '\\', '?', '!', '\'', ' ', '"' };
                string[] words = inputText[j].Trim().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 1; i < words.Length - 1; i++)
                {
                    if (particular.Equals(words[i].ToLower()))
                    {
                        Console.WriteLine(inputText[j].Trim());
                        break;
                    }
                }
            }
        }
    }
}
