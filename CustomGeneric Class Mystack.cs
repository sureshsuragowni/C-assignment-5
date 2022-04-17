using System;
using System.Collections.Generic;

namespace CustomGenericStackWeek
{
    public class MystackWeekdays
    {
        public static void Main(string[] args)
        {
            Stack<string> mystack = new Stack<string>();
            //Adding Item in stack
            mystack.Push("Sunday");
            mystack.Push("Monday");
            mystack.Push("Tuesday");
            mystack.Push("Wednesday");
            mystack.Push("Thursday");
            mystack.Push("Friday");
            mystack.Push("Saturday");
            print(mystack);

            //Accessing Top Item without removing it

            Console.WriteLine("\nTop Item is : {0}", mystack.Peek());

            //Removing Item from Stack

            Console.WriteLine("\nRemoved Top Item of Stack : " + mystack.Pop());
            Console.WriteLine("\nNow Stack's Items are : ");
            print(mystack);
        }
        public static void print(Stack<string> sp)
        {
            foreach (string s in sp)
            {
                Console.Write(s.ToString() + " | ");
            }
        }
    }
}