using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            while (true)
            {
                if (numb % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(numb)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    numb = int.Parse(Console.ReadLine());
                }
            }


        }
    }
}
