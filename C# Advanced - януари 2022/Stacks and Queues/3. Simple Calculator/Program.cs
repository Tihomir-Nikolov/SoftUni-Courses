using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            var input = input1.Reverse();
            Stack<string> stack = new Stack<string>();
            int sum = 0;
            foreach (var item in input)
            {
                stack.Push(item);
            }
            sum += int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                if (stack.Count > 0)
                {
                    string current = stack.Pop();
                    
                    if (current == "+")
                    {
                        int n = int.Parse(stack.Pop());
                        sum += n;
                    }
                    else if (current == "-")
                    {
                        int n = int.Parse(stack.Pop());
                        sum -= n;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
