using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BATCH19_OOPS
{
    internal class EnumLearning
    { 
        enum Paymentstatus
        {

            Pending = 1,
            Processing = 2,
            Success = 3,
            Failed = 4,
            Refund = 5
            





        }     
        class Payment
        {

           public int PaymentId { get; set; }

           public Paymentstatus Status { get; set; }

           public decimal Amount { get; set; }   

            



        }     






        enum theworst
        {
            TollyWood,
            MalliWood,
            HollyWood,
            BollyWood



        }     

        enum Arya
        {
            Hit,
            Flop,
            Disaster,
            Blockbaster 
        }     


        enum Exam
        {
            Pass,
            Fail,
            Resticated,
            Absent



        }     
        enum Days1
        {

            Monday =1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,





        }     
        enum TrafficLights
        {

            RED,
            GREEN,
            YELLOW


        }
        static void Main()
        {
            Payment payment = new Payment
            {
                PaymentId = 101,
                Status = Paymentstatus.Pending,
                Amount = 60000



            };

            
            
            
           
            
                
                
                  
                
                
                
                
                
                



              









            theworst industry = theworst.BollyWood;
            if (industry == theworst.BollyWood)
            {
                Console.WriteLine("The Worst ");
            }     






            Arya movie = Arya.Blockbaster;
            if (movie == Arya.Blockbaster)
            {


                Console.WriteLine("ALL TIMES EVERGREEN");
            }
            
            
            Exam main = Exam.Resticated;
            if (main == Exam.Resticated)
            {
                Console.WriteLine(main.ToString());
            }     
            





            Days1 today = Days1.Tuesday;
            if (today == Days1.Tuesday)
            {
                Console.WriteLine(today.ToString());
            }     






            TrafficLights signal = TrafficLights.GREEN;
            if (signal == TrafficLights.GREEN)
            {

                Console.WriteLine("You can Go");
            }     




        }     
    
    
    }
}
