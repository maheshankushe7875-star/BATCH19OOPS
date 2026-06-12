using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BATCH19_OOPS
{
    internal class IfElseExample
    {
        public void Aspirants()
        {

            int age = 26;
            if (age >= 18)
            {

                Console.WriteLine("The person can vote");


            }
            int ageB = 22;
            if (ageB >= 19)
            {

                Console.WriteLine("the person is eligible");


            }
            int num = 10;
            if (num >= 10)
            {
                Console.WriteLine("This is Positive Number");
            }
            int num1 = 11;
            if (num1 % 2 == 1)
            {

                Console.WriteLine("the num1 is odd");


            }
            int num2 = 97;
            if (num2 % 2 == 0)
            {

                Console.WriteLine("This is Even");

            }
            else
            {

                Console.WriteLine("The numebr is odd");

            }
            int pass = 100;
            if (pass >= 35)
            {

                Console.WriteLine("THe Candidate is Pass");


            }
            else
            {
                Console.WriteLine("the Candidate is Fail");
            }
            int A = 78;
            if (A % 2 == 0)
            {
                Console.WriteLine("EVEN");

            }

            else
            {

                Console.WriteLine("ODD");
            }
            int B = 99;
            if (B % 2 == 1)
            {

                Console.WriteLine("ODD");

            }
            else
            {
                Console.WriteLine("EVEN");
            }
            int C = 99;
            if (C % 2 == 1)
            {
                Console.WriteLine("ODD");

            }
            else
            {
                Console.WriteLine("EVEN");
            }
            int marks = 33;
            if (marks >= 35)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            string Password = "1234";
            if (Password != "2345")
            {

                Console.WriteLine("Wrong password");
            }
            else
            {
                Console.WriteLine("Correct");
            }
            string passward1 = "992234";
            if (passward1 == "345543")
            {
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("Wrong");
            }
            int Salary = 50000;
            int cibill = 550;
            if (Salary < 50000)
            {
                Console.WriteLine("Loan will not approve");

            }
            else if (cibill < 1000)
            {
                Console.WriteLine("loan is invalid");
            }
            else
            {
                Console.WriteLine("Loan is Approved");
            }
            int salary2 = 1000;
            int cibill2 = 500;
            if (salary2 < 2000)
            {
                Console.WriteLine("Loan will not approve");

            }
            else if (cibill2 < 200)
            {
                Console.WriteLine(" Invalid");
            }
            else if (salary2 <= 1000 || cibill2 <= 500)
            {

                Console.WriteLine("This is good ");
            }
            else
            {
                Console.WriteLine("Loan is approved");
            }
            string username = "Mahesh";
            string password4 = "2222";
            bool otpverified = true;
            bool activeuser = true;
            if (username == "Mahesh")
            {
                if (password4 == "2222")
                {
                    if (otpverified == true)
                    {
                        if (activeuser == true)
                        {
                            Console.WriteLine("The Login is Successfull");
                        }
                        else
                        {
                            Console.WriteLine("Wrong password");
                        }




                    }
                    else
                    {
                        Console.WriteLine("Invalid user");
                    }
                }
                else
                {

                    Console.WriteLine("Incorrect object");
                }

            }
            else
            {
                Console.WriteLine("Suspicious");
            }


        }
        static void Main()
        {
            IfElseExample obj = new IfElseExample();
            obj.Aspirants();

        }
    }
}
      
      






    

