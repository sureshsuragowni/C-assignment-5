using System;
using System.Collections.Generic;


namespace LinkedListForEmployees
{
    internal class EmpLinkedList
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Suresh");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Ramesh");
            my_list.AddLast("Suprith");

            Console.WriteLine("Employee Details...:");

            // Accessing the elements of
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Total number of employees in the linked list is : {0} ", my_list.Count);
        }
    }
}