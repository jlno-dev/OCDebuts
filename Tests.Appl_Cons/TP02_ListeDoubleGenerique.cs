using LibTests;
using LibEntreeSortie;
using LibTP.ListeChaineeDouble;

namespace Tests.Appl_Cons
{
    public class TP02_ListeDoubleGenerique : ITestable
    {
        public void Tester(EntreeSortie pES)
        {
            pES.AfficherMessage("TP liste chainee double");
            TesterListe(pES);
        }

        public void TesterListe(EntreeSortie pES)
        {
            ListechaineDouble<int> ListeEntier = new ListechaineDouble<int>();
            ListeEntier.Ajouter(5);
            ListeEntier.Ajouter(10);
            ListeEntier.Ajouter(4);
            AffichierListe(ListeEntier, pES);
            ListeEntier.Ajouter(99,0);
            AffichierListe(ListeEntier, pES);
            ListeEntier.Ajouter(33, 2);
            AffichierListe(ListeEntier, pES);
            ListeEntier.Ajouter(30, 2);
            AffichierListe(ListeEntier, pES);
            AffichierListe(ListeEntier, pES, 1);
            ListeEntier.Supprimer(5);
            ListeEntier.Supprimer(4);
            AffichierListe(ListeEntier, pES);
            AffichierListe(ListeEntier, pES, 1);
        }


        public void AffichierListe(ListechaineDouble<int> pListe, EntreeSortie pES, int pSens = 0)
        {
            if (pSens == 0) {
                Element<int> courant = pListe.Premier;
                while (courant != null)
                {
                    pES.AfficherMessage(courant.Valeur.ToString());
                    courant = courant.Suivant;
                }
            }
            else
            {
                Element<int> courant = pListe.Dernier;
                while (courant != null)
                {
                    pES.AfficherMessage(courant.Valeur.ToString());
                    courant = courant.Precedent;
                }

            }
            pES.AfficherMessage("--------------------");

        }
    }
}
