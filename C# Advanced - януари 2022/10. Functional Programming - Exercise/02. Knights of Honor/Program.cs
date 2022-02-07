using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> prin = input => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", input));
            prin(input);
        }
    }
}
