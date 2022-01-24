using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int[,] matrix = new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                firstSum += matrix[i, i];
                secondSum += matrix[i, matrix.GetLength(1) - 1 - i];
            }
            int diff = Math.Abs(secondSum - firstSum);
            Console.WriteLine(diff);
        }
    }
}
