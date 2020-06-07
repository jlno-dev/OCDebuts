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
            //AjouterElement(pValeur);
            AjouterElement(Racine, pValeur);
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
                    if (valeurComparaison < 0)
                        courant = courant.Gauche;
                    else if (valeurComparaison > 0)
                        courant = courant.Droite;
					else
						break;
                }
                if (valeurComparaison < 0)
                {
                    precedent.Droite = nouvelleFfeuille;                    
                }
                else if (valeurComparaison > 0)
                {
                    precedent.Gauche = nouvelleFfeuille;                    
                }
            }
        }
		
		protected void AjouterElement(Feuille<T> pFeuille, T pValeur)
        {
            if (pFeuille == null)
            {
                pFeuille = new Feuille<T> { Valeur = pValeur };
                NbFeuilles++;
                if (Racine == null)
                    Racine = pFeuille;
            }
            else 
            {
                int valeurComparaison = pFeuille.CompareTo(pValeur);
                if (valeurComparaison > 0)
                    AjouterElement(pFeuille.Gauche, pValeur);
                else if (valeurComparaison < 0)
                        AjouterElement(pFeuille.Droite, pValeur);
            }
        }
    } // end class 
 }
