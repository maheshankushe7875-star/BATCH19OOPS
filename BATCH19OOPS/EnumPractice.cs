using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BATCH19_OOPS
{
    internal class EnumPractice
    {
        public void developer1()
        {
            int marks = 36;
            if (marks >= 37)
            {
                Console.WriteLine("THe student is pass");
            }
            else
            {
                Console.WriteLine("Student is Fail");
            }
            //
            string name = "Mahesh";
            int age = 26;
            bool ispracticing = true;
            decimal salary = 500000m;
            float height = 5.9f;

            if (ispracticing)
            {
                if (name == "Mahesh")
                {
                    if (salary > 20000) 
                    {
                        if (height > 5.5)
                        {
                            if (age >= 22)
                            {
                                Console.WriteLine("This is Correct Condition");
                            }
                            else
                            {
                                Console.WriteLine("NOT CORRECT");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Objection Denied");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Statement");
                    }
                }
                else
                {
                    Console.WriteLine("NOT ok");
                }
            }
            else
            {
                Console.WriteLine("nothing is right");
            }

            //
            int speed = 500;
            if (speed <= 100)
            {
                Console.WriteLine("The speed is wrong");

            }
            else if (speed <=200)
            {

                Console.WriteLine("the speed is Invalid");
            
            }     
            else if (speed <= 300)
            {
                Console.WriteLine("Nearby");

            }     
            else if (speed <=600)
            {
                Console.WriteLine("OK");
            }      
            else
            {
                Console.WriteLine("Correct");
            }         
            
            
        
        
        
        }
        public void developer2()
        {

            int Day = 3;
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
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;



            }     
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }     
        public void developer3()
        {
            /// looping 
            /// 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }     
            //// 
            ///
            int j = 1;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }     
            ///
            int k = 1;
            do
            {

                Console.WriteLine(k);
                k++;
            }   
            while(k < 10);

            ////// For each loop
            ///
            string[] names = { "Apple", "Mango", "Pineapple", "Graphes" };
            foreach(string name in names)
            {


            }        
        
        
        
        
        
        
        }     
         






       



        static void Main()
        {
            EnumPractice obj = new EnumPractice();
            obj.developer3();
        }
    }
}
