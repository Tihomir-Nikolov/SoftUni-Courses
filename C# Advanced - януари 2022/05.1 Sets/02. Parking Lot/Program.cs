using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> carNumber = new HashSet<string>();
            while (input != "END")
            {
                string[] inputParams = input.Split(", ");
                string direction = inputParams[0];
                string carNumbers = inputParams[1];
                if (direction == "IN")
                {
                    carNumber.Add(carNumbers);
                }
                else
                {
                    carNumber.Remove(carNumbers);
                }

                input = Console.ReadLine();
            }
            if (carNumber.Any())
            {
                foreach (var car in carNumber)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
