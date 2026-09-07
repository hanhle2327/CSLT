using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Channels;

namespace CSLT.Session_05
{
    internal class Baitaptrenslide
    {
        static void Bai_1()
        {
            //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            //Viết phương trình xác định tam giác là tam giác đều, tam giác cân, hay tam giác thường
            Console.WriteLine("Nhập góc thứ nhất của tam giác:");
            float goc_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập góc thứ hai của tam giác:");
            float goc_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập góc thứ ba của tam giác:");
            float goc_3 = float.Parse(Console.ReadLine());
            if (goc_1 == goc_2 && goc_2 == goc_3)
            {
                Console.WriteLine("Tam giác là tam giác đều");
            }
            else if (goc_1 == goc_2 || goc_1 == goc_3 || goc_2 == goc_3)
            {
                Console.WriteLine("Tam giac là tam giác cân");
            }
            else
            {
                Console.WriteLine("Tam giác là tam giác thường");
            }
                
        }

        static void Bai_2()
        {
            //Write a program to read 10 numbers and find their average and sum
            //Viết chương trình đọc 10 số, sau đó tính tổng và giá trị trung bình của chúng.
            Console.WriteLine("Nhập vào 10 số:");
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Số thứ {i}: ");
                double num = double.Parse(Console.ReadLine());
                sum = sum + num;
            }
            double average = sum / 10;
            Console.WriteLine($"Tổng của 10 số vừa nhập là: {sum}");
            Console.WriteLine($"Trung bình của 10 số vừa nhập là: {average}");
        }

        static void Bai_3()
        {
            //Write a program to display the multiplication table of a given integer
            //Viết chương trình hiển thị bảng cửu chương của một số nguyên cho trước.
            Console.WriteLine("Nhập số nguyên:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương {num} là:");
            for (int i = num; i == num; i++)
            {
                for (int j= 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
             }  
        }

        static void Bai_45()
        {
            // Write a program to display a pattern like triangles with a number.
            int so_hang = 4;
            //a) In ra màn hình:
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            for (int i = 1; i <= so_hang; i++)
            {
                for (int j= 1;j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine( );
            }
            Console.WriteLine();
            //b) In ra màn hình:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            int count_b = 1;
            for (int i = 1; i <= so_hang; i++)
            {
                for (int j= 1;j <= i; j++)
                {
                    Console.Write($"{count_b} ");
                    count_b++;
                }
                Console.WriteLine( );
            }    
            Console.WriteLine();
            //c) In ra màn hình:
            //   1
            //  2 3
            // 4 5 6
            //7 8 9 10
            int count_c = 1;
            for (int i = 1; i <= so_hang; i++)
            {
                for (int space = 1; space <= so_hang - i; space++ )
                {
                    Console.Write(' ');
                }    
                for (int j= 1;j <= i; j++)
                {
                    Console.Write($"{count_c} ");
                    count_c++;
                }
                Console.WriteLine( );
            }    
        
        }
        static void Bai_6()
        {
            //Write a program to display the n terms of harmonic series and their sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            //  Hãy viết chương trình hiển thị n số hạng của chuỗi điều hòa và tổng của chúng: 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5 + ... +1 / n.
            Console.WriteLine("Nhập vào số các số hạng muốn hiển thị của chuỗi điều hòa:");
            int count = int.Parse( Console.ReadLine() );
            double sum = 0;
            for (int i = 1; i < count; i++)
            { 
                for (int j = 1; j <count; j++)
                {
                    Console.Write($"1 / {j}");
                    sum += 1/j;
                }
                
                Console.WriteLine();
            }
            Console.WriteLine($"Tổng của chuổi điều hòa là {sum}");
        }
        
        static void Bai_7()
        {
            //Write a program to find the ‘perfect’ numbers within a given number range
            Console.WriteLine("Nhập số cần kiểm tra:");
            int so = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i<= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                    tong += i;
            }    
            if (tong == so)
            {
                Console.WriteLine("Số nhập vào là số hoàn hảo");
            }
            else
            {
                Console.WriteLine("Số nhập vào không là số hoàn hảo");
            }
        }
        public static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai_1();
            //Bai_2();
            //Bai_3();
            //Bai_45();
            Bai_6();
            //Bai_7();
        }
    }
}
