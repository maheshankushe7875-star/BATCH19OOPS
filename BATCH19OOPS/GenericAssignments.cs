using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class GenericAssignments
    {
   
        public void student1()
        {
            // Assignment = Collection
            // Assignment No 1:  Create an stack add 5 elements and Remove elememts in the stack
            //STACK
            Stack stack = new Stack();       // Add 5 Elements
            stack.Push("JD");
            stack.Push("Bhavani");
            stack.Push("Das");
            stack.Push("Agent Tina");
            stack.Push("Parthiban");
            Console.WriteLine("Original Stack: ");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }     

            // Remove Top Element
            stack.Pop();
            Console.WriteLine("/nAfter Remove:");                        //Last in First Out
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }     
            // Assignment 2: 
            //Dictionary
            // Create a Dictionary add 10 elements in console, modify elemnt, remove specific element
            // filter the element using ContainsKey and clear the dictionary

            Dictionary<int,string> roles = new Dictionary<int,string>();

            roles.Add(1, "Vijay");
            roles.Add(2, "Surya");
            roles.Add(3, "Kartikey");
            roles.Add(4, "Arjun");
            roles.Add(5, "Lokesh");
            roles.Add(6, "Allu");
            roles.Add(7, "Rockey");
            roles.Add(8, "Garuda");
            roles.Add(9, "Adhira");
            roles.Add(10,"Pathan");
            Console.WriteLine("--------Display Dictionary Elements-------");
            foreach (KeyValuePair<int, string> item in roles)
            {
                Console.WriteLine($"Number: {item.Key} Name: {item.Value}");
            }
            roles[3] = "Master";
            Console.WriteLine("------After Modification---");
            foreach(KeyValuePair<int, string> item in roles)
            {
                Console.WriteLine($"Numbers: {item.Key} Names: {item.Value} ");
            }
            roles.Remove(5);
            Console.WriteLine("After Removing Element");
            foreach( KeyValuePair<int, string> item in roles)
            {
                Console.WriteLine($"Numbers: {item.Key} Name: {item.Value}");
            }

            //Filter using ContainKey
            //
            Console.WriteLine("Checking Key");
            if (roles.ContainsKey(4))
            {
                Console.WriteLine("Key 4 Exist : " + roles[4]);
            }     
            else
            {
                Console.WriteLine("Key Not Found");

            }     

            // Clear
            roles.Clear();

            Console.WriteLine("Dictionary Cleared");
            Console.WriteLine("Total Elements : " + roles.Count);




        }     

        static void Main(string[] args)
        {

            GenericAssignments obj = new GenericAssignments();
            obj.student1();
        
        }    
    
    }
}
