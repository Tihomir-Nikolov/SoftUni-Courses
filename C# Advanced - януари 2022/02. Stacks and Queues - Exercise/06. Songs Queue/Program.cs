using System;
using System.Collections.Generic;
using System.Text;
namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            string comands = Console.ReadLine();
            Queue<string> pleyList = new Queue<string>();
            foreach (var item in songs)
            {
                pleyList.Enqueue(item);
            }
            while (pleyList.Count > 0)
            {
                if (comands == "Play")
                {
                    if (pleyList.Count > 0)
                    {
                        pleyList.Dequeue();

                    }
                    else
                    {
                        Console.WriteLine("No more songs!");
                    }
                }
                else if (comands.StartsWith("Add"))
                {
                    var song = comands.Substring(4);

                    if (pleyList.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");

                    }
                    else
                    {
                        pleyList.Enqueue(song);
                    }
                }
                else if (comands == "Show")
                {
                    if (pleyList.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", pleyList));
                    }

                }
                comands = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
