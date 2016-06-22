using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string tag1 = "<upcase>";
            string tag2 = "</upcase>";
           

            while(true)
            {
                int indexTag1 = -1;
                int indexTag2 = -1;
                string low = "";
                string up = "";
                indexTag1 = text.IndexOf(tag1);
                indexTag2 = text.IndexOf(tag2);
                if (indexTag1 > -1 && indexTag2 > -1)
                {
                    low = text.Substring((indexTag1), indexTag2 + 9 - indexTag1);
                    up = text.Substring(indexTag1 + 8, indexTag2 - indexTag1 - 8).ToUpper();
                    text = text.Replace(low, up);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(text);
        }
    }
}

