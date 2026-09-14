using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.Session_06
{
    internal class baitapslide
    {
        /*1a. Write a C# function to find the maximum of three numbers.*/
        public static double FindMax(double a, double b, double c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        //1b. Improve the next version that accept at least 1 parameter.
        public static double FindMax(double first, params double[] rest)
        {
            double max = first;
            foreach (double num in rest)
            {
                if (num > max)
                {  max = num; }    
            }
            return max;
        }
        //2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        public static long Cal_factorial (int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Số nhập vào phải là số nguyên không âm (n>0)", nameof(n));
            }
            long result = 1;
            for (int i = 2; i <=n; i++)
            {
                result *=  i;
            }  
            return result ;
        }
        



        public static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("a. Tìm max của 3 số");
            double num1 = 15, num2 = 40, num3 = 10;
            double maxThree = FindMax(num1, num2, num3);
            Console.WriteLine($"Số lớn nhất trong 3 số {num1}, {num2}, {num3} là: {maxThree} ");

            Console.WriteLine("b. nhận ít nhất 1 tham số");
            //Gọi với 1 tham số
            double max1 = FindMax(99.5);
            Console.WriteLine($"Max của 1 số (99.5) là: {max1}");
            
            //Gọi với 3 tham số
            double max3 = FindMax(99.5,88, 20);
            Console.WriteLine($"Max của 3 số (99.5, 88, 20) là: {max3}");
            //Gọi với nhiều tham số
            double max_n = FindMax(99.5, 70, 25, 3, 4.6, 100, 5789);
            Console.WriteLine($"Max của nhiều số (99.5, 70, 25, 3, 4.6, 100, 5789) là: {max_n}");

            // Bài 2
            Console.WriteLine("Nhập vào số bạn muốn tính giai thừa:");
            long num = long.Parse( Console.ReadLine() );
            Console.WriteLine($"{num} giai thừa có giá trị là: ");
         
            Console.WriteLine();
           
        }

    }
}
