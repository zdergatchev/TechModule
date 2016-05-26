using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.NumberInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string reverse = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverse += num[i];
                //Console.Write("{0}", num[i]);
            }
            Console.WriteLine(reverse);

            //long num = long.Parse(Console.ReadLine());
            //string reverse = "";
            //while(num > 0)
            //{
            //    long n = num % 10;
            //    reverse += n.ToString();
            //    num /= 10;
            //}
            //Console.WriteLine(reverse);

        }
    }
}
