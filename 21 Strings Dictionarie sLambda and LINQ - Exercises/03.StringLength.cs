using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int length = 20;
            if (text.Length > length)
            {
                text = text.Substring(0, length);
                //text = Console.ReadLine().PadRight(20, '*');
            }
            else if (text.Length < length)
            {
                text = string.Join("", text, new string('*', length - text.Length));
            }                
            Console.WriteLine(text);
        }
    }
}
