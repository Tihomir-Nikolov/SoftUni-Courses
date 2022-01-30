using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!count.ContainsKey(input[i]))
                {
                    count.Add(input[i], 1);
                }
                else
                {
                    count[input[i]]++;
                }
            }
            var symbols = count.OrderBy(x => x.Key);
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
