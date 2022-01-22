using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            int bigestRows = 2;
            int bigestCols = 2;
            int indexRows = 0;
            int indexCols = 0;
            int bigestSum = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                int[] rowsInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    
                    
                        int sum = 0;
                        if (bigestCols + col - 1 < cols && bigestRows + row - 1 < rows)
                        {
                            sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                        }
                        if (sum > bigestSum)
                        {
                            bigestSum = sum;
                            indexRows = row;
                            indexCols = col;
                        }
                    
                }
            }
            for (int row = indexRows; row < indexRows + bigestRows  ; row++)
            {
                for (int col = indexCols; col < indexCols + bigestCols ; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(bigestSum);
        }
    }
}
