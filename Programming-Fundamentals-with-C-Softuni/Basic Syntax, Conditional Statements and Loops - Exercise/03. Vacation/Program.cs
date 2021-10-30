using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            switch (group)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        totalPrice = people * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = people * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = people * 10.46;
                    }
                    if (people >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        totalPrice = people * 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = people * 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = people * 16;
                    }
                    if (people >= 100)
                    {
                        totalPrice -= totalPrice / people * 10;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        totalPrice = people * 15;
                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = people * 20;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = people * 22.50;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
