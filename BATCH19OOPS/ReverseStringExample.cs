using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BATCH19_OOPS
{
    internal class ReverseStringExample
    {

        public void player()
        {
            // print 1 to 10;
            // For loop 
            
            
                
                 
            



            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(i);
            }     
            // while loop
            int p = 1;
            while (p <= 10)
            {

                Console.WriteLine(p);
               p++;
            }     
            // do while loop
            int q = 1;
            do
            {
        
                Console.WriteLine(q);
                q++;
            }     
            while (q <= 10);
            ///
            // for each loop
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int l in list)
            {
                Console.WriteLine(l);
            }     
            ///
            // Print Even number for Loop
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }     
            // Even number by while loop
            int m = 2;
            while (m <= 10)
            {
                Console.WriteLine(m);
                m += 2;
            }
            // do while loop even
            int r = 2;
            do
            {
                Console.WriteLine(r);
                r += 2;
            }     
            while (r <= 10);
            /// foreach even
            /// 
            int[] even = { 2, 4, 6, 8, 10 };
            foreach (int e in even)
            {
                Console.WriteLine(e);
            }     
            /// odd for loop
            /// 
            for (int i = 1; i<= 19; i += 2)
            {
                Console.WriteLine(i);
            }     
            /// odd while loop
            /// 
            int t = 1;
            while (t <= 19)
            {
                Console.WriteLine(t);
                t += 2;
            }     
            // 
            // do odd
            int u = 1;
            do
            {
                Console.WriteLine(u);
                u += 2;
            }     
            while (u <= 19);
            //
            // foreach loop
            int[] odd = { 1, 3, 5, 7, 9, 11 };
            foreach (int o in odd)
            {
                Console.WriteLine(o);
                
            }      
            /// sum for loop
            /// 
            int sum2 = 0;
            for (int i = 1; i <= 10; i ++)
            {
                sum2 += i;
            }
            Console.WriteLine(sum2);
            // 
            // sum while loop
            int v = 1;
            int sum3 = 0;
            while (v <= 10)
            {
                
                sum3 += v;
                v++;
                
                


            }
            Console.WriteLine(sum3);
            //// Sum in DO WHILE LOOP
            ///
            int w = 1;
            int Sum5 = 0;
            do
            {
                Sum5 += w;
                w++;
              
            }     
            while (w  <= 10);
            Console.WriteLine(Sum5);
            ///
            // for each
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int sum = 0;
            foreach (int n in num)
            {
                sum += n;
                


            }     
            Console.WriteLine(sum);
            ///

            for (int z =1; z<= 10; z++)
            {
                if (z == 5)
                {
                    break;
                }
                Console.WriteLine(z);
            }     
            int g = 1;
            while (g <= 10)
            {
                if (g == 7)
                {
                    break;
                }
                Console.WriteLine(g);
                g++;
            }     
            int h = 1;
            do
            {
                if (h == 3)
                {
                    break;
                }
                Console.WriteLine(h);
                h++;
            }     
            while (h <= 10);

            int[] j = { 1, 2, 3, 4, 5 };
            foreach(int n in j)
            {
               if (n == 4)
                {
                    break;
                }
                Console.WriteLine(n);
                h++;
            }
            //
            int l1 = 0;  /// Decleration 
        start:
            Console.WriteLine(l1);
            l1++;
            if (l1 <= 10)
            {
                goto start;
            }
            // result
            // 
            static int Add(int a, int b)
            {
                return a + b;

                Console.WriteLine("Hello");
            }

            int result = Add(10, 20);
            Console.WriteLine(result);

            static int Add1(int c, int d)
            {
                return c + d;
            }
            int result1 = Add(30, 24);
            Console.WriteLine(result1);

            // Switch case 

            int Day = 4;
            switch (Day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break; 









            }     
            // For looping
            for(int i1 = 1; i1<= 10; i1++)
            {
                Console.WriteLine(i1);
            }
            // While. Loop 
            int i3 = 5;    //  Variable Decleration
            while (i3 <= 10)   // Entry Control Loop
            {
                Console.WriteLine(i3);
                i3++;
            }     
            // do while loop
            int i4 = 1; // Variable Decleration
            do
            {

                Console.WriteLine(i4);
                i4++;
            }     
            while (i4<= 10); // exit Control loop

            // ForEach loop
            string[] names = { "Ram", "Om", "Sham", "Ram" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            // if
            int age = 28; // Variable Decleration is required in if
            if (age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            //if else
            int number = 15; //Variable Decleration
            if (number % 2 == 1)
            {
                Console.WriteLine("Even number");

            }     
            else
            {
                Console.WriteLine("ODD Number");
            }
            //
            int score = 99;
            if (score % 2 == 2)
            {
                Console.WriteLine("Even Number");
            }     
            else
            {
                Console.WriteLine("ODD Number");
            }
            //// data types decleration
            ///
            int age5 = 30;                 // int
            float height = 5.9f;           // float
            decimal salary = 50000.33m;    //decimal
            string name7 = "Mahesh";        // string
            bool isworking = true;         // bool
            char grade = 'A';
            //Display value
            Console.WriteLine($"My Name is {name7}");
            Console.WriteLine($"My height is {height}");
            Console.WriteLine($"My salary is {salary}");
            Console.WriteLine($"My age is {age5}");
            Console.WriteLine($"My grade is {grade}");
            Console.WriteLine($"He is working {isworking}");




        }
        static void Main()
        {
            ReverseStringExample obj = new ReverseStringExample();
            obj.player();
        }     
    }
}
