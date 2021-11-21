using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int times = 0;
            for (int i = 1; i <= 10 ; i++)
            {
                times++;
                int result = numb * times;
                Console.WriteLine($"{numb} X {times} = {result}");
            }
        }
    }
}
