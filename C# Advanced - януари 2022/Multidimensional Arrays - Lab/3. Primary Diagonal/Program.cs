using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int rows = input;
            int cols = input;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            int sum = 0;
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    
                    if (count == col)
                    {
                        sum += matrix[row, col];
                        count++;
                        break;
                    }
                    
                }
            }
            Console.WriteLine(sum);
        }
    }
}
