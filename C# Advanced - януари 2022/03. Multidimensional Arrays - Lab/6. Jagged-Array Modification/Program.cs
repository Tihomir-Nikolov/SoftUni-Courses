using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for (int rows = 0; rows < n; rows++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[rows] = new int[input.Length];
                for (int cols = 0; cols < input.Length; cols++)
                {
                   
                    jagged[rows][cols] = input[cols];
                }
            }
            string[] command = Console.ReadLine().Split();
            

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length )
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command[0] == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    jagged[row][col] -= value;
                }

                command = Console.ReadLine().Split();
            }
            for (int i = 0; i < jagged.Length; i++)
            {
               
                Console.WriteLine($"{string.Join(" ", jagged[i])}");
            }
        }
    }
}
