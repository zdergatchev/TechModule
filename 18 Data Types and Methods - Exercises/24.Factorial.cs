﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _24.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for(int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
