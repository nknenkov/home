using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixShuffling
{
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            //string[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int rows = int.Parse(matrixSize[0]);
            //int cols = int.Parse(matrixSize[1]);
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            matrix = new int[rows, cols];

            //FillMatrix(rows, cols);
            FillMatrixSeparateLine(rows, cols);

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "swap")
                {
                    int x1 = int.Parse(input[1]);
                    int x2 = int.Parse(input[2]);
                    int y1 = int.Parse(input[3]);
                    int y2 = int.Parse(input[4]);
                    int matrixRows = matrix.GetLength(0);
                    int matrixCols = matrix.GetLength(1);
                    if (x1 < matrixRows && x2 < matrixCols && y1 < matrixRows && y2 < matrixCols &&
                        x1 >= 0 && x2>= 0 && y1 >= 0 && y2 >= 0)
                    {
                        int temp = matrix[x1, x2];
                        matrix[x1, x2] = matrix[y1, y2];
                        matrix[y1, y2] = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (input[0] == "END")// || input[0] == "end" || input[0] == "End")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            PrintMatrix(matrix);
        }

        static void FillMatrix(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }
        }
        static void FillMatrixSeparateLine(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, -3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
