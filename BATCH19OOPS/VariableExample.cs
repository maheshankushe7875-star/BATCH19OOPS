using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class VariableExample
    {

        public void manager()
        {

            Console.WriteLine("Hello Mahesh");

            int a = 10;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);


            int d = 22;
            int e = 25;
            int f = (d * e);

            Console.WriteLine(f);

            int h = 33;
            int i = 34;
            int j = (h * i);

            Console.WriteLine(j);
            Console.WriteLine(i);
            Console.WriteLine(h);

            string name = "Mahesh";
            int age = 26;
            Console.WriteLine($"My name is {name} and my age {age}");

            int g = 10;
            int k = 20;

            g = g + k;
            k = g - b;
            k = g - k;

            Console.WriteLine($"g = {g}, k = {k}");











        }     
        static void Main()
        {
            VariableExample example = new VariableExample();
            example.manager();
        }     
    }
}
