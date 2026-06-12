using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BATCH19_OOPS
{
    internal class CodePractice
    {

         
        
        
        
        
        
        
        
        enum PaymentStatus
        {

            Pending = 1,
            Processing = 2,
            Success = 3,
            Failed = 4,
            Refunded = 5




        }
        class Payment
        {

            public int Paymentid { get; set; }

            public PaymentStatus Status { get; set; }

            public decimal Amount { get; set; }


        }
        enum PaymentMethod
        {

            UPI,
            CreditCard,
            DebitCard,
            Cheque,
            NetBanking,
            CASH







        }     
    
    
    
        static void Main(string[] args)
        {
           





            /////////////////////////////////////////////////////////

            Payment payment = new Payment
            {
                Paymentid = 101,
                Status = PaymentStatus.Pending,
                Amount = 50000     
            };
            processPayment(payment);
            Console.WriteLine($"Payment Status:  {payment.Status}");


            
            static void processPayment(Payment payment)
            {
                switch(payment.Status)
                {
                    case (PaymentStatus.Pending):
                        payment.Status = PaymentStatus.Processing;
                        Console.WriteLine("Payment is Processing");
                        break;
                    case(PaymentStatus.Success):
                        payment.Status = PaymentStatus.Success;
                        Console.WriteLine("Payment is Success");
                        break;
                    case(PaymentStatus.Failed):
                        payment.Status = PaymentStatus.Failed;
                        Console.WriteLine("Paynment is Failed");
                        break;
                    case (PaymentStatus.Refunded):
                        payment.Status = PaymentStatus.Refunded;
                        Console.WriteLine("Refunded");
                        break;
                }     


            }     
            
            
            
            
            
            
            
            
            
            
            
            PaymentMethod method =  PaymentMethod.UPI;
            if (method == PaymentMethod.UPI)
            {

                Console.WriteLine("Processing UPI Methods");


            }     




        }       
    
    
    }
}
