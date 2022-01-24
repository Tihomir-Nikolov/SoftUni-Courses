using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            char[] snake = Console.ReadLine().ToCharArray();
            Queue<char> symbols = new Queue<char>();
            bool left = true;
            foreach (char symbol in snake)
            {
                symbols.Enqueue(symbol);
            }
            for (int row = 0; row < rows; row++)
            {
                if (left)
                {
                    left = false;
                    for (int col = 0; col < cols; col++)
                    {
                        char item = symbols.Dequeue();
                        matrix[row, col] = item;
                        symbols.Enqueue(item);
                    }
                }
                else
                {
                    left = true;

                    for (int col = cols -1 ; col >= 0; col--)
                    {
                        char item = symbols.Dequeue();
                        matrix[row, col] = item;
                        symbols.Enqueue(item);
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
