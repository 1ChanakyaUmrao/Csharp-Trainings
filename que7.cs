using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        { 
            int basenumber, exponent,power, i;
            string ans;
            Console.Write("Enter any basenumber: ");
            basenumber = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter any exponent: ");
            exponent = Convert.ToInt32(Console.ReadLine());
 
            power = 1;
            i = 1;
            while (i <= exponent)
            {
                power = power * basenumber;
                i++;
            }
            
            Console.WriteLine("Power : "+ power);   
            Console.WriteLine("Do you want to continue?");
            ans = Console.ReadLine();
            while(true)
            {
            if(ans == "y" || ans == "Y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Quit");
            } 
            }
            
        }
    }
}
