using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studenGrades = new Dictionary<string, List<decimal>>();
            
            for (int i = 0; i < numberStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grades = decimal.Parse(input[1]);

                if (!studenGrades.ContainsKey((studentName)))
                {
                    studenGrades.Add(studentName, new List<decimal>());
                    
                }
                studenGrades[studentName].Add(grades);
            }
            foreach (var item in studenGrades)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
