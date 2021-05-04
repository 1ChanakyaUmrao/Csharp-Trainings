using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the number of rows:");
            int totalRows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= totalRows; i++)
            {
                for (int j = 1; j <= (totalRows - i); j++)
                    Console.Write(" ");
                for (int n = 1;n <= i; n++)
                    Console.Write(n);
                for (int n = (i - 1); n >= 1; n--)
                    Console.Write(n);
                Console.WriteLine();
            }
            for (int i = (totalRows - 1); i >= 1; i--)
            {

                for (int j = 1; j <= (totalRows - i); j++)
                    Console.Write(" ");
                for (int n = 1; n <= i; n++)
                    Console.Write(n);
                for (int n = (i - 1); n >= 1; n--)
                    Console.Write(n);
                Console.WriteLine();
            
        }
    }
    }
}
