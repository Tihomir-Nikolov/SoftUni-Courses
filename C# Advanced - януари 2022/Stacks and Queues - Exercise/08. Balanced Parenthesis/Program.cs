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
           
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    parentheses.Push(input[i]);

                }
                else
                {
                    if (input[i] == ')')
                    {
                        char currentParentheses = parentheses.Peek();
                        if (currentParentheses == '(')
                        {
                            parentheses.Pop();
                        }
                        else
                        {
                            break;
                            Console.WriteLine("NO");
                        }
                    }
                    if (parentheses.Count > 0)
                    {
                        if (input[i] == '}')
                        {
                            char currentParentheses = parentheses.Peek();
                            if (currentParentheses == '{')
                            {
                                parentheses.Pop();
                            }
                            else
                            {
                                break;
                                Console.WriteLine("NO");
                            }
                        }
                        else if (input[i] == ']')
                        {
                            char currentParentheses = parentheses.Peek();
                            if (currentParentheses == '[')
                            {
                                parentheses.Pop();
                            }
                            else
                            {
                                break;
                                Console.WriteLine("NO");
                            }
                        }
                    }
                    
                } 
                
            }
            if (parentheses.Contains('(') || parentheses.Contains('[') || parentheses.Contains('{'))
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
