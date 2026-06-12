using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class OperatorsAssignment
    {
        public void systeam()
        {

            /// Task 1: Arithmatic Operators


            int a = 3;                 //Variable Decleration
            int b = 10;

            // Arthimatic operators
            Console.WriteLine("Arithmatic operators");
            Console.WriteLine($"Aaddition: {a + b}");
            Console.WriteLine($"Substraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Mod: {a % b}");


            /// Task 2: Relational Operators



            int c = 10;                                      //variable decleration
            int d = 10;


            //Comparison or Relational Opertators
            Console.WriteLine("Comparison Operators");
            Console.WriteLine($"Equals: {c == d}");
            Console.WriteLine($"Not Equals: {c != d}");
            Console.WriteLine($"Greater than: {c > d}");
            Console.WriteLine($"Less than: {c < d}");
            Console.WriteLine($"GreterEquals: {c >= d}");
            Console.WriteLine($"LessEquals: {c <= d}");

            // Task 3: Logical Operators

            // Logical Operators
            int age = 20;
            bool hasID = true;                      // variable decleration

            Console.WriteLine(age > 18 && hasID); 
            Console.WriteLine(age < 18 || hasID); 
            Console.WriteLine(!hasID);            












        }






        static void Main()
        {
            OperatorsAssignment obj = new OperatorsAssignment();
            obj.systeam();
            



        }    
    
    
    
    }
}
