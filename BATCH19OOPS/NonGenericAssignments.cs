using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class NonGenericAssignments
    {
        public void series()
        {

            // Assignment - Non Generic Collection in C#
            // Assignment no 1: ArrayList add 10 elements, remove elements,delete elements

            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add('A');
            list.Add(22.11f);
            list.Add(500000.50m);
            list.Add("Mahesh");
            list.Add(true);
            list.Add(false);
            list.Add("Ramesh");
            list.Add("Suresh");
            list.Add("Kalpesh");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            // Remove Element
            list.Remove("Suresh");
            Console.WriteLine("Ater Removing Element");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            // Delete by index
            list.RemoveAt(3);
            Console.WriteLine("After Delete by Index");
            foreach ( var item in list)
            {
                Console.WriteLine(item);
            }     
            
        }     
        public void series2()
        {
            //Assignment 2: 
            // Hashtable
            // Create a Hashtable named myHashtable add five key value
            //pairing and modify hashtable delete some elements in hashtable
            // and remove element from hashtable


            Hashtable my = new Hashtable();
            my.Add(1, "Vikram");
            my.Add(2, "Rolex");
            my.Add(3, "Kaithee");
            my.Add(4, "Leo");
            my.Add(5, "Master");

            Console.WriteLine("Original Hashtable");
            foreach (DictionaryEntry iteam in my)
            {
                Console.WriteLine($"Number: {iteam.Key} Name:{iteam.Value}");
            }
            my[3] = "Dilli";                      //Modify Value
            Console.WriteLine("After Modify: ");
            foreach (DictionaryEntry iteam in my)
            {
                Console.WriteLine($"Number: {iteam.Key} Name: {iteam.Value} ");
            }     

            my.Remove(5);
            Console.WriteLine("After Remove");                     // Remove
            foreach (DictionaryEntry iteam in my)
            {
                Console.WriteLine($"Number: {iteam.Key} Name: {iteam.Value}");
            }     
            my.Clear();                                               // Delete

            Console.WriteLine("After Clear");
            Console.WriteLine("Total Element: " + my.Count);

        }     

    
        static void Main()
        { 
           NonGenericAssignments obj = new NonGenericAssignments();
           obj.series2();  
           
        
        
        }    
    }
}
