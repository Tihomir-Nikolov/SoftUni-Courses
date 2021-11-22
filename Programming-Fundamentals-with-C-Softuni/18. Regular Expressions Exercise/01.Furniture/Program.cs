using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<name>[A-Z+a-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)\b";
            string input = Console.ReadLine();
            double totalPrice = 0;
            Console.WriteLine($"Bought furniture:");
            while (input != "Purchase")
            {
                MatchCollection macheds = Regex.Matches(input, pattern);
                foreach (Match mached in macheds)
                {
                    string name = mached.Groups["name"].Value;
                    double price = double.Parse(mached.Groups["price"].Value);
                    int quantity = int.Parse(mached.Groups["quantity"].Value);
                    Console.WriteLine($"{name}");
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
