using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int rows = input;
            int cols = input;
            char[,] matrix = new char[rows, cols];
            bool isFound = false;

            for (int row = 0; row < rows; row++)
            {
                char[] simbols = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = simbols[col];
                }
            }
            char simbol = char.Parse(Console.ReadLine());
            int rowCounter = 0;
            int colCounter = 0;
            for (int row = 0; row < rows; row++)
            {
                
                colCounter = 0;
                for (int col = 0; col < cols; col++)
                {
                    if (simbol == matrix[row , col])
                    {
                        isFound = true;
                        break;
                    }                    
                    colCounter++;
                }
                if (isFound)
                {
                    break;
                }
                rowCounter++;
            }
            if (isFound)
            {
                Console.WriteLine($"({rowCounter}, {colCounter})");
            }
            else
            {
                Console.WriteLine($"{simbol} does not occur in the matrix");
            }
        }
    }
}
