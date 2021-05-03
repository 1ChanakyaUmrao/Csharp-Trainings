using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {        
        int basenumber, exponent, i, power;
 
        Console.Write("Enter Base No.: ");
        basenumber = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter Exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());
 
        power = 1;        
        for (i = 1; i <= exponent; i++)
            power = power * basenumber;            
 
        Console.Write("Power : "+ power);
 
        Console.ReadLine();

        }
    }
}
