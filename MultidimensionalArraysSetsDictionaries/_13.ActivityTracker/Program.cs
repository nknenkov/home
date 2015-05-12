using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ActivityTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, SortedDictionary<string, double>> theSpy = new SortedDictionary<int, SortedDictionary<string, double>>();
            SortedDictionary<string, double> data = new SortedDictionary<string, double>();
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                DateTime date = DateTime.Parse(input[0]);
                int month = date.Month;
                string name = input[1];
                double distance = double.Parse(input[2]);

                if (!theSpy.ContainsKey(month))
                {
                    data = new SortedDictionary<string, double>();
                    data.Add(name, distance);
                    theSpy.Add(month, data);
                }
                else
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, distance);
                    }
                    else
                    {
                        double currentDistance = data[name];
                        double newDistance = currentDistance + distance;
                        data[name] = newDistance;
                    }
                    theSpy[month] = data;
                }
                n--;
            }

            foreach (var key in theSpy.Keys)
            {
                int count = 0;
                Console.Write("{0}: ", key);
                SortedDictionary<string, double> userData = theSpy[key];
                foreach (var d in userData)
                {
                    if (count > 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write("{0}({1})", d.Key, d.Value);
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
