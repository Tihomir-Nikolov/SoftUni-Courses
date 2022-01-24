using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "END")
            {
                if (commands.Length > 5 || commands.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string command = commands[0];
                    int rowStartIndex = int.Parse(commands[1]);
                    int colStartIndex = int.Parse(commands[2]);
                    int rowEndIndex = int.Parse(commands[3]);
                    int colEndIndex = int.Parse(commands[4]);
                    string first = string.Empty;
                    string second = string.Empty;
                    bool isFound = false;
                    if (rowStartIndex > matrix.GetLength(0) && colStartIndex > matrix.GetLength(1) && rowEndIndex > matrix.GetLength(0) && colEndIndex > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    if (command == "swap")
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                if (rowStartIndex < matrix.GetLength(0) && colStartIndex < matrix.GetLength(1) && rowEndIndex < matrix.GetLength(0) && colEndIndex < matrix.GetLength(1))
                                {
                                    if (rowStartIndex == row && colStartIndex == col)
                                    {
                                        first = matrix[row, col];
                                        second = matrix[rowEndIndex, colEndIndex];
                                        matrix[rowEndIndex, colEndIndex] = first;
                                        matrix[rowStartIndex, colStartIndex] = second;
                                        for (int i = 0; i < rows; i++)
                                        {
                                            for (int j = 0; j < cols; j++)
                                            {
                                                Console.Write($"{matrix[i, j]} ");
                                            }
                                            Console.WriteLine();
                                        }
                                        isFound = true;
                                        break;
                                    }
                                }
                            }
                            if (isFound)
                            {
                                break;
                            }
                        }
                    }
                }
                commands = Console.ReadLine().Split();
            }
        }
    }
}
