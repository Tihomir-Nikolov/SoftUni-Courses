using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> smallestNumber = numbers =>
            {
                int number = int.MaxValue;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < number)
                    {
                        number = numbers[i];
                    }
                }
                return number;
            };
            Console.WriteLine(smallestNumber(numbers));
        }
    }
}
