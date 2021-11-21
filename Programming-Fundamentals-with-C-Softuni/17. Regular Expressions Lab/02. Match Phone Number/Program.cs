using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([359]+)([-| ])2(\2)(\d{3})(\2)(\d{4})\b";
            string input = Console.ReadLine();
            
            MatchCollection mached = Regex.Matches(input, pattern);

            //foreach (Match item in mached)
            //{
            //    Console.WriteLine(item.Value + " ");
            //}

            string[] macheds = mached.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", mached));
        }

    }
}
