using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] name = Console.ReadLine().Split();

            Func<string, int, bool> nameLenght = (name, lenght) =>
           name.Length <= lenght;

            string[] names = name.Where(x => nameLenght(x, n)).ToArray();

            Console.WriteLine(string.Join("\n" , names));
        }
    }
}
