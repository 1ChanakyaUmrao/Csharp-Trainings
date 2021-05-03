using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            double height;
            double area;
            Console.Write("Enter the base of triangle:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of triangle:");
            height = Convert.ToDouble(Console.ReadLine());
 
            area = (b * height) / 2;
            Console.WriteLine("The area of your triangle is: {0}", area);
        }
    }
}
