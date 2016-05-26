﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.EnglishNameOf_TheLastDigit
{
    class Program
    {   
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            EnglishNameOfTheLastDigit(num);
            switch(EnglishNameOfTheLastDigit(Math.Abs(num)))
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: break;
            }            
        }       

        static long EnglishNameOfTheLastDigit(long num)
        {
            long lastDigit = num % 10;
            return lastDigit;
        }
    }
}
