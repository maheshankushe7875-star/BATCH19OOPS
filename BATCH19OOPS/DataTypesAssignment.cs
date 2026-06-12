using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class DataTypesAssignment
    {
      
        public void text()
        {
            // Assignment on Data Types and Variable in C#.

            // Write a programe for substraction division Multiplication

            int a = 15;   // substaction
            int b = 18;
            int c = a - b;

            Console.WriteLine(c);

            double d = 54;      //Division
            double  e = 11;
            double f = d / e;
            Console.WriteLine(f);

            float g = 23.18f;      // Multiplication
            float h = 18.22f;
            float i = g * h;
            Console.WriteLine(i);

        }     




        static void Main()
        {
        
          DataTypesAssignment obj = new DataTypesAssignment();
            obj.text();   

        
        
        }       
    }
}
