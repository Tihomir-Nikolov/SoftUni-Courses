using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexForDistance = @"[^\.\D+\W+\d+]?(?<distance>\d+?)";
            string regexForName = @"(?<name>[A-Za-z]+)";
            Dictionary<string, int> players = new Dictionary<string, int>();
            int sum = 0;
      
            List<string> people = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection nameMached = Regex.Matches(input, regexForName);
                MatchCollection macheds = Regex.Matches(input, regexForDistance);
                string currName = string.Join("", nameMached).ToString();
                
                foreach (Match match in macheds)
                {
                    sum += int.Parse(match.Groups["distance"].Value);
   
                }
                if (people.Contains(currName) && !players.ContainsKey(currName))
                {
                    players.Add(currName, sum);
                    
                }
                else if (players.ContainsKey(currName))
                {
                    players[currName] += sum;

                }
                sum = 0;
                

                input = Console.ReadLine();
            }

            var firstPlace = players.OrderByDescending(x => x.Value).Take(1);
            var secondPlace = players.OrderByDescending(x => x.Value).Take(2).Skip(1);
            var thirdPlace = players.OrderByDescending(x => x.Value).Take(3).Skip(2);
            
            foreach (var player in firstPlace)
            {
                Console.WriteLine($"1st place: {player.Key}");
            }
            
            foreach (var player in secondPlace)
            {
                Console.WriteLine($"2nd place: {player.Key}");
            }
            foreach (var player in thirdPlace)
            {
                Console.WriteLine($"3rd place: {player.Key}");
            }
        }
    }
}
