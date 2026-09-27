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
        public static void Main(string[] args)
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

            //3.to find the index of an array element.
            Console.Write("Nhập số cần tìm vị trí: ");
            int sonhap2 = int.Parse(Console.ReadLine());
            int ketqua3 = tim_vi_tri(a, sonhap2);
            Console.WriteLine($"Vị trí số cần tìm trong mảng là: {ketqua3}");

            //4.to remove a specific element from an array.
            Console.Write("Nhập số cần xóa: ");
            int sonhap3 = int.Parse(Console.ReadLine());
            int[] ketqua4 = XoaPhanTu(a, sonhap3);
            Console.WriteLine("Mảng sau khi xóa phần tử: ");
            in_mang(ketqua4);

            //5.to find the maximum and minimum value of an array.
            Console.WriteLine("Giá trị lớn nhất của mảng: " + TimMax(a));
            Console.WriteLine("Giá trị nhỏ nhất của mảng: " + TimMin(a));

            //6.to reverse an array of integer values.
            int[] ketqua6 = DaoNguocMang(a);
            Console.WriteLine("Mảng sau khi đảo ngược: ");
            in_mang(ketqua6);

            //7.to find duplicate values in an array of values.
            List<int> ketqua7 = TimTrungLap(a);
            if (ketqua7.Count > 0)
            {
                Console.WriteLine("Các phần tử trùng lặp trong mảng là: " + string.Join(", ", ketqua7));
            }
            else
            {
                Console.WriteLine("Không có phần tử trùng lặp trong mảng.");
            }

            //8.to remove duplicate elements from an array.
            int[] ketqua8 = XoaTrungLap(a);
            Console.WriteLine("Mảng sau khi xóa các phần tử trùng lặp: ");
            in_mang(ketqua8);

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
        //3.to find the index of an array element.
        static int tim_vi_tri(int[] a, int b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                    return i + 1;
            }
            return -1;
        }

        //4.to remove a specific element from an array.
        static int[] XoaPhanTu(int[] arr, int target)
        {
            // Bước 1: Đếm xem có bao nhiêu số KHÔNG PHẢI là target
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != target) dem++;
            }

            // Bước 2: Tạo mảng mới với kích thước vừa đếm được
            int[] mangMoi = new int[dem];

            // Bước 3: Chép các số không phải target sang mảng mới
            int viTriMoi = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != target)
                {
                    mangMoi[viTriMoi] = arr[i];
                    viTriMoi++;
                }
            }
            return mangMoi;
        }

        //5.to find the maximum and minimum value of an array.
        static int TimMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }

        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        //6.to reverse an array of integer values.
        static int[] DaoNguocMang(int[] arr)
        {
            int[] mangMoi = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // Phần tử đầu của mảng cũ sẽ vào phần tử cuối của mảng mới
                mangMoi[i] = arr[arr.Length - 1 - i];
            }
            return mangMoi;
        }

        //7.to find duplicate values in an array of values.
        static List<int> TimTrungLap(int[] arr)
        {
            List<int> trungLap = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !trungLap.Contains(arr[i]))
                    {
                        trungLap.Add(arr[i]);
                    }
                }
            }
            return trungLap;
        }

        //8.to remove duplicate elements from an array.
        static int[] XoaTrungLap(int[] arr)
        {
            List<int> khongTrungLap = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!khongTrungLap.Contains(arr[i]))
                {
                    khongTrungLap.Add(arr[i]);
                }
            }
            return khongTrungLap.ToArray();
        }

    }
}
