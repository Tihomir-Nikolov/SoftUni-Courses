using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> prin = input => Console.WriteLine(string.Join(Environment.NewLine, input));
            prin(input);
        }
    }
}
