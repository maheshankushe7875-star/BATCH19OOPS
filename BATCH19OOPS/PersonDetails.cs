using System;

namespace BATCH19_OOPS
{
    public class Person
    {
        // Make fields public
        public string FirstName = "Mahesh";
        public string LastName = "Ankushe";

        public void DisplayFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
    public class person1
    {
        public string FirstName = "Sujit";
        public string LastName = "Kumar";

        public void DisplayFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        

    }      
    public class Person2
    {
        public string FirstName = "Vaibhav";
        public string LastName = "Bhor";

        public void DisplayFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }     
    }     
    public class Person3
    {
        public string FirstName = "Sumit";
        public string LastName = "Patil";
   
       public void DisplayFullName()
        {
            Console.WriteLine(FirstName +" "+  LastName);
        }      
    
    
    }     
    public class Person4
    {
        public string FirstName = "Rupesh";
        public string MiddleName = "Vitthal";
        public string LastName = "Ankushe";

        public void DisplayFullName()
        {
            Console.WriteLine(FirstName +" "+ MiddleName+" "+ LastName);
        }     

    }     






    class Program
    {
        static void Main()
        {
            Person4 obj = new Person4();

           

            obj.DisplayFullName();
        }
    }
}
  
