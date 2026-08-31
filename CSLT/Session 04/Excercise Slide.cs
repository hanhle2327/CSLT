using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_04
{
    internal class Excercise_Slide
    {
        static void Bai_1()
        {
            /*1. Write a C# Sharp program that takes two numbers as input and
            performs an operation (+,-,*,x,/) on them and displays the result of that
            operation.*/

            Console.WriteLine( "Nhập số thứ nhất: ");
            float a = float.Parse( Console.ReadLine() );
            Console.WriteLine( "Nhập số thứ hai: ");
            float b = float.Parse( Console.ReadLine() );
            Console.WriteLine( $"{a} + {b} = {a + b}");
            Console.WriteLine( $"{a} - {b} = {a - b}");
            Console.WriteLine( $"{a} * {b} = {a * b}");
            Console.WriteLine( $"{a} / {b} = {a / b}");
        }

        static void Bai_2()
        {
            /*2. Write a C# Sharp program to display certain values of the function x = y2
            + 2y + 1 (using integer numbers for y, ranging from -5 to +5).*/
            int y;
            do
            {
                Console.WriteLine("Nhập vào số nguyên y: ");
                y = int.Parse(Console.ReadLine());
                if (y > -5 && y < 5)
                    break;
                else
                    Console.WriteLine("Số nguyên y không hợp lệ, vui lòng nhập số nguyên y trong khoảng (-5;5)");
            }while(true);
            
            float x = (y * y) + (2 * y) + 1;
            Console.WriteLine($"Giá trị của hàm x = y^2 + 2y + 1 với y = {y} là {x}");
        }

        static void Bai_3()
        {
            /*3. Write a C# Sharp program that takes distance and time (hours, minutes,
            seconds) as input and displays speed in kilometers per hour (km/h) and
            miles per hour (miles/h)*/

            Console.WriteLine("Nhập khoảng cách di chuyển: ");
            float soKm = float.Parse( Console.ReadLine() );
            Console.WriteLine("Nhập số giờ di chuyển: ");
            int gio = int.Parse( Console.ReadLine() );
            Console.WriteLine("Nhập số phút di chuyển: ");
            int phut = int.Parse( Console.ReadLine() );
            Console.WriteLine("Nhập số giây di chuyển: ");
            int giay = int.Parse( Console.ReadLine() );
            TimeSpan thoiGian = new TimeSpan(gio, phut, giay);
            double tongGio = thoiGian.TotalHours;
            if (tongGio >0)
            {
                double vanTocTheoKm = soKm / tongGio;
                Console.WriteLine($"Vận tốc khi tính theo km/h là: {vanTocTheoKm:F2} km/h");
            }    
            else
            {
                Console.WriteLine("Thời gian di chuyển phải lớn hơn 0");
            }
            float soMiles = soKm / 1.60934f;
            if (tongGio > 0)
            {
                double vanTocTheoMiles = soMiles / tongGio;
                Console.WriteLine($"Vận tốc khi tính theo miles/h là: {vanTocTheoMiles:F2} miles/h");
            }
            else
            {
                Console.WriteLine("Thời gian di chuyển phải lớn hơn 0");
            }
        }

        static void Bai_4()
        {
            /*4. Write a C# Sharp program that takes the radius of a sphere as input and
            calculates and displays the surface and volume of the sphere. V = 4/3*π*r^3 */
            do
            {
                Console.WriteLine("Nhập bán kính hình cầu: ");
                float banKinh = float.Parse(Console.ReadLine());
                if (banKinh>0)
                {
                    double dienTich = 4 * Math.PI * banKinh * banKinh;
                    double theTich = 4 / 3 * Math.PI * banKinh * banKinh * banKinh;
                    Console.WriteLine( $"Diện tích khối cầu là: {dienTich:F2}");
                    Console.WriteLine( $"Thể tích khối cầu là: {theTich:F2}");
                }
                else
                {
                    Console.WriteLine($"Bán kính không hợp lệ, vui lòng nhập bán kính hình cầu lớn hơn 0!");
                }
            } while (true);    
            
        }
        static void Bai_5()
        {
            /*5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.*/

        }

        
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
            Console.WriteLine("Nhập hệ số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c: ");
            int c = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
