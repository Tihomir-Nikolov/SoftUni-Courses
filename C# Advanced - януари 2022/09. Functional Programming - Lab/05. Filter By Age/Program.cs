using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person 
    {
        public string Name;
        public int Age;
    }   
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person();
                person.Age = age;
                person.Name = name;
                people.Add(person);
            }
            string filterName = Console.ReadLine();
            int ageToCompareWhit = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = p => true;
            if (filterName == "younger")
            {
                filter = p => p.Age < ageToCompareWhit;
            }
            else if (filterName == "older")
            {
                filter = p => p.Age >= ageToCompareWhit;
            }

            List<Person> filterPeople = people.Where(filter).ToList();

            string line = Console.ReadLine();
            Func<Person, string> print = p => p.Name + " " + p.Age;
            if (line == "name age")
            {
                print = p => p.Name + " - " + p.Age;
            }
            else if (line == "name")
            {   
                print = p => p.Name;
            }
            else if (line == "age")
            {
                print = p => p.Age.ToString();
            }
            List<string> printPeople = filterPeople.Select(print).ToList();
            foreach (var item in printPeople)
            {
                Console.WriteLine(item);
            }
        }
    }
}
