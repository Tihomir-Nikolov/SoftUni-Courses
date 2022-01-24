using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>();         
            int currentReck = 0;
            int recks = 0;
            foreach (var item in box)
            {
                clothes.Push(item);
            }
            while (clothes.Count > 0)
            {
                int currentCloting = clothes.Peek();
                if (capacity >= (currentReck + currentCloting))
                {
                    clothes.Pop();
                    currentReck += currentCloting;
                    if (currentReck == capacity)
                    {
                        recks++;
                        currentReck = 0;
                    }
                }
                else if (currentReck + currentCloting > capacity)
                {
                    recks++;
                    currentReck = 0;
                    currentReck += currentCloting;
                    clothes.Pop();

                }
            }
            if (currentReck > 0)
            {
                recks++;
            }
          
            Console.WriteLine(recks);
        }
    }
}
