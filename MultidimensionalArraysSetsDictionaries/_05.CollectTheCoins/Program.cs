using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CollectTheCoins
{
    class Program
    {
        static int n = 4;
        static int x = 0;
        static int y = 0;
        static string[] board = new string[n];

        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                board[i] = Console.ReadLine();
            }

            int coins = 0;
            int walls = 0;
            string movement = Console.ReadLine();
            int temp = 0;

            for (int i = 0; i < movement.Length; i++)
            {
                switch (movement[i])
                {
                    case '>':
                        temp = y + 1;
                        if (temp < board[x].Length)
                        {
                            y = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                                PickTheCoin(x, y);
                            }
                        }
                        else
                        {
                            walls++;
                        }
                        break;
                    case '<':
                        temp = y - 1;
                        if (y >= 0)
                        {
                            y = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                                PickTheCoin(x, y);
                            }
                        }
                        else
                        {
                            walls++;
                        }
                        break;
                    case 'V':
                        temp = x + 1;
                        if (temp < n && y < board[temp].Length)
                        {
                            x = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                                PickTheCoin(x, y);
                            }
                        }
                        else
                        {
                            walls++;
                        }
                        break;
                    case '^':
                        temp = x - 1;
                        if (temp >= 0 && y < board[temp].Length)
                        {
                            x = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                                PickTheCoin(x, y);
                            }
                        }
                        else
                        {
                            walls++;
                        }
                        break;
                }
            }
            Console.WriteLine("Coins Collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", walls);
        }
        static void PickTheCoin(int x, int y)
        {
            StringBuilder sb = new StringBuilder(board[x]);
            sb[y] = '0';
            board[x] = sb.ToString();
        }
    }
}
