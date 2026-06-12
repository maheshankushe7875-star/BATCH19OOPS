using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class ArraysAssignments
    {
       public void user1()
       {
            // Assignment no 1. Write a C# programe to sum values of array
            int sum = 0;
            int[] numbers = { 22, 33, 11, 55 };
            for (int i = 0; i< 4; i++)
            {
                
                 sum += numbers[i];
               
            }
            Console.WriteLine(sum);


            //// Assignment no 2. Write a c# programm  calculate the average vale of array elements
            ///

            int sum1 = 0;
            int[] num = { 33, 44, 55, 66, 77, 88, 99 };
            for (int i = 0;i<num.Length; i++)
            {
                sum1 += num[i];
            }     
            double average = sum / (double)num.Length;
            Console.WriteLine("Average =" + average);
        
        
        
        
        
        
        
        
        
        
       }      
       public void user2()
        {

            string[] name = {"CODEMIND TECHNOLOGIES"};
            for (int i = name[0].Length - 1; i >= 0; i--)
            {


                Console.WriteLine(name[0][i]);

            }     






        }      
       





            
    
       static void Main()
        {
            ArraysAssignments obj = new ArraysAssignments();
            obj.user1();
        }      
    
    
    }
}
