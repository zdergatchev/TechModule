using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();
            int result = LargestCommonEnd(words1, words2);
            Console.WriteLine(result);
        }

        static int LargestCommonEnd(string[] words1, string[] words2)
        {
            var rightCount = 0;
            while (rightCount < words1.Length && rightCount < words2.Length)
            {
                if (words1[words1.Length - rightCount - 1] ==  words2[words2.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            var leftCount = 0;
            while (leftCount < words1.Length && leftCount < words2.Length)
            {
                if (words1[leftCount] == words2[leftCount])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }
            if (rightCount < leftCount) 
            {
                return leftCount;
            }
            else
            {
                return rightCount;
            }
        }
    }
}