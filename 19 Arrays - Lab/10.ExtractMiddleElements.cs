using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MiddleElements
{
    class Program
    {
        static int[] ExtractMiddleElements(int[] arr)
        {
            int start = arr.Length / 2 - 1;
            int end = start + 2;
            if (arr.Length == 1)
            {
                start = end = 0;
            }
            else if (arr.Length % 2 == 0)
            {
                end--;
            }
            int[] mid = new int[end - start + 1];
            for (int i = start; i <= end; i++)
            {
                mid[i - start] = arr[i];
            }
            return mid;
                        
        }
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result =  ExtractMiddleElements(arr);              
           
            Console.WriteLine("{" + string.Join(", ", result) + "}");
            
        }
    }
}