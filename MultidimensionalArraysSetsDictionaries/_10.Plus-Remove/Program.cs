using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Plus_Remove
{
    class Program
    {
        static List<char[]> list = new List<char[]>();
        static List<int[]> mask = new List<int[]>();

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    char[] arr = input.ToCharArray();
                    list.Add(arr);
                    int[] m = new int[input.Length];
                    mask.Add(m);
                }
            }
            for (int i = 1; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list[i].Length - 2; j++)
                {
                    if (j < (list[i - 1].Length - 1) && j < (list[i + 1].Length - 1))
                    {
                        char ch01 = char.ToLower(list[i - 1][j + 1]);
                        char ch10 = char.ToLower(list[i][j]);
                        char ch11 = char.ToLower(list[i][j + 1]);
                        char ch12 = char.ToLower(list[i][j + 2]);
                        char ch21 = char.ToLower(list[i + 1][j + 1]);
                        if (ch10 == ch01 && ch10 == ch11 && ch10 == ch12 && ch10 == ch21)
                        {
                            mask[i - 1][j + 1] = 1;
                            mask[i][j] = 1;
                            mask[i][j + 1] = 1;
                            mask[i][j + 2] = 1;
                            mask[i + 1][j + 1] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (mask[i][j] == 0)
                    {
                        Console.Write(list[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
