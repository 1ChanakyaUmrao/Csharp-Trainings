﻿using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
	        int[] arr2 = new int[10];
	        int[] arr3 = new int[10];
            int j=0, k=0;


       Console.Write("Input the number of elements to be stored in the array :");
	   int n = Convert.ToInt32(Console.ReadLine()); 	   
   
       Console.Write("Input {0} elements in the array :\n",n);
       for(int i=0;i<n;i++)
        {
	      Console.Write("Enter next element: ");
    	  arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }

        for(int i=0;i<n;i++)
        {
	        if (arr1[i]%2 == 0)
	        {
	            arr2[j] = arr1[i];
	            j++;
	        }
	        else
	        {
	            arr3[k] = arr1[i];
	            k++;
	        }
        }

        Console.Write("\nThe Even elements are : \n");
        for(int i=0;i<j;i++)
        {
	        Console.Write("{0} ",arr2[i]);
        }

        Console.Write("\nThe Odd elements are :\n");
        for(int i=0;i<k;i++)
        {
	        Console.Write("{0} ", arr3[i]);
        }
        Console.Write("\n\n");	
        }
    }
}
