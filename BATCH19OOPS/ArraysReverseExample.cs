using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace BATCH19_OOPS
{
    internal class ArrayPractice6
    {
        
        public void student8()
        {

            int[] numbers = { 11, 22, 33, 44, 55 };   //Array Decleration
            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers [i]);
                

            }
            int[] num = { 10, 20, 30, 40, 50 };
            for (int i = 0;i < num.Length; i++)
            {
                Console.WriteLine(num [i]);
            }
            int[] num2 = { 11, 12, 13, 14, 15, 16, 17, 18 };
            for(int i = 0; i < num.Length;i++)
            {
                Console.WriteLine(num2[i]);

            }
            int[] num3 = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i= 0;i<num3.Length;i++)
            {
                Console.WriteLine(num3[i]);
            }
            string[] fruits = { "Mango", "Apple", "Graphs", "Banana", "Cherry" };
            for(int i= 0;i<fruits.Length;i++ )
            {
                Console.WriteLine(fruits [i]);
            }
            string[] players = { "Vaibhav", "Sumit", "Omkar", "Shivraj", "Mahesh" };
            for (int i = 0; i < players.Length; i++) 
            {
                Console.WriteLine(players[i]);
            }
            decimal[] salary = { 20000.22m, 35000.44m, 100000.22m, 330000.33m };
            for(int i= 0; i<salary.Length;i++)
            {
                Console.WriteLine(salary[i]);
            }
            decimal[] salary3 = { 22222.11m, 333333.33m, 444444.44m, 555555.55m, 666666.66m };
            for(int i =0; i < salary3.Length; i++)
            {
                Console.WriteLine(salary3[i]);
            }      




        }
        public void student9()
        {
            ///// Multidimentional Array Decleration
            ///
            int[,] multidime =
                {   // 0    1   2  column
                     { 10, 20, 30},       // 0  row   [0,0] [0,1], [0,2]
                     { 22, 24, 60}        // 1  row   [0,1], [1,1], [1,2]
                };
            for (int i= 0; i<2;  i++)      // Row 2
            {
                for (int j= 0; j< 3;  j++)   /// column 3
                {
                    Console.WriteLine(multidime[i, j] + " ");
                }         

            }
            int[,] multidime3 =
                {
                    { 25, 44, 13, },
                    { 33, 22, 12, },
                    { 22, 33, 44, }


                };
            for (int i= 0;i<3; i++)
            {
                for (int k = 0; k< 3; k++)
                {
                    Console.Write(multidime3[i, k]+ " ");
                }
                Console.WriteLine();
            }
            ////
            /// Jagged Array
            /// 
            int[][] nos = new int[3][];  // variable decleration is diffrent 
            nos[0] = new int[] { 2, 3 };
            nos[1] = new int[] {4, 5, 6 };
            nos[2] = new int[] {7, 8, 9, 11 };

            for (int l= 0; l < nos.Length; l++)
            {
               for (int j= 0; j < nos[l].Length; j++)
                {
                    Console.Write(nos[l][j]+ " ");
                }
                Console.WriteLine();
            }
            int[][] num = new int[3][];       // Decleration
            num[0] = new int[] { 1, 1 };
            num[1] = new int[] {2, 2, 2 };
            num[2] = new int[] {3, 3, 3, 3 };

            for (int i = 0; i < num.Length;i++)
            {
                for(int j = 0; j < num[i].Length; j++)
                {
                    Console.Write(num[i][j] + " ");
                }


            }
            int[][] num5 = new int[4][];
            num5[0] = new int[] { 11, 12 };
            num5[1] = new int[] { 33, 44, 55 };
            num5[2] = new int[] { 55, 55, 55, 55 };
            num5[3] = new int[] { 22, 33, 44, 66, 77 };

            for (int i = 0;i < num.Length;i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write(num5[i][j]);

                }
                Console.WriteLine();           
            }     







        }     
        public void student11()
        {

            /// jagged array 
            /// 
            int[][] num3 = new int[3][];
            num3[0] = new int[] {1, 2};
            num3[1] = new int[] {3,4, 5};
            num3[2] = new int[] {6,7, 8, 9};
             
            for (int i = 0;i < num3.Length;i++)
            {
                for (int z = 0;z < num3[i].Length;z++)
                {
                    Console.Write(num3[i][z] + " ");
                }
                Console.WriteLine();
            }


            int[][] num5 = new int[4][];
            num5[0] = new int[] { 11, 12 };
            num5[1] = new int[] { 33, 44, 55 };
            num5[2] = new int[] { 55, 55, 55, 55 };
            num5[3] = new int[] { 22, 33, 44, 66, 77 };

            for (int i = 0; i < num5.Length; i++)
            {
                for (int j = 0; j < num5[i].Length; j++)
                {
                    Console.Write(num5[i][j] + " ");

                }
                Console.WriteLine();
            }
            int[][] numpy = new int[4][];
            numpy[0] = new int[] { 11, 11, };
            numpy[1] = new int[] { 22, 22, 22 };
            numpy[2] = new int[] { 33, 33, 33, 33 };
            numpy[3] = new int[] { 44, 44, 44, 44, 44 };
            
            for (int i =0; i< numpy.Length; i++)
            {
                for(int y = 0; y < numpy[i].Length;y++)
                {
                    Console.Write(numpy[i][y] + " ");
                }
                Console.WriteLine();
            }
            int[][] numpy1 = new int [4][];
            numpy1[0] = new int[] { 12, 23, };
            numpy1[1] = new int[] { 45, 55, 33 };
            numpy1[2] = new int[] { 55, 55, 55, 55 };
            numpy1[3] = new int[] { 88, 44, 33, 33, 44 };

            for(int i = 0; i < numpy1.Length; i++)
            {
                for(int x = 0; x< numpy1[i].Length; x++)
                {
                    Console.Write(numpy1[i][x] + " ");
                }
                Console.WriteLine();
            }
            int[][] numpy2= new int [4][];
            numpy2[0] = new int[] { 12, 33 };
            numpy2[1] = new int[] { 33, 33, 33 };
            numpy2[2] = new int[] { 22, 22, 44, 44 };
            numpy2[3] = new int[] { 33, 44, 44, 33,33 };

            for (int i =0;i< numpy2.Length; i++)
            {
                for (int w = 0; w < numpy2[i].Length; w++) 
                {

                    Console.Write(numpy2[i][w] + " ");

                }
                Console.WriteLine();
            }
            int[][] expo = new int[5][];
            expo[0] = new int[] { 2, 1 };
            expo[1] = new int[] {2, 2, 2, 2, 2, 2 };
            expo[2] = new int[] { 1, 1, 11, 1 };
            expo[3] = new int[] { 44, 44, 44 };
            expo[4] = new int[] { 22, 22, };

            for (int i =0; i< expo.Length; i++)
            {
                for (int v = 0; v < expo[i].Length; v++)
                {
                    Console.Write(expo[i][v] + " ");
                }
                Console.WriteLine();
            }
            int[][] swipe = new int[3][];
            swipe[0] = new int[] { 99, 33 };
            swipe[1] = new int[] { 33, 33, 33 };
            swipe[2] = new int[] { 1, 11, 11, 1 };

            for (int i = 0; i< swipe.Length; i++)
            {
                for (int u = 0; u< swipe[i].Length; u++)
                {
                    Console.Write(swipe[i][u]);
                }
                Console.WriteLine();
            }
            int[][] save = new int[3][];
            save[0] = new int[] { 11, 11, 11 };
            save[1] = new int[] { 11, 11 };
            save[2] = new int[] { 11, 11, 11, 11, };
             
            for (int i = 0;i< save.Length;i++)
            {
                for (int t = 0; t < save[i].Length; t++)
                {
                    Console.Write(save[i][t] + " ");
                }
                Console.WriteLine();

            }
            int[][] wish = new int[3][];
            wish[0] = new int[] { 12, 11 };
            wish[1] = new int[] {12, 11, 22 };
            wish[2] = new int[] { 10, 10, 10, 11 };

            for (int i = 0; i< wish.Length; i++)
            {
                for (int s = 0;s < wish[i].Length;s++)
                {
                    Console.Write(wish[i][s] + " ");

                }
                Console.WriteLine();
            }
            int[][] wao = new int[3][];
            wao[0] = new int[] { 43, 33 };
            wao[1] = new int[] { 43, 33, 11, 22, 22 };
            wao[2] = new int[] { 21, 32, 22 };

            for (int i = 0;i< wao.Length;i++)
            {
                for (int r = 0; r < wao[i].Length; r++)
                {
                    Console.Write(wao[i][r] + " ");

                }
                Console.WriteLine();
            }
            int[] pay = { 22, 33, 23, 21, 32 };
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine(pay[i]);
            }
            string[] pay2 = { "PhonePay", "PayTm", "GooglePay", "Ipay" };
            for (int i = 0; i < pay2.Length; i++) 
            {
                Console.WriteLine(pay2[i]);

            }
            string[] city = { "Mumbai", "Pune", "CH.Sambhajinagar", "Kolhapur" };
            for (int i = 0;i< city.Length; i++)
            {
                Console.WriteLine(city[i]);
            }
            string[] Country = { "India", "NewZeland", "Australia", "America", "africa" };
            for (int i = 0; i < Country.Length; i++)
            {
                Console.WriteLine(Country[i]);
            }
            int[,] even =
                         {
                             {22, 23, 44},
                             {33, 22, 11 }
                         };
                           
            for(int i = 0; i< 2;i++)
            {
                for (int j = 0; j< 3; j++)
                {
                    Console.Write(even[i,j] + " ");
                }
                Console.WriteLine();
                
            }
            
            
            
                           







        }     
        static void Main()
        {


            ArrayPractice6 obj = new ArrayPractice6();
            obj.student11();



        }



    }
}