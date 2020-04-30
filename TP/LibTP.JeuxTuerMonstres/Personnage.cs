using System;
using System.Collections.Generic;
using System.Text;

namespace LibJeux.TuerMonstres
{
    public abstract class Personnage
    {
        bool _estVivant;
        public string Nom { get; protected set; }
        public int PointDeVie { get; protected set; }
        public ENiveau Niveau { get; protected set;}
        public bool EstVivant { get { return (PointDeVie > 0); } protected set { _estVivant = value; } }

        public Personnage (string pNom, int pPointDeVie, ENiveau pNiveau)
        {
            Nom = pNom;
            PointDeVie = pPointDeVie;
            EstVivant = true;
            Niveau = pNiveau;
        }
        public int Attaquer(Armes pArme)
        {
            return LancerAttaque(pArme);
        }

         public int Esquiver (Armes pArme)
        {
            return LancerEsquive(pArme);
        }

        public void PerdreVie()
        {
            PointDeVie = 0;
        }
        public void SubirDegats(int pPointDeDegats)
        {
            CalculerDegats(pPointDeDegats);
        }

        protected abstract int LancerAttaque(Armes pArme);
        protected abstract void CalculerDegats(int pPtDegats);
        protected abstract int LancerEsquive(Armes pArme);

    }
}
