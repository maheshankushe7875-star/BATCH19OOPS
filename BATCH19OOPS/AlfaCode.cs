using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class AlfaCode
    {


        public void normal()
        {

            /// IF
            /// 
            int num = -10;
            if (0 <  num)
            {

                Console.WriteLine("Positive Number");
            }
            else
            {
                Console.WriteLine("Negative Number");
            }     
            int num1 = 13;
            if (num1 % 2  == 0)
            {

                Console.WriteLine("The number is Even");

            }     
            else
            {
                Console.WriteLine("The Number is Odd");
            }     
            int num2 = 3;
            if (num2 % 2 == 0)
            {
                Console.WriteLine("The Numberf is Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }     

            int num3 = 15;
            if (num3 % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("The num id Odd");
            }     
            int num4 = 19;
            if (num4 % 2 == 0)
            {
                Console.WriteLine("EVen Number");
            } 
            else
            {
                Console.WriteLine("Odddddddddd");
            }     
            
            int age = 20;
            if (age < 18)
            {
                Console.WriteLine("Eligible For Voting");
            }
            else
            {
                Console.WriteLine("Not eligible for voting");
            }     
            int age1 = 30;
            if (age1 > 18)
            {
                Console.WriteLine("Eligible Candidate");
            }     
            int age3 = 31;
            if (age3 > 28)
            {
                Console.WriteLine("Married");   /// if condition is onlt true
            }
            int a = 46;
            int b = 42;
            if (a > b)
            {

                Console.WriteLine("A is Greater");
            }
            int c = 100;
            int d = 103;
            if ( c < d)
            {
                Console.WriteLine("Greater");
            }
            int e  = 88;
            int f = 400;
            if (f > e)
            {
                Console.WriteLine("Greater f");
            }
            int marks = 45;
            if (marks > 35)
            {
                Console.WriteLine("Pass");
            }
            int marks2 = 70;

            if (marks2 > 60)
            {
                Console.WriteLine("A grade");
            }     
            int marks4 = 64;
            if (marks4 > 50 )
            {
                Console.WriteLine(" B Grade");
            }     
            int number = 55;
            if (number % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }     
            int number2 = 60;
            if (number2 % 10 == 0)
            {
                Console.WriteLine("Divisible by 10");
            }
            int number3 = 100;
            if (number3 % 20 == 0 )
            {
                Console.WriteLine("Thi is divisible by 20");
            }
            string name = "Mahesh";
            if (name == "Mahesh")
            {
                Console.WriteLine("Yes ");
            }
            string name2 = "Ramesh";
            if (name2 == "Ramesh")
            {
                Console.WriteLine("Yes");

            }
            string name4 = "Ganesh";
            if (name4 == "Ganesh")
            {
                Console.WriteLine("Yessss");
            }
            string name5 = "Wao";
            if (name5 == "Wao")
            {
                Console.WriteLine("Y");
            }     
            
        
        }     
        public void normal2()
        {
            // else if ladderr

            int age = 21;
            string name = "Mahesh";
            bool isworking = false;
            if (age == 25)
            {
                Console.WriteLine("Fulll");
            }
            else if (name == "Mahesh")
            {
                Console.WriteLine("Yepppp");

            }
            else if (age > 27)
            {
                Console.WriteLine("Wao");
            }     
            else
            {
                Console.WriteLine("Invalid");
            }

            int score = 299;
            string match = "Playing";
            float strickrate = 150.23f;
            if (score > 300)
            {
                Console.WriteLine("Good");
            }
            else if (match == "Playing")
            {
                Console.WriteLine("He is Playing Match");

            }     
            else if (strickrate <300)
            {
                Console.WriteLine("Not Eligible");
            }     
            else
            {
                Console.WriteLine("Default");
            }     
            int age9 = 22;
            bool isworking2 = true;
            float height = 5.7f;
            if (age9 > 18  && age9 == 2)
            {
                Console.WriteLine("Not eligible ");

            }     
            else if (height < 6.8 ||  height >6 )
            {
                Console.WriteLine("Right Candidate");

            }  
            else if (isworking !)
            {
                Console.WriteLine("IDK");
            }     
            else
            {
                Console.WriteLine("Nothing");
            }

            int age15 = 22;
            string name7 = "Piyali";
            bool isbeautifull = true;
            decimal salary = 5000000.32m;
            float ft = 5.5f;
            char grade = 'A';
            if (age15 > 18 && age15 < 25)
            {
                if (isbeautifull)
                {
                    if (salary > 22000 || salary != 20000 )
                    {
                        if (name7 == "Piyali")
                        {
                            if (ft == 5.5f)
                            {
                                if (grade == 'A')
                                {
                                    Console.WriteLine("Perfect For me");
                                }
                                else
                                {
                                    Console.WriteLine("Not Perfect");
                                }     
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }     
                        }
                        else
                        {
                            Console.WriteLine("Not For Me");
                        }     

                    }
                    else
                    {
                        Console.WriteLine("Wao");
                    }     
                }
                else
                {
                    Console.WriteLine("Bad");
                }     
            } 
            else
            {
                Console.WriteLine("Nothing");
            }     


        }
        public void normal3()
        {
            string month = "August";
            switch (month)
            {
                case ( "January"):
                    Console.WriteLine("Republic Month");
                    break;
                case ( "February"):
                    Console.WriteLine("Valentine Month");
                    break;
                case ("March"):
                    Console.WriteLine("Marathi new Year Month");
                    break;
                case ("April"):
                    Console.WriteLine("April Fool Month");
                    break;
                case ("May"):
                    Console.WriteLine("Summer Month");
                    break;
                case ("Jun"):
                    Console.WriteLine("Mansoon");
                    break;
                case ("July"):
                    Console.WriteLine("Agricultural Month");
                    break;
                case ("August"):
                    Console.WriteLine("Happy Birthday Mahesh");
                    break;
                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }     



        }
        public void normal4()
        {
            // Iteration or Looping Statement
            // For loop is used when number of repetations is known

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }

            for (int i = 2; i <= 10; i += 2) 
            {
                Console.WriteLine(i);
                

            }     
            for (int i = 11; i <= 19; i += 2)
            {
                Console.WriteLine(i);
            }     
            for (int i = 12; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }     
            for (int i = 20; i <= 40; i += 2)
            {
                Console.WriteLine(i);
            }     
            for (int i = 31;  i <= 41; i+= 2)
            {
                Console.WriteLine(i);
            }     
            for (int i = 100;  i <= 150; i+= 2)
            {
                Console.WriteLine(i);
            }      
            for (int i = 111; i <= 131; i += 2 )
            {
                Console.WriteLine(i);
            }     
            int m = 5;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(m * i);
            }
            /// Table
            /// 
            int n = 6;
            for (int i = 0;i <= 10; i++)
            {
                Console.WriteLine(n * i);
            }     
            int o = 7;
            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine(o * i);
            }
            int p = 8;
            for(int i = 0;i<= 10 ; i++)
            {
                Console.WriteLine(p * i);
            }     
            int q = 9;
            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine(q * i);
            }
            int r = 13;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(r * i);
            }
            int sum = 0;
            for (int i = 1;  i <= 10 ; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            int sum1 = 0;
            for(int i = 11;i<= 20 ; i++)
            {
                sum1 += i;
            }
            Console.WriteLine(sum1);
            double avg = sum1 / 10.0;
            Console.WriteLine(avg);
            int sum3 = 0;
            for(int i =91;i<= 100 ; i++ )
            {
                sum3 += i;

            }
            double avg2 = sum3 / 10.0;
            Console.WriteLine(sum3);
            Console.WriteLine(avg2);




        }     
    
        static void Main()
        {
            
            AlfaCode obj = new AlfaCode();
            obj.normal4();
        
        
        }   
    
    
    }
}
