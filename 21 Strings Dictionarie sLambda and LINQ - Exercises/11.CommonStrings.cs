using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CommonStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();

            bool isCommon = false;
            foreach (char text in text1)
            {
                if (text2.Contains(text))
                {
                    isCommon = true;
                    break;
                }
            }
            if (isCommon)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
