using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (var item in number)
            {
                stack.Push(item);
            }
            string[] comand = Console.ReadLine().ToLower().Split().ToArray();
            

            while (comand[0] != "end")
            {
                if (comand[0] == "add")
                {
                    
                    int numberOne = int.Parse(comand[1]);
                    int numberTwo = int.Parse(comand[2]);
                    stack.Push(numberOne);
                    stack.Push(numberTwo);
                }
                else if (comand[0] == "remove")
                {
                    
                    int count = int.Parse(comand[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                comand = Console.ReadLine().ToLower().Split().ToArray();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
