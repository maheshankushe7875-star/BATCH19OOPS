using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace BATCH19_OOPS
{
    internal class NonGenericCollection
    {
    
    
        static void Main()
        {

            // Array List 

            ArrayList list = new ArrayList();   // Object Creation
            list.Add(1);
            list.Add("Ajay");
            list.Add(true);
            foreach(var  item in list)
            {

                Console.WriteLine(item);
            }     
            ArrayList list1 = new ArrayList();  // object creation
            list1.Add(10);
            list1.Add("Mahesh");
            list1.Add(false);
            foreach(var item1  in list1)
            {
                Console.WriteLine(item1);
            }     
            ArrayList list2 = new ArrayList();
            list2 .Add(21);
            list2.Add("Ramesh");
            list2.Add(false);
            foreach (var item2 in list2)
            {
                Console.WriteLine(item2);
            }     
            ArrayList list3 = new ArrayList();
            list3.Add(23);
            list3.Add("Suresh");
            list3.Add(false);
            foreach (var iteam3 in list3)
            {
                Console.WriteLine(iteam3);

            }     
            ArrayList list4 = new ArrayList();
            list4.Add(55);
            list4.Add("Naresh");
            list4.Add(false);
            foreach (var iteam4 in list4)
            {
                Console.WriteLine(iteam4);
            }     
            ArrayList list5 = new ArrayList();
            list5.Add(78);
            list5.Add("Mahesh");
            list5.Add(true);
            foreach (var iteam5 in list5)
            {
                Console.WriteLine(iteam5);
            }     
            ArrayList list6 = new ArrayList();
            list6.Add(79);
            list6.Add("Maheshwari");
            list6.Add(true);
            foreach (var iteam6 in list6)
            {
                Console.WriteLine(iteam6);
            }     
            ArrayList list7 = new ArrayList();
            list7.Add(32);
            list7.Add("Mahesh");
            list7.Add(true);
            foreach (var item7 in list7) 
            {

                Console.WriteLine(item7);

            }
            ArrayList list8 = new ArrayList();
            list8.Add(99);
            list8.Add("Vaibhav");
            list8.Add(true);
            foreach (var iteam8 in list8) 
            {
                Console.WriteLine(iteam8);
            }
            ArrayList list9 = new ArrayList();
            list9.Add(63);
            list9.Add("Mahesh");
            list9.Add(true);
            foreach (var iteam9 in list9)
            {
                Console.WriteLine(iteam9);
            }     
            ArrayList list10 = new ArrayList();
            list10.Add(44);
            list10.Add(true);
            list10.Add("Sumit");
            foreach(var iteam10 in list10)
            {
                Console.WriteLine(iteam10);
            }     
            // HashTable 

            Hashtable epm = new Hashtable();
            epm.Add(1, "john");
            epm.Add(2, "David");
            epm.Add(3, "Smith");
            foreach (DictionaryEntry item in epm)
            {
                Console.WriteLine($"id: {item.Key}, Name:{item.Value}");
            }     
            Hashtable emp = new Hashtable();
            emp.Add(4, "Sumit");
            emp.Add(5, "Vaibhav");
            emp.Add(6, "Mahesh");
            foreach (DictionaryEntry iteam in emp)
            {
                Console.WriteLine($"id: {iteam.Key}, Name : {iteam.Value}");
            }     

            Hashtable emp1 = new Hashtable();
            emp1.Add(7, "Omkar");
            emp1.Add(8, "Shivraj");
            emp1.Add(9, "Dhanaji");
            foreach (DictionaryEntry iteam in emp1)
            {
                Console.WriteLine($"id: {iteam.Key}, Name: {iteam.Value}");
            }     
            Hashtable emp2 = new Hashtable();
            emp2.Add(11, "Ramesh");
            emp2.Add(12, "Suresh");
            emp2.Add(13, " Yogesh");
            foreach(DictionaryEntry iteam in emp2)
            {
                Console.WriteLine($"id: {iteam.Key}, Name: {iteam.Value}");
            }     
            Hashtable emp3 = new Hashtable();
            emp3.Add(14, "jaychand");
            emp3.Add(15, "Valchand");
            emp3.Add(17, "Fulchand");
            foreach(DictionaryEntry iteam in emp3)
            {
                Console.WriteLine($"Id: {iteam.Key}, Name: {iteam.Value}");
                
            }     
            Hashtable emp4 = new Hashtable();
            emp4.Add(19, "Romio");
            emp4.Add(20, "Juliet");
            emp4.Add(21, "Seccior");
            foreach(DictionaryEntry iteam in emp4)
            {
                Console.WriteLine($"id: {iteam.Key}, Name: {iteam.Value}");
            }     
            Hashtable emp5 = new Hashtable();
            emp5.Add(21, "Laila");
            emp5.Add(22, "Majnu");
            emp5.Add(23, "Mallika");
            foreach (DictionaryEntry iteam in emp5)
            {
                Console.WriteLine($"id: {iteam.Key}, Name: {iteam.Value}");
            }     
            Hashtable emp6 = new Hashtable();
            emp6.Add(41, "Riya");
            emp6.Add(42, "Sima");
            emp6.Add(43, "Sneha");
            emp6.Add(44, "Riva");
            foreach(DictionaryEntry iteam in emp6)
            {
                Console.WriteLine($"id: {iteam.Key}, Name: {iteam.Value}");
            }     
            Hashtable emp7 = new Hashtable();
            emp7.Add(51, "sumedh");
            emp7.Add(52, "Allu");
            emp7.Add(53, "Arjun");
            emp7.Add(54, "Pushpa");
            foreach (DictionaryEntry iteam in emp7)
            {
                Console.WriteLine($"id: {iteam.Key}, name: {iteam.Value}");


            }      
            //// Stack = LIFO
            ///
            Stack stack = new Stack();
            stack.Push("John");
            stack.Push("David");
            stack.Push("Smith");

            Console.WriteLine(stack.Pop());

            // Queue FIFO
            Queue a = new Queue();
            a.Enqueue(1);
            a.Enqueue(2);
            a.Enqueue(3);

            Console.WriteLine(a.Dequeue());


        }     
    
    
    }
}
