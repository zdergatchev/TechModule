using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {            
            decimal allWater = decimal.Parse(Console.ReadLine());
            decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            List<int> listInd = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int currInd;
                if (allWater % 2 == 0)
                {
                    currInd = i;
                }
                else
                {
                    currInd = arr.Length - 1 - i;
                }
                if (arr[currInd] < capacity && allWater >= capacity)
                {
                    allWater -= (capacity - arr[currInd]);
                    arr[currInd] = capacity;

                }
                else
                {
                    allWater -= (capacity - arr[currInd]);
                    listInd.Add(currInd);
                }
            }
            if (allWater >= 0)
            {
                Console.WriteLine($"Enough water!");
                Console.WriteLine($"Water left: {allWater}l.");
            }
            else
            {
                Console.WriteLine($"We need more water!");
                Console.WriteLine($"Bottles left: {listInd.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", listInd)}");
                Console.WriteLine($"We need {(-1 * allWater)} more liters!");
            }
        }
    }
}
