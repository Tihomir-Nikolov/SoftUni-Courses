using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> isUpper = x => Char.IsUpper(x[0]);
            Console.WriteLine(string.Join("\n", text.Where(isUpper)));
        }
    }
}
