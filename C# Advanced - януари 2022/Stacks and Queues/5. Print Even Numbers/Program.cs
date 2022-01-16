using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queues = new Queue<int>();
            foreach (var item in number)
            {
                queues.Enqueue(item);
            }
            List<string> evenNumber = new List<string>();
            while (queues.Count > 0 )
            {
                int currentNumber = queues.Dequeue();
                if (currentNumber % 2 == 0)
                {
                    
                    evenNumber.Add(currentNumber.ToString());

                    
                }
            }
            Console.Write(string.Join(", ", evenNumber));
        }
    }
}
