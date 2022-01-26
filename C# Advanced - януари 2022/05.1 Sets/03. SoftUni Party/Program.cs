using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            bool IsPartyTime = true;

            string input = Console.ReadLine();
            while (input != "END")
            {
                if (IsPartyTime)
                {
                    if (input == "PARTY")
                    {
                        IsPartyTime = false;
                    }
                }
                if (!IsPartyTime)
                {
                        if (vipGuests.Any())
                        {
                            vipGuests.Remove(input);
                        }
                        if (regularGuests.Any())
                        {
                            regularGuests.Remove(input);
                        }
                }
               else
                {
                    if (input.Substring(0, 1).Any(char.IsDigit))
                    {
                        vipGuests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
