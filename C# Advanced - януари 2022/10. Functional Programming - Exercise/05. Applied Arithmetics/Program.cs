using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            Action<int[]> addNumber = element =>
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        number[i] += 1;
                    }
                };
            Action<int[]> multiplyNumber = element =>
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] *= 2;
                }
            };
            Action<int[]> subtractNumber = element =>
            {
                for (int i = 0; i < number.Length; i++)
                {
                    number[i] -= 1;
                }
            };
            Action<int[]> print = element =>
            {
                Console.WriteLine(string.Join(" ", number));
            };

            while (input != "end")
            {
                if (input == "add")
                {
                    addNumber(number);
                }
                else if (input == "multiply")
                {
                    multiplyNumber(number);
                }
                else if (input == "subtract")
                {
                    subtractNumber(number);
                }
                else if (input == "print")
                {
                    print(number);
                }

                input = Console.ReadLine();
            }
        }
    }
}
