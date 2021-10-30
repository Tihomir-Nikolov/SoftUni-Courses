using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string passwprd = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                passwprd += username[i];
                
            }
            int couter = 0;
           string input = Console.ReadLine();

            while (input != passwprd)
            {
                
                couter++;
               
                if (couter > 3 )
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
               input = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");

        }
    }
}
