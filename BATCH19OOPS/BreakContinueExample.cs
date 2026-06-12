using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class BreakContinueExample
    {
    
        public void client1()
        { 
        
            for (int i = 1; i <=5; i++)
            {

                if (i == 3)
                {

                    break;
                }

                Console.WriteLine(i);
            }     
        

            // continue
            for (int j = 1; j <=5;j++)
            {

                if (j == 3)
                {
                    continue;
                }

                Console.WriteLine(j);               
                
            }     
             for (int k = 1; k <= 5; k ++)
             {
                if (k == 4)
                {
                    break; 
                }
                Console.WriteLine(k); 
            
            
             }
            for (int l = 10; l >= 1; l--)
            {

                if (l  == 6)
                {
                    break;
                }
                Console.WriteLine(l);
            } 
            for (int m = 5; m <= 8; m ++)
            {
                if (m == 7)
                {
                    break;
                }
                Console.WriteLine(m);

            }     
            for (int n = 12;  n <= 33; n++)
            {
                if (n == 17)
                {

                    break;
                }
                Console.WriteLine(n);
            
            }
            for (int o = 1; o <= 22;  o++)
            {
                if (o == 21)
                {
                    break;

                }
                Console.WriteLine(o);
            }     
            for (int p = 1; p<= 23;  p++)
            {
                if (p == 14)
                {
                    break;
                }
                Console.WriteLine(p);
            
            }
            for (char ch = 'a'; ch <= 'z'; ch ++ )
            {
                if (ch == 'p')
                {
                    break;
                }
                Console.WriteLine(ch);
            
            }
            int q = 1;
            do
            {
                if (q == 5)
                {
                    break;
                }
                Console.WriteLine(q);
                q++;
            }
            while (q <= 17);

            //
            char chh = 'a';
            do
            {
                if (chh == 'w')
                {
                    break;
                }
                Console.WriteLine(chh);
                chh++;
            }
            while (chh <= 'z');
            //
            for (int r = 16; r<= 19; r++)
            {
                if (r == 18)
                {
                    continue;
                    
                }
                Console.WriteLine(r);
            }
            for (int s = 1; s <= 12; s++)
            {
                if (s  == 5)
                {
                    continue; 
                }
                Console.WriteLine(s);

            }     
            
            // 

            for (int i = 1; i <= 12; i++)
            {

                if (i  == 4)
                {
                    continue;

                }
                Console.WriteLine();
            }
           // Console.ReadLine();
           for (int  j = 1; j <= 12; j++)
           {






           }






            


        }      
        static void Main()
        {
            BreakContinueExample obj = new BreakContinueExample();
            obj.client1();
        }     
    }
}
