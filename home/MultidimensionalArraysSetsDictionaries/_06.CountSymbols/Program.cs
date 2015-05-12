using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (symbols.ContainsKey(input[i]))
                {
                    symbols[input[i]] += 1;
                }
                else
                {
                    symbols.Add(input[i], 1);
                }
            }
            foreach (var pair in symbols)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
            
        }
    }
}
