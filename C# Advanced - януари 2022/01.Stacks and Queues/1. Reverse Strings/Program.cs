using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (char item in input)
            {
                stack.Push(item);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
