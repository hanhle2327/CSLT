using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_02
{
    internal class Ex1
    {
            public static void Main(string[] args)
            {
            
            int x = 10, y = 20;
            //1. to Add / Sum Two Numbers.
            int sum = x + y;
            Console.WriteLine($"{x}+ {y} = {sum}");

            //2. to Swap Values of Two Variables.
            Console.WriteLine($"Before swap x = {x}, y = {y}");
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"After swap x = {x}, y = {y}");


            //3. to Multiply two Floating Point Numbers
            float f1 = 3.5f;
            float f2 = 10.7f;
            float f3 = f1 * f2;
            Console.WriteLine($"{f1} * {f2} = {f3}");


            //4.to convert feet to meter
            float feet = 5.7f;
            const float rate = 0.3048f;
            float metter = rate * feet;
            Console.WriteLine($"{feet} feet = {metter} metter.");


            //5.to convert Celsius to Fahrenheit and vice versa
            float Cels = 27f;
            float Fah = 1.8f * Cels + 32;
            Console.WriteLine($"{Cels} deg-C = {Fah} deg-F");


            //6.to find the Size of data types
            Console.WriteLine($"Size of double data type is {sizeof(double)}");
            Console.WriteLine($"Size of int data type is {sizeof(int)}");


            //7.to Print ASCII Value(tip: read character, print number of this char)
            Console.WriteLine("Enter a character:");
            int c = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {c}");


            //8.to Calculate Area of Circle
            float r = 4.5f;
            const float pi = 3.14f;
            float area = r*r * pi;
            Console.WriteLine($"Area of Circle is: { r} * {r} * { pi} = {area}");


            //9.to Calculate Area of Square
            float a = 5.5f;
            float areaSquare = a * a;
            Console.WriteLine($"Area of Square is: {a} * {a} = {areaSquare}");

            //10.to convert days to years, weeks and days
            int totalDays = 500;
            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;
            Console.WriteLine($"{totalDays} days = {years} year, {weeks} week, {days} days.");

    Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        


    }
}
