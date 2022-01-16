using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberToEnqueue = input[0];
            int numberToDequeue = input[1];
            int numberToFind = input[2];
           Queue<int> numbers = new Queue<int>();
            int[] numbs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int couter = 0;
            foreach (var numb in numbs)
            {
                numbers.Enqueue(numb);
                couter++;
                if (couter == numberToEnqueue)
                {
                    break;
                }
            }
            if (numbers.Count > 0)
            {
                for (int i = 0; i < numberToDequeue; i++)
                {
                    numbers.Dequeue();
                }
                if (numbers.Contains(numberToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }

                }

            }

        }
    }
}
