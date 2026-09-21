using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.Session_07
{
    internal class Bàitapjslide
    {
        public static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Khởi tạo mảng random
            Console.Write("Nhập vào số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Tao_mang_ngau_nhien(a);


            //Bài 1
            Console.WriteLine($"Trung bình của mảng vừa tạo là: {Tinh_trung_binh_mang(a)}");
            


            //Bài 2
            Console.Write("Nhập vào số nguyên bạn muốn kiểm tra xem có rong bảng hay không: ");
            int x = int.Parse(Console.ReadLine());
            string KetQua2 = Test_specific_value(a, x) ? "có" : "không có";
            Console.WriteLine($"Số bạn vừa nhập vào {KetQua2} trong mảng");
            Console.Write("Mảng được khỏi tạo là: ");
            in_mang(a);


        }
        //Create a random integer values array, then create functions that:
        static void Tao_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 100); 
            }
        }

        static void in_mang(int[] a)
        {
            foreach (int so in a)
                Console.Write($"{so}, ");
        }
        //1. to calculate the average value of array elements.
        static double Tinh_trung_binh_mang(int[] a)
        {
            if (a == null || a.Length == 0)
                return 0;
            int sum = 0;
            foreach (int so in a)
            {
                sum += so;
            }
            return sum / a.Length;
        }

        //2. to test if an array contains a specific value. (Vd: người dùng hỏi có giá trị 13 trong mảng không? --> trả về giá trị là true/false

        static bool Test_specific_value(int[] a, int x)
        {
            foreach (int so in a)
                if (so == x)
                    return true;
            return false;
                
        }

        //3. to find the index of an array element.
        static int Search_index (int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
                return - 1;
            
        }
        //4. to remove a specific element from an array.
        //5. to find the maximum and minimum value of an array.
        //6. to reverse an array of integer values.
        //7. to find duplicate values in an array of values.
        //8. to remove duplicate elements from an array
    }

}
