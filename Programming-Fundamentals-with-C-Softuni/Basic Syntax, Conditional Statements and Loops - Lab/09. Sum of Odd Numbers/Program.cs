using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numb; i++)
            {
                sum += numb;
                Console.WriteLine(i * 2 - 1);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
