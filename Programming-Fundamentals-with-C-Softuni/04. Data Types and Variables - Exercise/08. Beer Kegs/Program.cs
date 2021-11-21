using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bigestKeg = double.MinValue;
            string bigestmodel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double capacity = Math.PI * Math.Pow(radius, 2) * height;
                if (capacity > bigestKeg)
                {
                    bigestKeg = capacity;
                    bigestmodel = model;
                }
            }
            Console.WriteLine(bigestmodel);
        }
    }
}
