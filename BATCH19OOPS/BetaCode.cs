using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BATCH19_OOPS
{
    internal class BetaCode
    {
          


        public void HarryPotter()
        {

            
            int[] num = {10, 20,  30, 40};
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            int[] num2 = { 50, 60, 70, 80, 90 };
            for (int i = 0; i < num2.Length; i++) 
            {

                Console.WriteLine(num2[i]);
            
            }
            int[] num3 = { 110, 120, 130, 140, 150 };
            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine(num3[i]);

            }
            string[] names = { "Harrry", "Harmoyani", "Mellfoy", "rawn", "Granger" };
            for (int i = 1; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            int sum = 0;
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0;i < x.Length; i++)
            {
                sum += x[i];

            }
            Console.WriteLine(sum);
            int sum1 = 0;
            int[] number = { 11, 12, 13, 14, 16, 16, 17 };
            for(int i = 0; i < number.Length; i++)
            {
                sum1 += number[i];
            }
            Console.WriteLine(sum1);

            int sum2 = 0;
            int[] table = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            for(int i = 0; i < table.Length; i++)
            {
                sum2 += table[i];
            }
            Console.WriteLine(sum2);
            double avg  = sum2/table.Length;
            Console.WriteLine(avg);


            int sum3 = 0;
            int[] numpy = { 1, 2, 3, 4, 5 };
            for (int i = 0;i< numpy.Length ; i++)
            {
                sum3 += numpy[i];

            }
            Console.WriteLine(sum3);
            double avg2 = sum3 / numpy.Length;
            Console.WriteLine(avg2);

            int[,] ary = {

                {10, 12, 23, },
                {11, 13, 14, }
            };

            Console.WriteLine(ary[1, 2]);
            Console.WriteLine(ary[0, 0]);
            Console.WriteLine(ary[0, 1]);
            Console.WriteLine(ary[1, 0]);
            Console.WriteLine(ary[1, 0]);
            Console.WriteLine(ary[1, 1]);

            int[,] pee = {
                {11, 17, 19,},
                {22, 23, 25,},
                {33, 34, 55, }

            };

            Console.WriteLine(pee[0, 1]);
            Console.WriteLine(pee[1, 1]);
            Console.WriteLine(pee[2, 1]);
            Console.WriteLine(pee[2, 2]);
            Console.WriteLine(pee[0, 0]);
            Console.WriteLine(pee[1, 0]);




            int[][] push = new int [5][];
            push[0] = new int[] { 1, 2, 3, 4 };
            push[1] = new int[] { 2, 3, 4 };
            push[2] = new int[] {4, 4, 5 };
            push[3] = new int[] {5, 6, 7 };
            push[4] = new int[] { 6, 7 };
            for (int i = 0; i < push.Length; i++)
            {
                for (int j = 0; j < push[i].Length; j++)
                {
                    Console.Write(push [i][j] + " ");
                }
                Console.WriteLine();
            }     


            int [][] pop = new int [3][];
            pop[0] = new int[] {11, 22, 33, 44 };
            pop[1] = new int[] { 55, 44 };
            pop[2] = new int[] { 66, 54, 99 };
            for (int i = 0;i < pop.Length;i++)
            {
                for(int j = 0;j < pop[i].Length;j++)
                {
                    Console.Write(pop[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[][] weep = new int [2][];
            weep[0] = new int[] { 84, 78 };
            weep[1] = new int[] { 44, 55, 77 };
            for(int i =0; i< weep.Length;i++)
            {
                
                
                    for ( int j = 0; j < weep[i].Length; j++)
                    {
                        Console.Write(weep[i][j] + " ");
                    }
                    Console.WriteLine();
                     
            }     
            
          




        }     
        public void Hermione()
        {

            
             







        }     
    
    
    
    
    
    
    
    
    
    
    
    
    
        static void Main()
        {
            BetaCode ar = new BetaCode();
            ar.Hermione();
            
            
            
            


        }    
    
    
    }
}
