using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool isBalanced = true;
            foreach (var item in input)
            {
                if (item == '{' || item == '(' || item == '[' )
                {
                    parentheses.Push(item);
                    continue;
                }
                if (parentheses.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (item == '}' && parentheses.Peek() == '{')
                {
                    parentheses.Pop();
                }
                else if (item == ')' && parentheses.Peek() == '(')
                {
                    parentheses.Pop();
                }
                else if (item == ']' && parentheses.Peek() == '[')
                {
                    parentheses.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }
            if (!isBalanced || parentheses.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
                
        }
    }
}
