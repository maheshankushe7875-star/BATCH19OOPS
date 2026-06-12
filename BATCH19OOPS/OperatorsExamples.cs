using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class OperatorsExamples
    {
        public void employee()
        {
            ////// call method
            ///
            



            // variable decleration
            int a = 30;
            int b = 20;

            // Arithmatic Operators
            Console.WriteLine($"Arithmatic Operators");
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Substraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Modulus: {a % b}");




            // Relational Operators 
            Console.WriteLine($"Relational Operators");
            Console.WriteLine($"Equal to: {a == b}");
            Console.WriteLine($"Not Equal to: {a != b}");
            Console.WriteLine($"Greater than: {a > b}");
            Console.WriteLine($"Less than:{a < b}");
            Console.WriteLine($"Greater than or Equal to:{a >= b}");
            Console.WriteLine($"Less than or Equal to: {a <= b}");

            // Logical Operators
            bool x = true;
            bool y = false;

            Console.WriteLine($"Logical Operators");
            Console.WriteLine($"AND (&&): {x && y}");
            Console.WriteLine($"OR (||): {x || y}");
            Console.WriteLine($"NOT (!):{!x}");









        }
        static void Main()
        {
            OperatorsExamples obj = new OperatorsExamples();
            obj.employee();


        }     
    }

}
