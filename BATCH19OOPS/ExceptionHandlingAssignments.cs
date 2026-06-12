using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BATCH19_OOPS
{
    internal class ExceptionHandlingAssignments
    {
        class NegativeNumberException : Exception
        {
            public NegativeNumberException(string message) : base(message)
            {

            }
        }

        public void Alter()
        {
            // Assignment No 1: Write a Program to perform the following operation and handle any exception that may 
            // may occur: addition, substraction, Multiplication and Division

            try
            {
                Console.WriteLine("Enter the First Number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Addition: " + (a + b));
                Console.WriteLine("Sustraction: " + (a - b));
                Console.WriteLine("Multiplication: " + (a * b));
                Console.WriteLine("Division: " + (a / b));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divided by Zero");
                Console.WriteLine(ex.Message);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("OverFlow Exception");
                Console.WriteLine(ex.Message);

            }
            catch (ArithmeticException ex) 
            {
                Console.WriteLine("Arithmetic Error");
                Console.WriteLine(ex.Message);

            
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Formate Error");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Ended");
            }
                 


        }     
        public void Alter2()
        {

            // Assignment 2:  Write  a program that Prompts the user to enter a positive integer.
            





            try
            {

                Console.Write("Enter positive integer");
                int num = Convert.ToInt32(Console.ReadLine());

                // Check Negative Number
                if(num < 0)
                {
                    throw new NegativeNumberException("Negative Numbers Are Not Allowed");

                }
                Console.WriteLine("You Entered:" + num);

            }     
            catch(NegativeNumberException ex)
            {
                Console.WriteLine("Custon Exception:" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter Correct Value");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadLine();




        }     


    
        static void Main()
        {
           ExceptionHandlingAssignments obj = new ExceptionHandlingAssignments();
           obj.Alter2();
        }   
    }
}
