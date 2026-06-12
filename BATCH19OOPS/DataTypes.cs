using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class DataTypes
    {
        public void test()
        {
            //data type Decleration

            int age = 30;      // int
            float height = 5.7f;    // float
            decimal salary = 50000.33m;  // decimal
            string name = "Mahesh";  // string
            bool isworking = true; // bool
            char grade = 'A';      // char
            //DISPLAY
            Console.WriteLine("My name is: " + name);
            Console.WriteLine("My age is: " + age);
            Console.WriteLine("My height is: " + height);
            Console.WriteLine("My grade is: " +  grade);
            Console.WriteLine("My salary is: " + salary);
            Console.WriteLine("iam is working: " + isworking);
























        }



        static void Main()
        {
            DataTypes obj = new DataTypes();
            obj.test();


        }      
    
    }
}
