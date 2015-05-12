using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SequenceInMatrix
{
    class Program
    {
        static string[,] matrix;
        static string currentString = String.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size n m");
            string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);
            matrix = new string[rows, cols];
            string bestString = String.Empty;
            int bestCount = 0;

            Console.WriteLine("Enter matrix content by row - columns separated by space");
            FillMatrix(rows, cols);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentString = matrix[row, col];
                    int rowCount = CountRow(row, col);
                    int colCount = CountCol(row, col);
                    int diagonalCount = CountDiagonal(row, col);
                    int currentCount = Math.Max(Math.Max(rowCount, colCount), diagonalCount);
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestString = currentString;
                    }
                }
            }

            int counter = 0;
            for (int i = 0; i < bestCount; i++)
            {
                if (counter > 0)
                {
                    Console.Write(", ");
                }
                Console.Write("{0}", bestString);
                counter++;
            }
            Console.WriteLine();
        }

        static void FillMatrix(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
        static int CountRow(int row, int col)
        {
            int count = 1;
            for (int i = col + 1; i < matrix.GetLength(1); i++)
            {
                if (matrix[row, i] == currentString)
                {
                    count++;
                }
            }
            return count;
        }
        static int CountCol(int row, int col)
        {
            int count = 1;
            for (int i = row + 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, col] == currentString)
                {
                    count++;
                }
            }
            return count;
        }
        static int CountDiagonal(int row, int col)
        {
            int count = 1;
            int diagonal = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            int i = 1;
            if ((row + diagonal <= matrix.GetLength(0)) && (col + diagonal <= matrix.GetLength(1)))
            {
                while (i < diagonal)
                {
                    if (matrix[row + i, col + i] == currentString)
                    {
                        count++;
                    }
                    i++;
                }
            }
            return count;
        }
    }
}
