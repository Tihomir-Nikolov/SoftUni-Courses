using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int from = int.Parse(Console.ReadLine());
            int to = 10;


            do
            {
                Console.WriteLine($"{numb} X {from} = {numb * from}");
                from++;
            } while (from <= to);

        }
    }
}
