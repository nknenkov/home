using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MatrixRotation
{
    class Program
    {
        static List<string> lines = new List<string>();
        static char[,] matrix;
        static char[,] output;
        static void Main(string[] args)
        {
            int n = 0;
            int l = 0;
            string[] rotation = Console.ReadLine().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int degrees = int.Parse(rotation[1]);
            string input = Console.ReadLine();

            while (input != "END")
            {
                lines.Add(input);
                if (input.Length > n)
                {
                    n = input.Length;
                }
                input = Console.ReadLine();
            }
            l = lines.Count;
            matrix = new char[l, n];
            Make2D(lines, l, n);
            switch (degrees % 360)
            {
                case 90: output = new char[n, l];  Rotate90(matrix);
                    break;
                case 180: output = new char[l, n];  Rotate180(matrix);
                    break;
                case 270: output = new char[n, l]; Rotate270(matrix);
                    break;
                default: output = new char[l, n]; Rotate0(matrix);
                    break;
            }
            PrintMatrix(output);
        }

        static void Make2D(List<string> lines, int l, int n)
        {
            for (int row = 0; row < l; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = lines[row].PadRight(n, ' ')[col];
                }
            }
        }
        static void Rotate0(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output[row, col] = matrix[row, col];
                }
            }
        }
        static void Rotate90(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    output[row, col] = matrix[matrix.GetLength(0) - 1 - col, row];
                }
            }
        }
        static void Rotate180(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output[row, col] = matrix[matrix.GetLength(0) - 1 - row, matrix.GetLength(1) - 1 - col];
                }
            }
        }
        static void Rotate270(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    output[row, col] = matrix[col, matrix.GetLength(1) - 1 - row];
                }
            }
        }
        static void PrintMatrix(char[,] output)
        {
            for (int row = 0; row < output.GetLength(0); row++)
            {
                for (int col = 0; col < output.GetLength(1); col++)
                {
                    Console.Write(output[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
