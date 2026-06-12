using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class EnumAssignment
    {
        public void Assignment1()
        {
            //// Assignment No 1: Write a C# program to reverse the string.

            string[] name = { "CODEMINDS TECHNOLOGIES" };
            string text = name[0];
            
            for (int i = text.Length -1; i >= 0; i--)
            {


                Console.Write(text[i]);

            }
            
        }     
        public void Assignment2()
        {

            // Write a C# programme to find the even and odd integers of given array of integers.

            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }     
            }
            
            for (int i = 1; i <= 11; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }     
            }     
        }     



    
        static void Main()
        {
        
          EnumAssignment obj = new EnumAssignment();
          obj.Assignment2();
               
        
        
        
        }      
    
    
    
    
    }
}
