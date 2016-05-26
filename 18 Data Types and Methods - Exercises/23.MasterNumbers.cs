﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.MasterNumbers
{
   class Program
    {
        static bool IsPalindrome(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length / 2; i++)
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }                    
            return true;
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i] - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        for (int num = 1; num <= n; num++)
            if (IsPalindrome(num) &&
            (SumOfDigits(num) % 7 == 0) && ContainsEvenDigit(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}

