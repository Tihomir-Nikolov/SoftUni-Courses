﻿using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int tempNumber = numb;

            int factorialSum = 0;
            while (tempNumber > 0)
            {
                int currNumber = tempNumber % 10;
                tempNumber /= 10;
                int currFactNum = 1;
                for (int i = 1; i <= currNumber; i++)
                {
                    currFactNum *= i;
                }
                factorialSum += currFactNum;
            }
            if (factorialSum == numb )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
