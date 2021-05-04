using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)


        {
            string option;
           
            Console.WriteLine("Choose book from the given options: ");
            Console.WriteLine("c: computer books");
            Console.WriteLine("m: mathematical books");
            Console.WriteLine("h: history books");
            Console.WriteLine("e: English books");

            label:
                Console.WriteLine("Enter your option:");
                option = Console.ReadLine();

            switch(option)
            {
                case "c":
                    Console.WriteLine("COMPUTER BOOKS");
                    break;
                
                case "m":
                    Console.WriteLine("MATHEMATICAL BOOKS");
                    break;
                
                case "h":
                    Console.WriteLine("HISTORY BOOKS");
                    break;

                case "e":
                    Console.WriteLine("ENGLISH BOOKS");
                    break;

                default:
                    Console.WriteLine("Try Again");
                    goto label;
        }
    }
    }
}
