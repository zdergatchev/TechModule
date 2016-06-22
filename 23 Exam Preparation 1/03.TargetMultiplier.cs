using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TargetMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] num = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = num[col];
                }
            }

            int[] coordinateElement = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int coordinateRow = coordinateElement[0];
            int coordinateCol = coordinateElement[1];
            int sum = 0;
            for (int row = coordinateRow - 1; row <= coordinateRow + 1; row++)
            {
                for (int col = coordinateCol - 1; col <= coordinateCol + 1; col++)
                {
                    if (row == coordinateRow && col == coordinateCol)
                    {
                        sum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] +
                        matrix[row, col - 1] + matrix[row, col + 1] +
                        matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        matrix[row - 1, col - 1] = matrix[row - 1, col - 1] * matrix[coordinateRow, coordinateCol];
                        matrix[row - 1, col] = matrix[row - 1, col] * matrix[coordinateRow, coordinateCol];
                        matrix[row - 1, col + 1] = matrix[row - 1, col + 1] * matrix[coordinateRow, coordinateCol];
                        matrix[row, col - 1] = matrix[row, col - 1] * matrix[coordinateRow, coordinateCol];
                        matrix[row, col + 1] = matrix[row, col + 1] * matrix[coordinateRow, coordinateCol];
                        matrix[row + 1, col - 1] = matrix[row + 1, col - 1] * matrix[coordinateRow, coordinateCol];
                        matrix[row + 1, col] = matrix[row + 1, col] * matrix[coordinateRow, coordinateCol];
                        matrix[row + 1, col + 1] = matrix[row + 1, col + 1] * matrix[coordinateRow, coordinateCol];

                        matrix[row, col] = matrix[row, col] * sum;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {                    
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
}

