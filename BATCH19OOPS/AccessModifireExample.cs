using System;

namespace BATCH19_OOPS
{
    internal class PublicEx
    {
        public string Name = "AJAY";

        public void Show()
        {
            Console.WriteLine("Employee Name: " + Name);
        }
    }

    class AccessModifireExample
    {
        static void Main()
        { 
            PublicEx pe = new PublicEx();

            Console.WriteLine(pe.Name);

            pe.Show();
        }
    }
}