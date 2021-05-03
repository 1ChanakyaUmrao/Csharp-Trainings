using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            double tax;
            Console.Write("Enter the value of money:");
            money = Convert.ToInt32(Console.ReadLine());
            if(money<10000)
            {
                tax = (5*money)/100;
            }
            else if(money>10000 && money<100000)
            {
                tax = (8*money)/100;
            }
            else
            {
                tax = (8.5*money)/100;
            }
            Console.WriteLine("Total Tax is: {0}", tax);
        }
    }
}
