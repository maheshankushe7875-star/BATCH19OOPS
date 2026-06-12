using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace BATCH19_OOPS
{
    internal class ApplicationCode
    {
        public void Melfoy()
        {
            List <int> list = new List<int>();
            list.Add(20);
            list.Add(44);
            list.Add(33);
            list.Add(42);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }     


            List <string> list2 = new List<string>();
            list2.Add("Mahesh");
            list2.Add("Ramesh");
            list2.Add("Umesh");
            list2.Add("Suresh");
            list2.Add("Sumedh");
            foreach ( string pee in list2)
            {
                Console.WriteLine(pee);
            }     

            List <float> list3 = new List<float>();
            list3.Add(5.5f);
            list3.Add(6.2f);
            list3.Add(4.2f);
            list3.Add(6.3f);
            list3.Add(3.3f);
            foreach (float boy in list3)
            {
                Console.WriteLine("Height: " + boy);
            }     


            Dictionary <int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Thaman");
            dict.Add(2, "Anirudha");
            dict.Add(3, "M KeerVani");
            dict.Add(4, "Sai Abhynkar");
            foreach(var oo  in dict)
            {
                Console.WriteLine($"Numbers: {oo.Key} Names: {oo.Value}");
            }     

            Dictionary <int,String> que = new Dictionary<int,String>();
            que.Add(1, "Hardik");
            que.Add(2, "Sachin");
            que.Add(3, "Virat");
            que.Add(4, "Ishan");
            foreach( var opus in que)
            {
                Console.WriteLine($"Jersy No: {opus.Key}, Players: {opus.Value}");
            }     

            Dictionary<int, string> ram = new Dictionary<int,string>();
            ram.Add(1, "USA");
            ram.Add(2, "UAE");
            ram.Add(3, "NewZeLand");
            ram.Add(4, "Australia");
            ram.Add(5, "Qatar");
            foreach(var country in ram)
            {
                Console.WriteLine($"Ranks: {country.Key}  Countries: {country.Value}");
            }     
            Dictionary <int,string> rap = new Dictionary<int,string>();
            rap.Add(1, "YoYo");
            rap.Add(2, "Badshaha");
            rap.Add(3, "Mc");
            rap.Add(4, "IKKA");
            rap.Add(5, "Raftaar");
            foreach(var bass in rap)
            {
                Console.WriteLine($"Popular: {bass.Key}  Rappers: {bass.Value} ");
            }     


            Stack<string> apps = new Stack<string>();     // LIFO
            apps.Push("Facebook");
            apps.Push("Instagram");
            apps.Push("Twitter");
            apps.Push("Telegram");
            apps.Push("WhatsApp");
            Console.WriteLine(apps.Pop());
            foreach (string app in apps)
            {
                Console.WriteLine(app);
            }     
            
            Stack<int> num = new Stack<int>();
            num.Push(69);
            num.Push(143);
            num.Push(224);
            num.Push(0087);
            num.Push(280);
            num.Push(670);
            Console.WriteLine(num.Pop());

           

            Queue <string> amu = new Queue<string>();             //FIFO
            amu.Enqueue("PineApple");
            amu.Enqueue("Mango");
            amu.Enqueue("Banana");
            amu.Enqueue("Strwberry");
            Console.WriteLine(amu.Dequeue());
            
            Queue <int> num3 = new Queue<int>();
            num3.Enqueue (911);
            num3.Enqueue(922);
            num3.Enqueue(933);
            num3.Enqueue(944);
            num3.Enqueue(955);
            Console.WriteLine(num3.Dequeue());

        }      


    
        static void Main()
        {
            ApplicationCode obj = new ApplicationCode();
            obj.Melfoy();
        }     
    
    }
}
