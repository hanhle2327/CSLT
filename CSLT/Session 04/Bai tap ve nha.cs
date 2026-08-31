using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_04
{
    internal class Bai_tap_ve_nha
    {
        static void Bai_1()
        {
            // Giải phương trình bậc 2

            Console.WriteLine("Nhập hệ số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c: ");
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    Console.WriteLine($"Phuong trinh bac nhat co nghiem x = {-c / b}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep x = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem phan biet:\nx1 = {x1}\nx2 = {x2}");
                }
            }
        }
        static void Bai_2()
        {
            Console.Write("Input an integer: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is an even integer.");
            else
                Console.WriteLine($"{num} is an odd integer.");
        }

        static void Bai_3()
        {
            Console.Write("Input 1st number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Input 3rd number: ");
            int n3 = int.Parse(Console.ReadLine());

            int max = n1;
            if (n2 > max) max = n2;
            if (n3 > max) max = n3;

            Console.WriteLine($"The 1st Number is: {n1}\nThe 2nd Number is: {n2}\nThe 3rd Number is: {n3}");
            Console.WriteLine($"The greatest of three is: {max}");
        }

        static void Bai_4()
        {
            Console.Write("Input side 1 of triangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Input side 2 of triangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Input side 3 of triangle: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an Equilateral triangle."); // Tam giác đều
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("This is an Isosceles triangle."); // Tam giác cân
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle."); // Tam giác thường
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            


            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}   
   