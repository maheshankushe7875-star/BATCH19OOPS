using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class JaggedArrayExample
    {
        public void student()
        {
            int age = 26;
            long population = 999999999999;
            byte marks = 95;
            float temprater = 95.12f;  //f requiresd in floot
            double pi = 3.14159;
            decimal salary = 50000.75m; // m required in decimal

            char grade = 'A';
            string name = "Mahesh";
            bool isloggedin = false;
            bool ispass = true;
            object data = "Mahesh";
            object number = 100;
            dynamic value = 10;
            value = "now string";

            Console.WriteLine("Hello");
            Console.WriteLine("Mahesh");
            Console.WriteLine("How Are You");

        }
        public void student2()
        {
            Console.Write("Hello");
            Console.Write("Mahesh");
            Console.WriteLine("How Are You");
            //
            string city = ("nasik");
            Console.WriteLine(city.ToUpper());
            //
            Console.Write("Piyali ");
            Console.Write("is ");
            Console.Write("my ");
            Console.WriteLine("girlfriend");

            string country = ("INDIA");
            Console.WriteLine(country.ToLower());

            string nation = "UnitedStatesOfAmerica";
            Console.WriteLine(nation.Length);

            string statement = ("Piyali is my girlfriend");
            Console.WriteLine(statement.Contains("Piyali"));

            string region = "UnitedArabEmirets";
            Console.WriteLine(region.Substring(10, 7));

            string name = ("Maharastra");
            Console.WriteLine(name.Substring(0, 3));


            int[] num = { 22, 55, 11, 23, 1, 8 };
            Array.Sort(num);
            foreach(int n in num)
            {
                Console.WriteLine(n);
            }     



        }
        public void student3()
        {
            int marks = 35;
            if (marks >= 36)
            {
                Console.WriteLine("Pass");

            }
            else 
            {
                Console.WriteLine("Fail");
            }     

            // lOOPING
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            int mark = 75;
            
            while (mark >= 60)
            {
                Console.WriteLine("First Class Pass");
                break;
                
                
            }
            int Mahesh = 75;
            do
            {
                Console.WriteLine("Pass");
                break;
            }
            while (Mahesh >= 76);

            int[] marks5 = { 23, 25, 66, 88 };
            foreach(int n in marks5)
            {
                if(n >= 36)
                {
                    break;
                }
                Console.WriteLine(n);
            }
            int sum = 0;
            for (int n = 1; n <= 10; n++)
            {
                sum += n;
            }
            Console.WriteLine(sum);
            //
            int table = 5;
            for (int i=1; i<= 10; i++)
            {

                Console.WriteLine(table * i);

            }      
            for (int i=1;i<= 10; i++)
            {
                Console.WriteLine(i * i * i);
            }     
            for (int i = 2; i<= 10; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }    
                     
            }
            int sum3= 0;
            for (int i=1;i<= 15; i++)
            {
                sum3 += i;
            }
            Console.WriteLine(sum3);
            int sum4 = 0;
            for (int i=1;i<= 20; i++)
            {
                sum4 += i;
            }
            Console.WriteLine(sum4);         
            int sum5 = 0;
            for (int i =1;i<= 20; i++)
            {
                sum5 += i;
            }
            for (int i=1;i <= 17; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                
                }

            }










        }
        static void Main()
        {
            JaggedArrayExample obj = new JaggedArrayExample();
            obj.student3();

            
        
        
        
        }    
        
    
    }
}
