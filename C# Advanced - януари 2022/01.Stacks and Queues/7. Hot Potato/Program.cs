using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>();
            int counter = 0;
            foreach (var item in names)
            {
                kids.Enqueue(item);
            }
            while (kids.Count > 1)
            {
                for (int i = 0; i < number; i++)
                {
                    counter++;
                    string currentKid = kids.Dequeue();
                    if (counter == number)
                    {
                        Console.WriteLine($"Removed {currentKid}");
                        counter = 0;
                    }
                    else
                    {
                        kids.Enqueue(currentKid);
                    }
                }
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
