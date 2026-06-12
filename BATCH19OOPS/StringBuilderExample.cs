using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class StringBuilderExample
    { 
        public void teacher1()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mahesh ");
            sb.Append("Ankushe");
            Console.WriteLine(sb);


            StringBuilder sb1 = new StringBuilder();

            for (int i = 0; i <= 10; i++)
            {
                sb1.AppendLine(i.ToString());

            }
            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder("I like apple");
            
            sb2.Replace("apple", "Mango");
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("Maheshrao");

            sb3.Remove(6, 3);
            Console.WriteLine(sb3);
        
            StringBuilder report = new StringBuilder();

            report.AppendLine("Student Report");
            report.AppendLine("---------------");

            report.AppendLine("Name: Mahesh");
            report.AppendLine("Roll no: 26");
            report.AppendLine("City: Mumbai");

            Console.WriteLine(report);


        }       
        public void teacher2()
        {
            // STRING
            string name = "Mahesh ";
            name = name + "Ankushe ";
            name = name + "C#";
            Console.WriteLine (name);

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Contains("C#"));

            // STRING BUILDER
            StringBuilder sb5 = new StringBuilder("Hello ");
            sb5.Append("World ");
            sb5.Append("C# ");
            Console.WriteLine(sb5.ToString());

            ////Incert
            ///
            StringBuilder sb6 = new StringBuilder("Hello World");
            sb6.Insert(6, "C# ");
            Console.WriteLine(sb5.ToString());

            // REMOVE

            
            sb6.Remove(5, 6);
            Console.WriteLine(sb6.ToString());

            sb6.Replace("rld", " Java");
            Console.WriteLine(sb6.ToString());

            // 
            StringBuilder sb8 = new StringBuilder("Hello");
            sb8.Append(" World");
            sb8.Append("C");
            Console.WriteLine(sb8.ToString());

            sb8.Replace("C"," Python");
            Console.WriteLine(sb8.ToString());

            // Boxing = It is aprocess of convrting value type to object, reference, dynamic type.
            int number = 100;
            Object obj = number;
            Console.WriteLine(obj);

            //UNBOXING
            
            Object obj2 = 100;
            int number2 = (int)obj2;
            Console.WriteLine(number2);








        }     






   
        static void Main()
        {
            StringBuilderExample obj = new StringBuilderExample();
            obj.teacher2();
               

        }       
    
    }
}
