
using System;
class Que {
    
    enum months{
        
        jan=0,
        feb=1,
        mar=2,
        apr=3,
        may=4,
        jun=5,
        jul=6,
        aug=7,
        sep=8,
        oct=9,
        nov=10,
        dec=11
    }
    static void Main(string[] args)
    
    {
        Console.WriteLine("Enter the first letter of month:");
        char input= Convert.ToChar(Console.ReadLine());
        Console.WriteLine("All months with this letter:");
        
        switch(input)
        
        {
            case('j'): 
            Console.WriteLine(months.jan);
            Console.WriteLine(months.jun);
            Console.WriteLine(months.jul);
            break;
            
            case('f'):
            Console.WriteLine(months.feb);
            break;
            
            case('m'):
            Console.WriteLine(months.mar);
            Console.WriteLine(months.may);
            break;
            
            case('a'):
            Console.WriteLine(months.apr);
            Console.WriteLine(months.aug);
            break;
            
            case('s'):
            Console.WriteLine(months.sep);
            break;
            
            case('o'):
            Console.WriteLine(months.oct);
            break;
            
            case('n'):
            Console.WriteLine(months.nov);
            break;
            
            case('d'):
            Console.WriteLine(months.dec);
            break;
            
        }
    }
  
}