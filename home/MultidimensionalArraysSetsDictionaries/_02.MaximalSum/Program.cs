using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wrong example 3 4 -> should be 4 5
            int n = 3;
            string[] input = Console.ReadLine().Split(' ');
            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);
            string[] arr = new string[col];
            int[,] matrix = new int[row, col];
            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < row; i++)
            {
                arr = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(arr[j]);
                }
            }

            for (int i = 0; i <= row - n; i++)
            {
                for (int j = 0; j <= col - n; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum = {0}", maxSum);
            for (int i = bestRow; i < bestRow + n; i++)
            {
                for (int j = bestCol; j < bestCol + n; j++)
                {
                    Console.Write("{0, -3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
