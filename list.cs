using System;
using System.Collections.Generic;
  
class lis {
    public static void Main(String[] args)
    {
        List<int> firstlist = new List<int>();
        List<string> secondlist = new List<string>();
        Console.WriteLine("Enter the type of list you want to make");
        Console.WriteLine("Type 1 for integer list or type 2 for string list");
        int ans = Convert.ToInt32(Console.ReadLine());

        switch(ans)
        {
            case 1:
            Console.WriteLine("Enter the no. of elements you want to insert in the list:");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in the list:");
            for(int i = 0;i< numbers;i++)
            {
                int j = Convert.ToInt32(Console.ReadLine());
                firstlist.Add(j);
            }
            Console.WriteLine("Count Is: " + firstlist.Count);
            break;
            
            case 2:
            Console.WriteLine("Enter the no. of elements you want to insert in the list:");
            int elements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in the list:");
            for(int i = 0;i< elements; i++)
            {
                string j = Console.ReadLine();
                secondlist.Add(j);
            }
            Console.WriteLine("Count Is: " + secondlist.Count);
            break;
            
            default:
            Console.WriteLine("Wrong Input");
            break;
        }
        
    }
}