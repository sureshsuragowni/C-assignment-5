
using System;

class Arraylist
{
    public static void Main()
    {
        int[] a = new int[3];
        Console.WriteLine("Enter number of elements you want in the array (max3)");
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        
        Console.WriteLine("\n Enter array elements \n");
        

        for (int i = 0; i < x; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = Int32.Parse(s1);
        }

        Console.WriteLine("Enter Search element\n");
        Console.WriteLine("--------------------------------------------------");
        string s3 = Console.ReadLine();
        int x2 = Int32.Parse(s3);

        // Sort the values of the Array.  
        Array.Sort(a);
        Console.WriteLine("Sorted values are....");
        for (int i = 0; i < x; i++)
        {

            Console.WriteLine($"Element {i + 1} is {a[i]}");
        }

        // BinarySearch the values of the Array.  
        int x3 = Array.BinarySearch(a, (Object)x2);
        Console.WriteLine("                         ");
        Console.WriteLine("Binary Search: " + x3);
        Console.WriteLine($"Element {x3} is {a[x3]}");
        Console.WriteLine("--------------------------------------------------");
 
        Array.Reverse(a);
        Console.WriteLine("Reversed values are........");
        Console.WriteLine("----------------------------------------------");
        for (int i = 0; i < x; i++)
        {

            Console.WriteLine($"Element {i + 1} is {a[i]}");
        }
    }
}