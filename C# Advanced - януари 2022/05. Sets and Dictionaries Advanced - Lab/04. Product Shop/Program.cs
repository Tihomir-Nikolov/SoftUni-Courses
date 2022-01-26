using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shopAndProducts = new Dictionary<string, Dictionary<string, double>>();
            while (input != "Revision")
            {
                string[] splited = input.Split(", ");
                string shop = splited[0];
                string product = splited[1];
                double price = double.Parse(splited[2]);

                if (!shopAndProducts.ContainsKey(shop))
                {
                    shopAndProducts.Add(shop, new Dictionary<string, double>());
                }
                shopAndProducts[shop].Add(product, price);

                input = Console.ReadLine();
            }
            shopAndProducts = shopAndProducts.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in shopAndProducts)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
