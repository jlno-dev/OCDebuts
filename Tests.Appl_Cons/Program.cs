using LibTests;
using LibEntreeSortie;
using LibTP.ListeChaineeDouble;
using System;

namespace Tests.Appl_Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cours_01.Tester();
            //iTestable test = new TP_01_BonWeek();
            //iTestable test = new TP_02_CalculEnBoucle();
            //iTestable test = new TP_03_Loto(); 
            //iTestable test = new TP_04_JeuPlusMoins();
            //iTestable test = new TP01_Jeu_TuerMonstres();
            iTestable test = new TP02_ListeDoubleGenerique();
            test.Tester(new ESConsole());
            Console.ReadLine();
            
        }

    }
}
