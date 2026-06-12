using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BATCH19_OOPS
{
    internal class GenericCollection
    {
    
    
    
    
        static void Main ()
        {
            // Generic Collection //    In generic we have specify data types

            // List

            List<string> list = new List<string>();
            list.Add("Vikas");
            list.Add("Vilas");
            list.Add("Rahul");             // List is most commonly used in generic 
            foreach (string item in list)                               // it stores the specif element and provide type safety
            {
                Console.WriteLine(item);
            }

            List<string> list1 = new List<string>();
            list1.Add("Kaithee");
            list1.Add("Leo");
            list1.Add("Bigil");
            foreach (string item1 in list1)
            {
                Console.WriteLine(item1);
            }     
            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            foreach(int item2 in list2)
            {
                Console.WriteLine(item2);
            }     
            List<double> list3 = new List<double>();
            list3.Add(22222.22);
            list3.Add(12222.43);
            list3.Add(123344.11);
            foreach(double item3 in list3)
            {
                Console.WriteLine(item3);
            }     
            List<float> list4 = new List<float>();
            list4.Add(7.2f);
            list4.Add(22.4f);
            list4.Add(12.4f);
            foreach (float item4 in list4)
            {
                Console.WriteLine(item4);
            }     
            List<char> list5 = new List<char>();
            list5.Add('A');
            list5.Add('B');
            list5.Add('C');
            foreach (char item5 in list5)
            {
                Console.WriteLine(item5);

            }     
            List<string> list6 = new List<string>();
            list6.Add("Nazmeen");
            list6.Add("Nikita");
            list6.Add("Nisha");
            foreach (string ash in list6)
            {
                Console.WriteLine(ash);

            }     





            // Dictionarty



            Dictionary<int,string> emp = new Dictionary<int,string>();
            emp.Add(101, "Vishjeet");
            emp.Add(102, "Vikram");
            emp.Add(103, "Vivek");
            if(!emp.ContainsKey(103))
            {
                emp.Add(103, "Vivek");
            }     
            else
            {
                Console.WriteLine("Key is already exist");
            }     
            Console.WriteLine("Employ Name: " + emp[101]);
            foreach ( KeyValuePair<int,string> kvp in emp)
            {
                Console.WriteLine($"id: {kvp.Key}  Name: {kvp.Value}");
            }     
            
            Dictionary<int,String> emp1 = new Dictionary<int,String>();      // object creation
            emp1.Add(124, "Reliance");
            emp1.Add(125, "Adani");
            emp1.Add(126, "Serum");
            Console.WriteLine(emp1[126]);                                     // For Single object
            foreach (KeyValuePair<int, string> arv in emp1)
            {
                Console.WriteLine($"id: {arv.Key} Name of the company: {arv.Value}");

            }     
            Dictionary<int,string> wop = new Dictionary<int,string>();
            wop.Add(111, "Vaibhav");
            wop.Add(222, "Sumit");
            wop.Add(333, "Omkar");

            Console.WriteLine(wop[222]);
            Console.WriteLine(wop[111]);
            Console.WriteLine(wop[333]);
            foreach (KeyValuePair<int, string> www in wop)
            {
                Console.WriteLine($"id: {www.Key} Name: {www.Value}");

            }     
            Dictionary<int,string> que = new Dictionary<int,string>();
            que.Add(999, "Tcs");
            que.Add(888, "Zest");
            que.Add(777, "Wipro");

            Console.WriteLine(que[777]);
            Console.WriteLine(que[888]);
            Console.WriteLine(que[999]);

            foreach(KeyValuePair<int,string> god in que)
            {

                Console.WriteLine($"id: { god.Key}  Name: {god.Value}");

            }
            Dictionary<int,string> evil = new Dictionary<int,string>();
            evil.Add(787, "Vedant");
            evil.Add(323, "Cloudbuz");
            evil.Add(233, "Learnomate");
            Console.WriteLine(evil[323]);
            Console.WriteLine(evil[233]);
            Console.WriteLine(evil[787]);
            foreach (KeyValuePair<int, string> ghost in evil)
            {
                Console.WriteLine($"EMplyid: {ghost.Key} Employname: {ghost.Value}");
            }     
            Dictionary<int,string> suj = new Dictionary<int,string>();   // Dictionary is a generic collection that store data                       
            suj.Add(185, "Sujit");                                         // in key value pairs each key must be uniqe value cannot  be duplicated
            suj.Add(945, "Shivraj");
            suj.Add(756, "Rupnar");
            
            Dictionary<int,string> peek = new Dictionary<int,string>();
            peek.Add(232, "Infosys");
            peek.Add(298, "Tech Mahindra");
            peek.Add(334, "JP morgan");

            foreach (KeyValuePair<int,string> we in peek)
            {
                Console.WriteLine($"ID: {we.Key} Name: {we.Value}");
            }     


        }    
    
    
    }
}
