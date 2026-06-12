using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class ExceptionHandlingExamples
    {
 
        public void text()
        {

            try
            {

                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                Console.WriteLine("Program Ended");
            }




        }     
        public void text2()
        {

            try
            {

                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);



              
                  

            }     
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }
           
            ///

            
            
                
        }
        public void text3()
        {
            try
            {

                Console.WriteLine("Entet number");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num);


            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine(ex.Message);

            
            }





        }
        public void text4()
        {
            try
            {

                string str = null;
                Console.WriteLine(str.Length);

            }     
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            ////
            ///
            



        }     
        public void text5()
        {
            try
            {

                Object obj = "Mahesh";
                int num = (int)obj;

                Console.WriteLine(num);

            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }     
        public void text6()
        {
            try
            {
                string data = File.ReadAllText("abc.text");
                Console.WriteLine(data);
            }      
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
            
        }     
        public void text7()
        {

            try
            {

                int[] arr = { 1, 2, 3, 4, 5 };
                int num = Convert.ToInt32("abc");
                Console.WriteLine(arr[5]);
                 



            }     
            catch (FormatException ex)
            {
                Console.WriteLine("Formate Exception");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index Exception");
            }
            catch(InvalidCastException ex)
            {

                Console.WriteLine("Invalid Exceptio");
            }
            
            
            
        }
        public void text9()
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);

            }     
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message); 

            }
            finally
            {
                Console.WriteLine("Finally Block Execution");
            }
            
        }     
        public void text10()
        { 
           
            try
            {
                string str = null;
                Console.WriteLine(str.Length);

                object obj = "Mahesh";
                int num = (int)obj;

                Console.WriteLine(num);

            }     
            catch(NullReferenceException ex)
            {

                Console.WriteLine("Formate Exception");
            }
            catch(InvalidCastException ex)
            {

                Console.WriteLine("Invalid Exception");
            }
            
        
        
        }     

        static void Main(string[] args)
        {
            ExceptionHandlingExamples obj = new ExceptionHandlingExamples();
            obj.text10();




        }   
    
    }
}
