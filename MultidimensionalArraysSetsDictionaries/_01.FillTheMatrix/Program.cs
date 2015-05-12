using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MatrixA(n);
            Console.WriteLine();
            MatrixB(n);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    Console.Write("{0, 3}", matrix[col,row]);
                }
                Console.WriteLine();
            }
        }
        static void MatrixA(int n)
        {
            int[,] matrix = new int[n, n];
            int count = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            PrintMatrix(matrix);
        }
        static void MatrixB(int n)
        {
            int[,] matrix = new int[n, n];
            int count = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = count;
                        count++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = count;
                        count++;
                    }
                }
            }
            PrintMatrix(matrix);
        }
    }
}
