using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_03
{
    internal class Ex
    {
        static void Bai_1()
        {
            /* 1. The Celsius scale is centigrade, 100 divisions separate the freezing point
               from the boiling point of water. On the Fahrenheit scale of Anglo-Saxons,
               these two points are 180 degrees apart. The Kelvin scale is an absolute
               scale used in science.*/
            Console.WriteLine("Enter a deg-C:");
            int Cels = int.Parse(Console.ReadLine());
            int Fah = Cels * 18 / 10 + 32;
            int Kev = Cels + 273;
            Console.WriteLine($"{Cels} deg-C = {Fah} deg-F = {Kev} deg-K");

        }
        static void Bai_2()
        {
            /* 2. Create a program in C# for calculate the surface and volume of a sphere, given its
                radius.
                - surface= 4 * pi * radius squared
                - volume= 4 / 3 * pi * radius cubed
                - Input
                • 60
                - Output
                • Surface: 45238,93
                • Volume: 67858 */
            Console.WriteLine("Enter a radius: ");
            float r = float.Parse(Console.ReadLine());
            const float pi = MathF.PI;
            float Sur = 4 * pi * r * r;
            float Vol = 4 / 3 * pi * r * r * r;
            Console.WriteLine($" Surface of a sphere is : {Sur} \n Volume of a sphere is: {Vol}");
        }
        static void Bai_3()
        {
            /* 3. Write a program in C# that calculates the result of adding, subtracting,
                multiplying and dividing two numbers entered by the user.
                - In addition you should also calculate the rest of the division on the last line.
                - Input
                • 12
                • 3
                - Output
                • 12 + 3 = 15
                • 12 - 3 = 9
                • 12 x 3 = 36
                • 12 / 3 = 4
                • 12 mod 3 = 0 */
            Console.WriteLine("Enter first number: a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }

        public static void Main1(string[] args)
        {
            Bai_1();
            Bai_2();
            Bai_3();


            



            




            
        }
        }
}
