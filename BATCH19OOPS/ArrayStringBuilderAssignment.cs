using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BATCH19_OOPS
{
         
    public class ArrayStringBuilderAssignment
    {
        public void Assignment1()
        {

            // Assignment 1 = Task 1


            StringBuilder sb = new StringBuilder("Mahesh ");

            sb.Append("Vitthal ");
            sb.Append("Ankushe ");
            sb.Append("City: Beed");
            Console.WriteLine(sb.ToString());

            //Task 2

            StringBuilder sb1 = new StringBuilder("I like to watch movies");
            sb1.Replace("movies", "Reels");
            Console.WriteLine(sb1.ToString());

            //Task 3

            StringBuilder sb2 = new StringBuilder("I am cleaver and intelligent");
            sb2.Remove(5, 11);
            Console.WriteLine(sb2.ToString());
            
            





        }
        public void Assignment2()
        {
            // Task 1  Find Maximum and Minimum
            int[] num = { 50, 30, 80, 10, 40 };
            int max = num[0];
            int min = num[0];
            for (int i = 0; i <num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }

                
            }
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Minimum = " + min);

        } 
        public void Assignment3()
        {
            // Task 1  Serch for element

            string[] names = { "Alice", "Bob", "Charlie", "David", "Emily" };
            bool search = false;
            for (int i = 0;i < names.Length;i++)
            {
                if (names[i] == "David")
                {
                    search = true;
                    break;

                }
                
                
                 
                     
            }
            Console.WriteLine(search);









        }     

        static void Main()
        {
            ArrayStringBuilderAssignment obj = new ArrayStringBuilderAssignment();
            obj.Assignment1();     


        }     
    
    
    
    
    
    
        
    
    
    
    }



}
