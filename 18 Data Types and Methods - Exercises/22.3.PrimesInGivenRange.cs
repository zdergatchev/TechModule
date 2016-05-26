using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._3.PrimesInGivenRange
{
    class Program
        {
            static void Main()
            {
                int startNum = int.Parse(Console.ReadLine());
                int endNum = int.Parse(Console.ReadLine());

             List<int> PrimesInRange = new List<int>();
            
             PrimesInRange = FindPrimesInRange(startNum, endNum);            
            
            Console.WriteLine(string.Join(", ", PrimesInRange));

            }


            static List<int> FindPrimesInRange(int startNum, int endNum)
            {
                List<int> primes = new List<int>();

                for (int i = startNum; i <= endNum; i++)
                {
                    bool isPrime = true;

                    if (i == 1 && i == 2)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        int num = 1;
                        while (num <= Math.Sqrt(i))
                        {
                            if (i % num == 0 && num > 1)
                            {
                                isPrime = false;
                            }
                            num++;
                        }
                        if (isPrime)
                        {
                            primes.Add(i);
                        }
                    }
                }
                return primes;
            }
        }
    }


