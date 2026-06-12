using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class EnumDemo
    {

        enum PaymentStatus
        {

            Pending = 1,
            Refund = 2,
            Processing = 3,
            Failed = 4,
            Success = 5


        }
        
        class Payment
        {

            public int Paymentid { get; set; }

            public PaymentStatus Status {  get; set; }

            public decimal Amount { get; set; }






        }      

        enum PaymentMethod
        {


            UPI,
            CreditCard,
            DebitCard,
            Cheque,
            Cash,
            NetBanking






        }     
        
        
    
    
           
        static void Main()
        {

            Payment payment = new Payment
            {

                Paymentid = 101,
                Status = PaymentStatus.Pending,
                Amount = 5000
            };     
            processPayment (payment);
            Console.WriteLine($"PaymentStatus: {payment.Status}");
            static void processPayment(Payment payment)
            {

                switch (payment.Status)
                {
                    case PaymentStatus.Pending:
                        Console.WriteLine("Payment is being processed");
                        payment.Status = PaymentStatus.Processing;
                        break;
                    case PaymentStatus. Processing:
                        payment.Status = PaymentStatus.Success;
                        break;
                    case PaymentStatus. Success:
                        payment.Status = PaymentStatus.Success;
                        Console.WriteLine("Payment is Succeeded");
                        break;
                    case PaymentStatus.Failed:
                        payment.Status = PaymentStatus.Failed;
                        Console.WriteLine("Payment is Failed");
                        break;


                }     

            }     




            PaymentMethod method = PaymentMethod.UPI;
            if (method  == PaymentMethod.UPI)
            {

                Console.WriteLine("Processing UPI Payment");
            }     




        }     
    
    }
}
