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
            //1.
            int sum = x + y;
            Console.WriteLine($"{x}+ {y} = {sum}");

            //2. 
            Console.WriteLine($"Before swap x = {x}, y = {y}");
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"After swap x = {x}, y = {y}");


            //3. 
            float f1 = 3.5f;
            float f2 = 10.7f;
            float f3 = f1 * f2;
            Console.WriteLine($"")

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
        


    }
}
