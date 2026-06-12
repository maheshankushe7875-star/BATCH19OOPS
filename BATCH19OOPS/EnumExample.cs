using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{

    internal class EnumExample
    {
        enum MealType
        {
            BreakFast = 1, 
            Lunch = 2,
            Dinner = 3
        }



        enum AIModel
        {
            chatgpt = 1,
            gemini = 2,
            deepseek = 3,
            cloude = 4
        }




        enum FoodDeliveryStatus
        {
            Orderd,
            InProcess,
            Manufacturing,
            OnTheWay

        }

        enum Priority
        {
            Low = 1,
            High = 2,
            Medium = 3


        }

        enum FuelType
        {
            Petrol,
            Dieseal,
            Electric,
            CNG,
            NeuclearReactor
        }


        enum NotificationType
        {
            Error,
            Warning,
            Success
        }




        enum UserLogin
        {
            Admin,
            User,
            Manager


        }







        enum LaptopBrand
        {
            HP,
            Lenovo,
            Dell,
            MachOs

        }





        enum PaymentStatus
        {
             Pending = 1,
             Processing = 2,
             Successfull = 3,
             Failed = 4,
             Refunded = 5


        }
        class Payment
        {

            public int Paymentid {  get; set; }

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
        static void Main()
        {
            MealType type2 = MealType.Dinner;
            if (type2 == MealType.Dinner)
            {
                Console.WriteLine((int)type2);

            }     







            AIModel model = AIModel.deepseek;
            Console.WriteLine(model);
            
            
            
            
            
            FoodDeliveryStatus update = FoodDeliveryStatus.OnTheWay;
            if (update == FoodDeliveryStatus.OnTheWay)
            {
                Console.WriteLine("He is Bringing your Food");
            }     



            Priority x = Priority.Medium;
            Console.WriteLine(x.ToString());
            







            FuelType source = FuelType.NeuclearReactor;
            if (source == FuelType.NeuclearReactor) ;
            {
                Console.WriteLine("Selected Fuel: " + source); 
            }
            
            
            
            
            
            
            
            
            
            NotificationType type = NotificationType.Success;

            switch(type)
            {
                case NotificationType.Error:
                    Console.WriteLine("There is something Building Error");
                    break;
                case NotificationType.Success:
                    Console.WriteLine("There is Success Full");
                    break;
                case NotificationType.Warning:
                    Console.WriteLine("Ther is showing Warning");
                    break;






            }     





            UserLogin login = UserLogin.Manager;
            if(login == UserLogin.Manager)
            {
                Console.WriteLine(login);
            }     



            LaptopBrand brand = LaptopBrand.Dell;
            Console.WriteLine(brand);









            Payment payment = new Payment
            {
                Paymentid = 101,
                Status = PaymentStatus.Pending,
                Amount = 5000

                

            };
            







            PaymentMethod method = PaymentMethod.UPI;
            if (method == PaymentMethod.UPI)
            {
                Console.WriteLine("Processing");
            }     
        
        
        
        
        
        
        
        }       
        
    
    }
}
