using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rands = new RandomList();
            rands.Add("11");
            rands.Add("15");
            rands.Add("12");
            rands.Add("13");
            Console.WriteLine(rands.RandomString());
            Console.WriteLine(rands.RandomString());
            Console.WriteLine(rands.RandomString());
        }
    }
}
