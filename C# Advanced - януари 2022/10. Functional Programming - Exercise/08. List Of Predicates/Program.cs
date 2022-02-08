using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> number = Enumerable.Range(1, n).ToList();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<Predicate<int>> isDivisible = new List<Predicate<int>>();
            foreach (var numb in numbers)
            {
                isDivisible.Add(x => x % numb == 0);
            }
            foreach (var numb in number)
            {
                bool isDiv = true;
                foreach (var item in isDivisible)
                {
                    
                    if (!item(numb))
                    {
                        isDiv = false;
                        break;
                    }
                }
                if (isDiv)
                {
                    Console.Write(numb + " ");
                }
            }
        }
    }
}
