using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> order = new Queue<int>();
            foreach (var item in orders)
            {
                order.Enqueue(item);
            }
            Console.WriteLine(order.Max());

            while (order.Count > 0)
            {
                int currentOrder = order.Peek();
                if (food >= currentOrder)
                {
                    order.Dequeue();
                    food -= currentOrder;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", order)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
