using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace BATCH19_OOPS
{
    internal class JumpingStatementAssignment
    {
        public void instructor()
        {
            // For each loop 1
            string[] mobile = { "Apple", "Blackberry", "Sony", "Samsung", "Gionee", "Redmi", "Realme", "Vivo", "OnePlus", "Motorola" };
            foreach (string brand in mobile)
            {
                Console.WriteLine(brand); 
            }
            // Break 2 
            int[] userNumbers = { 22, 34, 55, -12, 36, 66 };
            int sum = 0;
            foreach (int num in userNumbers)
            {
                Console.WriteLine(num);

                sum = sum + num;



                if (num < 0)
                {
                    break;

                }

            }

            Console.WriteLine(sum);
        
        
            // Continue
            for (int i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                { 
                    continue;
                }
                Console.WriteLine(i);
            }
            // GO TO 

            int age = -5;

        Start:
            
            Console.WriteLine("Age = " + age);
            if (age < 0 || age > 80)
            {
                Console.WriteLine("Invalid Age");

                age = 26;

                goto Start;
            }

            Console.WriteLine("Valid Age");
        
        
        }
        static void Main()
        {
            JumpingStatementAssignment obj = new JumpingStatementAssignment();
            obj.instructor();
        }     












    }




    
}
