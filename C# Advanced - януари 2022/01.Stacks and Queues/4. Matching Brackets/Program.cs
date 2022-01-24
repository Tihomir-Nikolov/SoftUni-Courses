using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int starIndex = stack.Pop();
                    int endIndex = i;
                    Console.WriteLine(expression.Substring(starIndex, endIndex - starIndex +1));
                }
            }
        }
    }
}
