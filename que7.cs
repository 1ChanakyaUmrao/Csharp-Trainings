using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
                Console.WriteLine("Enter the number:");
                int number = Convert.ToInt32(Console.ReadLine());
            

            int power = 1;
            int n = number;
            while(n>0)
            {
                power*=number;
                n--;
            }
            Console.WriteLine("The power of {0} raised to power {1} is: {2}",number,number,power);

            Console.WriteLine("If you wish to continue press y or Y otherwise press any key to exit.");
            string choice = Console.ReadLine();

            if(choice=="y" || choice=="Y")
            {
                goto label;
            }
        }
    
    }
}
