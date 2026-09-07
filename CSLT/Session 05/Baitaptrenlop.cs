using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_05
{
    internal class Baitaptrenlop
    {
        static void Bai_1()
        {
            //Viet chuowng trinh in ra bang cuu chuong 2 -> 15

            for (int i = 2; i <= 15; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        static void Bai_2()
        {
            //Viet chuong trinh in ra chu "Dai hoc kinh te thanh pho ho chi minh" ma moi chu tren 1 dong
            string s = "Đại học Kinh tế TPHCM";
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }    
        }


        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
        }
    }
}
