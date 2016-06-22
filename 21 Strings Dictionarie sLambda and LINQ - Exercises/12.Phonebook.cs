using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
            for (;;)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] str = input.Split(' ').ToArray();
                switch (str[0])
                {
                    case "A":
                        phoneBook[str[1]] = str[2];
                        break;

                    case "S":
                        if (phoneBook.ContainsKey(str[1]))
                        {
                            Console.WriteLine($"{str[1]} -> {phoneBook[str[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {str[1]} does not exist.");
                        }
                        break;

                    case "ListAll":
                        foreach (var pairs in phoneBook)
                        {
                            Console.WriteLine($"{pairs.Key} -> {pairs.Value}");
                        }
                        break;
                }
            }
        }
    }
}
          

