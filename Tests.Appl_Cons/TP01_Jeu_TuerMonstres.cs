using LibTests;
using LibEntreeSortie;
using LibJeux.TuerMonstres;


// using System.Collections.Generic;
// using System.Text;

namespace Tests.Appl_Cons
{
    class TP01_Jeu_TuerMonstres : iTestable
    {
        public Personnage GenererMonstre()
        {
            if (De.Lancer(7) % 2 == 0)
                return new MonstreFacile("Monstre F", 150);
            else
                return new MonstreDifficile("Monstre D", 150);
        }
        public void Tester(EntreeSortie pES)
        {
            pES.AfficherMessage("Jeu du hero qui affronte des monstres");
            LancerJeu2(pES);
        }
        private void LancerJeu(EntreeSortie pES)
        {
            Personnage Jojo = new Joueur("Heho", 150);
            Armes JetDe = new ArmeDe(7, 7);
            int CptMonstreFacile = 0;
            int CptMonstreDifficle = 0;


            while (Jojo.EstVivant)
            {
                Personnage monstre = GenererMonstre();
                ReglesJeu.GererAttaque(Jojo, JetDe, monstre, JetDe);
                if (monstre.EstVivant)
                {
                    ReglesJeu.GererAttaque(monstre, JetDe, Jojo, JetDe);
                }
                else
                {
                    if (monstre.Niveau  == ENiveau.Facile)
                    {
                        CptMonstreFacile++;                        
                    }
                    else
                    {
                        CptMonstreDifficle++;                        
                    }
                }
            }
            pES.AfficherMessage("Partie terminee");
            pES.AfficherMessage("Nb Monstres difficiles  tues " + CptMonstreDifficle.ToString());
            pES.AfficherMessage("Nb Monstres faciles tues " + CptMonstreFacile.ToString());
            pES.AfficherMessage("Total points " + (CptMonstreFacile + CptMonstreDifficle*2).ToString());
        }

        private void LancerJeu2(EntreeSortie pES)
        {
            Personnage Jojo = new Joueur("Heho", 150);
            Personnage Baby = new MonstreBoss("Baby", 2500);
            Armes JetDe = new ArmeDe(25, 25);

            while (Jojo.EstVivant && Baby.EstVivant)
            {                
                ReglesJeu.GererAttaqueBoss(Jojo, JetDe, Baby, JetDe);
                if (Baby.EstVivant)
                {
                    ReglesJeu.GererAttaqueBoss(Baby, JetDe, Jojo, JetDe);
                }
            }
            if (Jojo.EstVivant)
                pES.AfficherMessage("Jojo a gagne");
            else
                pES.AfficherMessage("Le vilain a gagne");
        }
    }

}
