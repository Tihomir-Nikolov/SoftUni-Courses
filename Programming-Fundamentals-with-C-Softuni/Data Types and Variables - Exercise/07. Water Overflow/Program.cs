using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACYTY = 255;
            int n = int.Parse(Console.ReadLine());
            
            int totalLiters = CAPACYTY;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (totalLiters - liters >= 0 )
                {
                    totalLiters -= liters;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                
            }
            int total = CAPACYTY - totalLiters;
            Console.WriteLine(total);
           
        }
    }
}
