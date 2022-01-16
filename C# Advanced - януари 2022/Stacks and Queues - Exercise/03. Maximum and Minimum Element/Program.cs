using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] comand = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int couter = 0;
            Stack<int> numbers = new Stack<int>();
            while (n != couter)
            {
                couter++;
                if (comand[0] == 1)
                {
                    numbers.Push(comand[1]);
                }
                else if (comand[0] == 2 && numbers.Count > 0)
                {
                    numbers.Pop();
                }
                else if (comand[0] == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (comand[0] == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
                if (couter == n)
                {
                    break;
                }
                comand = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
