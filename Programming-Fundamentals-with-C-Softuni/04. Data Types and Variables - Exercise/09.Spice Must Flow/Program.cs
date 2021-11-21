using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WORKERS = 26;
            const int COST_RESOURCE_PER_DAY = 10;

            int gold = int.Parse(Console.ReadLine());
            int totalGold = 0;
            int couterOfDays = 0;

            while (true)
            {
                if (gold < 100) break;

                int startGold = gold;
                couterOfDays++;
                gold -= WORKERS;
                totalGold += gold;
                gold = startGold - COST_RESOURCE_PER_DAY;


            }
            totalGold -= WORKERS;
            Console.WriteLine(couterOfDays);
            Console.WriteLine(totalGold);
        }
    }
}

