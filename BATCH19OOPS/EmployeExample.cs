using System;

namespace BATCH19_OOPS
{
    public class EmployeExample
    {
        private string FirstName = "Mahesh";
        private string LastName = "Ankushe";

        public void DisplayFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class Program1
    {
        static void Main(string[]args)
        {
            EmployeExample obj = new EmployeExample();

            obj.DisplayFullName();
        }
    }
}