using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] inputMatrix = new int[rows][];

            for (int row = 0; row < inputMatrix.Length; row++)
            {
                inputMatrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] actions = command.Split(' ').ToArray();
                {
                    if (actions[0] == "swap")
                    {
                        int row1 = int.Parse(actions[1]);
                        int row2 = int.Parse(actions[2]);

                        int[] tempArray = inputMatrix[row1];
                        inputMatrix[row1] = inputMatrix[row2];
                        inputMatrix[row2] = tempArray;
                    }
                  command = Console.ReadLine();
                }

                for (int row = 0; row < inputMatrix.Length; row++)
                {
                    for (int col = 0; col < inputMatrix[row].Length; col++)
                    {
                        Console.Write(inputMatrix[row][col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
