using System;
using System.IO;

class que
{
    static void Main()
    {
		string fileName = @"file.txt"; 
		string[] Arr ;
		int number,i,l,m=1;
         Console.WriteLine("Last N No. of Lines From A File "); 
         if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
       Console.WriteLine("Enter the no. of lines you want to write in the file  :");
       number= Convert.ToInt32(Console.ReadLine()); 
       Arr = new string[number];      
       Console.WriteLine("Input {0} strings below : ",number);
       for(i=0;i<number;i++)
       {
           Console.WriteLine("Input line {0} : ",i+1);
		   Arr[i] = Console.ReadLine();	
        }	
        System.IO.File.WriteAllLines(fileName, Arr);
		
        Console.WriteLine("how many numbers of lines you want to display  :");
        l = Convert.ToInt32(Console.ReadLine()); 
        m=l;
        if(l>=1 && l<=number)
        {
            Console.WriteLine("The last {0} lines of the file {1} is : ",l,fileName);
			if (File.Exists(fileName))
			{
				for(i=number-l;i<number;i++)
				{
				string[] lines = File.ReadAllLines(fileName);
				Console.WriteLine("The last no {0} line is : {1} \n",m,lines[i]);
				m--;
				}
			}
		}
		else
		{
			 Console.WriteLine("Please input the correct line no.");
		}    
    }
}