using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            while (input != "end")
            {
                if (input == "green" && cars.Count > 0)
                {
                    for (int i = 0; i < seconds; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                        if (cars.Count <= 0)
                        {
                            break;
                        }
                    }
                }
               if (input != "green" && input != "end")
                {
                    cars.Enqueue(input);
                } 
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
