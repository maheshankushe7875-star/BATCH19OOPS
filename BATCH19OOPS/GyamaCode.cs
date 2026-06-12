using System;
using System.Collections.Generic;
using System.Text;

namespace BATCH19_OOPS
{
    internal class GyamaCode
    {
        enum TamilWood
        {
            VijayThalapathy,
            Dhanush,
            Surya,
            Kartikeyn,
            AjitKumar,
            Rajnikant,
            Karthy,
            Vikram

        }     



        enum Directors
        {
            LokeshKanakraj,
            SSRajamouli,
            PrashantNeel,
            SandipReddyWanga,
            Atlee

        }     
        enum TollyActress
        {
            ShrutiHasan,
            SaiPallavi,
            PoojaHegde,
            Nayantara,
            KajalAgraval,
            Samantha
        }     

        enum Tollywood
        {
            AlluArjun,
            RamCharan,
            Prabhas,
            Nani,
            MaheshBabu,
            VijayDeverkonda
        }     


        enum MythryMovies
        {
            PUSHPA,
            Srivalli,
            CondaReddy,
            SINU


        }     

        enum Avengers
        {
            HULK,
            DoctorStrange,
            IronMan,
            CaptainAmerica,
            Thor,
            Marvel,
        }     



        enum Cource
        {
            AIML,
            CSE,
            AIDS,
            CyberSecurity,
            IoT,
            CloudComputing

        }     

        enum HogwartsHouse
        {
            DracoMalfoy,
            RonWisealey,
            HarmioneGranger,
            HarryPotter,
            LoonaLovegood


        }     
        
         







    
    
    
        static void Main(string[] args)
        {

            TamilWood act = TamilWood.VijayThalapathy;
            {
                switch (act)
                {
                    case (TamilWood.Dhanush):
                        Console.WriteLine("Actor,Writer,Director,Singer");
                        break;
                    case (TamilWood.Surya):
                        Console.WriteLine("Actor");
                        break;
                    case (TamilWood.Vikram):
                        Console.WriteLine("Aparichit");
                        break;
                    case (TamilWood.AjitKumar):
                        Console.WriteLine("Vedalam");
                        break;
                    case (TamilWood.VijayThalapathy):
                        Console.WriteLine("Master");
                        break;

                             
                }
            }

            Directors south = Directors.SandipReddyWanga;
            {
                Console.WriteLine(south);
            }

            TollyActress glamour = TollyActress.Samantha;
            {
                Console.WriteLine(glamour);
            }

            Tollywood actor = Tollywood.AlluArjun;
            {
                Console.WriteLine(actor);
            }



            MythryMovies part = MythryMovies.Srivalli;
            {
                Console.WriteLine(part);
            }



            Avengers heros = Avengers.Thor;
            {
                Console.WriteLine(heros);
            }


            Cource field = Cource.AIML;
            {
                Console.WriteLine(field);
            }




            HogwartsHouse house =  HogwartsHouse.HarmioneGranger;
            {
                Console.WriteLine(house);
            }      
            

        }    
    }
}
