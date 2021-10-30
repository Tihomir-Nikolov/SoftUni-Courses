using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string coutry = Console.ReadLine();

            switch (coutry)
            {
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
