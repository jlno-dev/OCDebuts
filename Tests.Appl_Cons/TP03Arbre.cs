using LibTests;
using LibEntreeSortie;
using LibTP.Arbre;
using System;

namespace Tests.Appl_Cons
{
    public class TP03Arbre : ITestable
    {
        public void Tester(EntreeSortie pES)
        {
            pES.AfficherMessage("Simulation d'un arbre");
            TestFeuille(pES);
            pES.AfficherMessage("Fin");
        }

        protected void TestFeuille(EntreeSortie pES)
        {
            //Feuille<int> feuille1 = new Feuille<int> { Valeur = 1 };
            //Feuille<int> feuille2 = new Feuille<int> { Valeur = 3 };
            Arbre<int> arbreTest = new Arbre<int>();
            Random alea = new Random();
            for (int i=0; i<50; i++)
            {
                arbreTest.Ajouter(alea.Next(100));
            }
            //pES.AfficherMessage("feuille1= "+ feuille1.Valeur.ToString()+ "feuille2 = "+ feuille2.Valeur+ " : " +feuille1.Valeur.CompareTo(feuille2.Valeur).ToString());
            //Feuille<int> feuille3 = new Feuille<int> { Valeur = 1 };
            //pES.AfficherMessage(feuille1.Valeur.CompareTo(feuille3.Valeur).ToString());

            //Feuille<int> feuille4 = new Feuille<int> { Valeur = -1 };
            //pES.AfficherMessage(feuille1.Valeur.CompareTo(feuille4.Valeur).ToString());


        }
    }
}
