using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^%|$.]*<(?<product>[\w]+)>[^%|$.]*\|(?<quantity>[\d]+)\|[^%|$.]*?(?<price>[\d]+[.]?\d+)?\$";

            double total = 0;
            string input = Console.ReadLine();

            while (input != "end of shift")
            {

                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double totalPrice = quantity * price;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    total += totalPrice;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
