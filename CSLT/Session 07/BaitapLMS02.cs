using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_07
{
    internal class BaitapLMS02
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // 1. Tạo ma trận nguyên N x M ngẫu nhiên (N, M được nhập từ người dùng)
            Console.Write("Nhập số hàng N: ");
            int n = int.Parse(Console.ReadLine() ?? "3");
            Console.Write("Nhập số cột M: ");
            int m = int.Parse(Console.ReadLine() ?? "3");

            int[,] matrix = CreateRandomMatrix(n, m);

            // 2. In ma trận
            Console.WriteLine("\nMa trận vừa tạo: ");
            PrintMatrix(matrix);

            // 3. In hàng/cột thứ i (i được nhập từ người dùng)
            Console.Write("\nNhập chỉ mục i để in hàng/cột: ");
            int i = int.Parse(Console.ReadLine() ?? "0");
            PrintRowOrColumn(matrix, i);

            // 4. Tìm giá trị lớn nhất của ma trận
            int maxVal = FindMatrixMax(matrix);
            Console.WriteLine($"\nGiá trị lớn nhất của ma trận: {maxVal}");

            // 5. Tìm giá trị nhỏ nhất của hàng/cột thứ i của ma trận
            FindAndPrintMinRowOrCol(matrix, i);

            // 6. Chuyển vị ma trận
            int[,] transposedMatrix = TransposeMatrix(matrix);
            Console.WriteLine("\nMa trận sau khi chuyển vị");
            PrintMatrix(transposedMatrix);

            // 7. In các giá trị đường chéo chính/phụ của ma trận (chỉ áp dụng cho ma trận vuông)
            Console.WriteLine("\nGiá trị đường chéo (dành cho ma trận vuông)");
            PrintDiagonals(matrix);
        }




        static int[,] CreateRandomMatrix(int n, int m)
        {
            Random rand = new Random();
            int[,] mat = new int[n, m];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    mat[r, c] = rand.Next(1, 100);
                }
            }
            return mat;
        }

        static void PrintMatrix(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{mat[r, c],4} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintRowOrColumn(int[,] mat, int i)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            // In hàng thứ i
            if (i >= 0 && i < rows)
            {
                Console.Write($"Hàng {i}: ");
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{mat[i, c]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Chỉ mục hàng {i} vượt quá giới hạn ma trận.");
            }

            // In cột thứ i
            if (i >= 0 && i < cols)
            {
                Console.Write($"Cột {i}: ");
                for (int r = 0; r < rows; r++)
                {
                    Console.Write($"{mat[r, i]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Chỉ mục cột {i} vượt quá giới hạn ma trận.");
            }
        }

        static int FindMatrixMax(int[,] mat)
        {
            int max = mat[0, 0];
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (mat[r, c] > max)
                    {
                        max = mat[r, c];
                    }
                }
            }
            return max;
        }

        static void FindAndPrintMinRowOrCol(int[,] mat, int i)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            // Tìm Min hàng thứ i
            if (i >= 0 && i < rows)
            {
                int minRow = mat[i, 0];
                for (int c = 1; c < cols; c++)
                {
                    if (mat[i, c] < minRow) minRow = mat[i, c];
                }
                Console.WriteLine($"Giá trị nhỏ nhất của hàng {i}: {minRow}");
            }
            else
            {
                Console.WriteLine($"Không thể tìm Min hàng {i} vì vượt quá giới hạn.");
            }

            // Tìm Min cột thứ i
            if (i >= 0 && i < cols)
            {
                int minCol = mat[0, i];
                for (int r = 1; r < rows; r++)
                {
                    if (mat[r, i] < minCol) minCol = mat[r, i];
                }
                Console.WriteLine($"Giá trị nhỏ nhất của cột {i}: {minCol}");
            }
            else
            {
                Console.WriteLine($"Không thể tìm Min cột {i} vì vượt quá giới hạn.");
            }
        }

        static int[,] TransposeMatrix(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    transposed[c, r] = mat[r, c];
                }
            }
            return transposed;
        }

        static void PrintDiagonals(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("Đây không phải là ma trận vuông, không thể in đường chéo chính/phụ.");
                return;
            }

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{mat[i, i]} ");
            }
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{mat[i, rows - 1 - i]} ");
            }
        }
    }
}

