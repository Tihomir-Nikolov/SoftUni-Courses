﻿using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            
            for (int i = 0; i < input.Length / 2; i++)
            {
                string temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 -i] = temp;
                
            }
            Console.Write(string.Join(" ", input));
        }
    }
}
