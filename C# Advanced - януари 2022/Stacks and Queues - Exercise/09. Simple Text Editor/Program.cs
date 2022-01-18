using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 someString - appends someString to the end of the text
            //2 count - erases the last count elements from the text
            //3 index - returns the element at position index from the text
            //4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation

            int n = int.Parse(Console.ReadLine());
           
            Stack<string> undoes = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] commandName = Console.ReadLine().Split();
                string command = commandName[0];
               
                if (command == "1")
                {
                    undoes.Push(sb.ToString());
                    sb.Append(commandName[1]);
                }
                else if (command == "2")
                {
                    undoes.Push(sb.ToString());
                    int count = int.Parse(commandName[1]);
                    while (count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        count--;
                    }

                }
                else if (command == "3")
                {
                    int index = int.Parse(commandName[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                else
                {
                    sb.Clear();
                    sb.Append(undoes.Pop());
                }
            }
        }
    }
}
