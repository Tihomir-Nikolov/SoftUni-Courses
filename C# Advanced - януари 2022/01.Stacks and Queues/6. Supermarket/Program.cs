using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid" )
                {
                    int count = names.Count;

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else if (input != "Paid")
                {
                    names.Enqueue(input);
                }  
                input = Console.ReadLine();
            }
            if (names.Count >= 0)
            {
                int count = names.Count;
                Console.WriteLine($"{count} people remaining.");
            }
        }
    }
}
