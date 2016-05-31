using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int shiftStep = int.Parse(Console.ReadLine());

            int[] arrayTemp = new int[arr.Length];
            int[] resultArr = new int[arr.Length];

            for (int i = 0; i < shiftStep; i++)
            {
                int lastElement = arr[arr.Length - 1];           
                for (int j = arr.Length - 1; j >= 1; j--)
                {
                    arr[j] = arr[j - 1];        
                }
                arr[0] = lastElement;
                for (int k = 0; k < arr.Length; k++)
                {
                    resultArr[k] = resultArr[k] + arr[k];   
                }
            }
            Console.WriteLine(string.Join(" ", resultArr));

        }
    }
}