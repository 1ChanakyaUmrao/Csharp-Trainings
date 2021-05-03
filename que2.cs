using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
        //Accept Student’s name, Roll no, Age, class, and university name 
        string Name;
        int roll;
        int age;
        string classs;
        string university;

        Console.WriteLine("Enter your name");
        Name = Console.ReadLine();

        Console.WriteLine("Enter your roll no.");
        roll = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your age");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your class");
        classs = Console.ReadLine();
        Console.WriteLine("Enter Your University");
        university = Console.ReadLine();

        Console.WriteLine("\nStudent Details");
        Console.WriteLine("Name     = {0}", Name);
        Console.WriteLine("Age     = {0}", age);
        Console.WriteLine("Roll NO.      = {0}",roll);
        Console.WriteLine("Class = {0}", classs);
        Console.WriteLine("University = {0}", university);
 
        }
    }
}
