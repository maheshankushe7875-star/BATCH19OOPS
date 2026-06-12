using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace BATCH19_OOPS
{
    internal class ControlStatementExample
    {
        
        
            
        


        public void trainer1()
        {

            int subscribers = 10000;
            if (subscribers >= 5000)
            {


                Console.WriteLine("Silver button is Unlocked");
            }
            int Battary = 500;
            if (Battary > 400)
            {

                Console.WriteLine("Battary is Healthy");

            }
            double Accuracy = 9.5;
            if (Accuracy > 8)
            {

                Console.WriteLine("Excellent");
            }
            int health = 10;
            if (health >= 8)
            {
                Console.WriteLine(" Use energy drink");
            }
            int stockprice = 1111;
            if (stockprice < 50000)
            {
                Console.WriteLine("Sell the Stock");
            }
            int signal = 10;
            if (signal >= 7)
            {
                Console.WriteLine("The signal is Srong");
            }
            int likes = 2000;
            if (likes < 5000)
            {

                Console.WriteLine("Struggling");
            }
            int cpuTem = 43;
            if (cpuTem > 12)
            {
                Console.WriteLine("RED Alert");
            }
            int price = 147;
            if (price > 103)
            {
                Console.WriteLine("Inflation");


            }
            bool ShelovesMe = true;
            if (ShelovesMe)
            {
                Console.WriteLine("Congratulations");
            }
            int marks = 23;
            if (marks > 35)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            int battary2 = 540;
            if (battary2 < 600)
            {
                Console.WriteLine("Sufficient");
            }
            int capacity = 100;
            if (capacity > 50)
            {
                Console.WriteLine("Manforce");

            }
            else
            {
                Console.WriteLine("Weakness");

            }
            bool premium = false;
            if (premium)
            {
                Console.WriteLine("Access gpt 5");

            }
            else
            {
                Console.WriteLine("Upgrade Required");
            }
            double balance = 1000000;
            if (balance > 50000)
            {
                Console.WriteLine("Sufficiant Package");
            }
            else
            {
                Console.WriteLine("Unsufficient Package");

            }
            string password = "12345";
            if (password != "Net@132xx")
            {

                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("LoginFailed");

            }
            bool internet = false;
            if (internet)
            {


                Console.WriteLine("Playing");
            }
            else
            {
                Console.WriteLine("Buffering");


            }
            bool Moter = false;
            if (Moter)
            {
                Console.WriteLine("ONN");

            }
            else
            {
                Console.WriteLine("OFF");
            }
            bool heater = false;
            if (heater)
            {
                Console.WriteLine("Working");
            }
            else
            {
                Console.WriteLine("Damaged");

            }
            // ladder 

            int speed = 500;
            if (speed >= 300)
            {

                Console.WriteLine("Ultra Fast");

            }
            else if (speed >= 200)
            {
                Console.WriteLine("Fast");

            }
            else if (speed >= 150)
            {
                Console.WriteLine("Average");
            }
            else if (speed >= 100)
            {
                Console.WriteLine("Slow");
            }
            else
            {
                Console.WriteLine("poor");

            }
            // Nested


            int skills = 50;
            bool communication = true;
            if (skills > 40)
            {
                if (communication)
                {

                    Console.WriteLine("Your Hired");
                }
                else
                {
                    Console.WriteLine("Your not Eligible");
                }

            }
            else
            {
                Console.WriteLine("Not Hired");
            }

            // nested
            int coding = 400;
            bool communication2 = true;
            bool degree = true;
            bool interview = true;
            if (coding >= 300)
            {
                if (communication2)
                {
                    if (degree)
                    {
                        if (interview)
                        {
                            Console.WriteLine(" Hired || Congratulatiions ");
                        }
                        else
                        {
                            Console.WriteLine("Interview Failed || FAIL ");

                        }

                    }
                    else
                    {
                        Console.WriteLine("Rejected");
                    }

                }
                else
                {
                    Console.WriteLine("Degree Rquired");
                }


            }
            else
            {
                Console.WriteLine("Communication Werak");
            }
            // Space rocket launch
            bool weatherclear = true;
            bool fuelready = true;
            bool engineworking = true;
            bool permissiongranted = true;
            if (weatherclear)
            {
                if (fuelready)
                {

                    if (engineworking)
                    {
                        if (permissiongranted)
                        {
                            Console.WriteLine("Rocket Launched");

                        }
                        else
                        {
                            Console.WriteLine("Permission Denied");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Fuen is NOT sufficient");

                    }
                }
                else
                {
                    Console.WriteLine("Launching Failed");

                }


            }
            else
            {
                Console.WriteLine("Weather Problem");
            }
            bool passport = true;
            bool visa = true;
            bool ticket = true;
            bool baggerclear = true;
            if (passport)
            {
                if (visa)
                {
                    if (ticket)
                    {
                        if (baggerclear)
                        {

                            Console.WriteLine("Boarding Allowed");






                        }
                        else
                        {
                            Console.WriteLine("Permission  denied");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Laggege problem");
                    }

                }
                else
                {
                    Console.WriteLine("ticket Problem");
                }


            }
            else
            {
                Console.WriteLine("visa Not Approved");

            }

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
                    Console.WriteLine("Invalid day");
                    break;






            }

            string Role = "Admin";

            switch (Role)
            {
                case ("Admin"):
                    Console.WriteLine("ALLOW full Access");
                    break;
                case ("Employee"):
                    Console.WriteLine("Limited Access");
                    break;
                case ("Puen"):
                    Console.WriteLine("No Access");
                    break;
                case ("Customer"):
                    Console.WriteLine("Withdrwal Access");
                    break;









            }
            // Traffic signal Controller
            string Signal = "Red";
            switch (Signal)
            {

                case ("Yellow"):
                    Console.WriteLine("READY");
                    break;
                case ("Green"):
                    Console.WriteLine("GO");
                    break;
                case ("Red"):
                    Console.WriteLine("STOP");
                    break;
                default:
                    Console.WriteLine("Incorrect Signal");
                    break;





            }
            // student grade analyser

            char grade = 'Z';
            switch (grade)
            {
                case ('Y'):
                    Console.WriteLine("Excellent");
                    break;
                case ('X'):
                    Console.WriteLine("Second Class");
                    break;
                case ('W'):
                    Console.WriteLine("Average");
                    break;
                case ('Z'):
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Distinction");
                    break;




            }
            // E- Commerce discount
            // 
            string membership = "Silver";
            switch (membership)
            {

                case ("Silver"):
                    Console.WriteLine("30% discound");
                    break;
                case ("Gold"):
                    Console.WriteLine("100% discount");
                    break;
                case ("Bronz"):
                    Console.WriteLine("10% discount");
                    break;
                default:
                    Console.WriteLine("No discount");
                    break;


            }
            // Login systeam
            string stutus = "Blocked";
            switch (stutus)
            {
                case ("Active"):
                    Console.WriteLine("Safe");
                    break;
                case ("Blocked"):
                    Console.WriteLine("Danger");
                    break;
                case ("Suspended"):
                    Console.WriteLine("Distiction");
                    break;
                default:
                    Console.WriteLine("BlackListed");
                    break;







            }
            // sMART HOME CONTROL 
            int device = 4;
            switch (device)
            {
                case 1:
                    Console.WriteLine("Fan is ONN");
                    break;
                case 2:
                    Console.WriteLine("Fan is Steady");
                    break;
                case 3:
                    Console.WriteLine("Noicy");
                    break;
                case 4:
                    Console.WriteLine("Working");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;




            }
            string choice = "Pizza";
            switch (choice)
            {

                case ("Burger"):
                    Console.WriteLine("Burger ordered");
                    Console.WriteLine("The Price is 200");
                    break;
                case ("Salad"):
                    Console.WriteLine("Salad Ordered");
                    Console.WriteLine("The price is 123");
                    break;
                case ("Pizza"):
                    Console.WriteLine("Pizza Ordered");
                    Console.WriteLine("The Price is 250");
                    break;
                default:
                    Console.WriteLine("Order Cancelled");
                    break;

            }
            // for looping
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= 20; i += 2) // EVEN NUMBER
            {
                Console.WriteLine(i);


            }
            for (int i = 1; i <= 19; i += 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 19; i += 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i >= 1; i--)
            {

                Console.WriteLine(i);
            }
            int num = 5;
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(num * i);

            }
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum += i;


            }
            Console.WriteLine(sum);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Student No " + i);

            }
            //
            int j = 1;
            while (j < 11)
            {
                Console.WriteLine("Student Roll No " + j);
                j++;
            }
            //
            int k = 1;
            do
            {
                Console.WriteLine("Student id " + k);
                k++;

            }
            while (k < 11);
            //
            for (int z = 1; z <= 5; z++)
            {
                Console.WriteLine("Money Dispensed");
            }
            // For Even

            for (int l = 2; l <= 20; l += 2)
            {
                Console.WriteLine(l);
            }
            // while
            int p = 2;
            while (p <= 20)
            {
                Console.WriteLine(p);
                p += 2;
            }
            // do while
            int m = 2;
            do
            {

                Console.WriteLine(m);
                m += 2;
            }
            while (m <= 20);
            // odd for
            for (int n = 1; n <= 19; n += 2)
            {
                Console.WriteLine(n);
                n += 2;
            }
            // while odd
            int q = 1;
            while (q <= 21)
            {

                Console.WriteLine(q);
                q += 2;
            }
            // do while loop
            int r = 1;
            do
            {
                Console.WriteLine(r);
                r += 2;
            }
            while (r <= 21);

            // reverse for
            for (int s = 10; s >= 1; s--)
            {
                Console.WriteLine(s);

            }
            // do while for reverse
            int t = 10;
            do
            {
                Console.WriteLine(t);
                t--;
            }
            while (t >= 1);
            // tables
            for (int u = 1; u <= 10; u++)
            {
                Console.WriteLine(5 * u);

            }
            // table while
            int v = 1;
            while (v <= 10)
            {
                Console.WriteLine(5 * v);
                v++;
            }
            // do while table
            int w = 1;
            do
            {
                Console.WriteLine(31 * w);
                w++;
            }
            while (w <= 10);
            // sum 
            for (int x = 1; x <= 15; x++)
            {
                sum += x;
            }
            Console.WriteLine(sum);
            // while
            int y = 1;
            while (y <= 5)
            {
                Console.WriteLine(sum);
                y++;
            }
            sum += y;



            //  For each loop

            string[] mobile = { "Apple", "Blackberry", "Sony", "Samsung", "Gionee", "Redmi", "Realme", "Vivo", "OnePlus", "Motorola" };
            foreach (string brand in mobile)
            {
                Console.WriteLine(brand); ;
            }

            //
            for (int x = 1; x <= 5; x++)
            {
                
            }     
        }
        static void Main()
        {

            ControlStatementExample obj = new ControlStatementExample();
            obj.trainer1();

        }     
    }     
}