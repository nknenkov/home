using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NightLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife =
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            while(true)
            {
                string[] input = Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                string city = input[0];
                if (city == "END")
                {
                    break;
                }
                else
                {
                    string venue = input[1];
                    string performer = input[2];
                    if (!nightLife.ContainsKey(input[0]))
                    {
                        SortedSet<string> performers = new SortedSet<string>();
                        performers.Add(performer);
                        SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>();
                        venues.Add(venue, performers);
                        nightLife.Add(city, venues);
                    }
                    else
                    {
                        if (nightLife[city].ContainsKey(venue))
                        {
                            nightLife[city][venue].Add(performer);
                        }
                        else
                        {
                            SortedSet<string> performers = new SortedSet<string>();
                            performers.Add(performer);
                            nightLife[city].Add(venue, performers);
                        }
                    }
                }
            }
            foreach (var pair in nightLife)
            {
                Console.WriteLine(pair.Key);
                foreach (var p in pair.Value)
                {
                    Console.WriteLine("->{0}: {1}", p.Key, string.Join(", ", p.Value));
                }
            }
        }
    }
}
