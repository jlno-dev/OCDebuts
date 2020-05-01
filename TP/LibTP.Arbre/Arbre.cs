using System;
using System.Collections.Generic;
using System.Text;

namespace LibTP.Arbre
{
    public class Arbre<T>
    {
        public Feuille<T> Racine { get; set; }
        public int NbFeuilles { get; protected set; }

        public Arbre()
        {
            NbFeuilles = 0;
            Racine = null;
        }

        public Arbre(T pValeur)
        {
            Racine = new Feuille<T> { Valeur = pValeur };
            NbFeuilles = 1;
        }

        public void Ajouter(T pValeur)
        {
            AjouterElement(pValeur);
        }

        protected void AjouterElement(T pValeur)
        {
            Feuille<T> nouvelleFfeuille = new Feuille<T> { Valeur = pValeur };
            Feuille<T> courant, precedent;
            int valeurComparaison=0;

            if (Racine == null)
                Racine = nouvelleFfeuille;
            else
            {
                courant = Racine;
                precedent = courant;
                while (courant != null)
                {
                    valeurComparaison = courant.CompareTo(pValeur);
                    precedent = courant;
                    if (valeurComparaison <= 0)
                        courant = courant.Gauche;
                    else if (valeurComparaison > 0)
                        courant = courant.Droite;
                }
                if (valeurComparaison < 0)
                {
                    precedent.Droite = nouvelleFfeuille;
                    Console.WriteLine("droite"+pValeur.ToString());
                }
                else if (valeurComparaison >= 0)
                {
                    precedent.Gauche = nouvelleFfeuille;
                    Console.WriteLine("gauche" + pValeur.ToString());
                }
            }
        }
    } // end class 
 }
