using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
        string Name;
        string city;
        int age;
        int Pincode;

        Console.WriteLine("Enter your name");
        Name = Console.ReadLine();

        Console.WriteLine("Enter your city");
        city = Console.ReadLine();

        Console.WriteLine("Enter your age");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your pin code");
        Pincode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nYour Complete Address");
        Console.WriteLine("Name     = {0}", Name);
        Console.WriteLine("City     = {0}", city);
        Console.WriteLine("Age      = {0}",age);
        Console.WriteLine("Pin Code = {0}", Pincode);
 
        }
    }
}
