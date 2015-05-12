using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.TerroristWin
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            int start = input.IndexOf('|');
            int end = 0;
            int destroyed = 0;

            while (start != -1)
            {
                int sum = 0;
                end = input.IndexOf('|', start + 1);

                if (end <= start)
                {
                    break;
                }
                for (int i = start + 1; i <= end - 1; i++)
                {
                    sum += input[i];
                    sb[i] = '.';
                }
                destroyed = sum % 10;
                for (int i = start; i >= start - destroyed && i >= 0; i--)
                {
                    sb[i] = '.';
                }
                for (int i = end; i <= end + destroyed && i < sb.Length; i++)
                {
                    sb[i] = '.';
                }
                start = input.IndexOf('|', end + 1);
            }
            Console.WriteLine(sb);
        }
    }
}
