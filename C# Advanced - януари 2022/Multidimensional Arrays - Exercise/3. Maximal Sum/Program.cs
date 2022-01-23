using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            int biggestSum = int.MinValue;
            int rowsIndex = 0;
            int colsIndex = 0;
            int biggestRow = 3;
            int biggestCol = 3;
            for (int row = 0; row < rows -2; row++)
            {
                for (int col = 0; col < cols -2; col++)
                {
                    int sum = 0;
                    if (biggestRow + row -1 < rows && biggestCol + col -1 < cols)
                    {
                        sum = matrix[row, col] 
                            + matrix[row, col + 1] 
                            + matrix[row, col + 2] 
                            + matrix[row + 1, col] 
                            + matrix[row + 1, col + 1] 
                            + matrix[row + 1, col + 2] 
                            + matrix[row + 2, col] 
                            + matrix[row + 2, col + 1] 
                            + matrix[row + 2, col + 2];
                        if (sum > biggestSum)
                        {
                            biggestSum = sum;
                            rowsIndex = row;
                            colsIndex = col;
                            
                        }
                    }
                    
                }
                
            }
            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = rowsIndex; row < rowsIndex + 3; row++)
            {
                for (int col = colsIndex; col < colsIndex +3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
