
namespace LibTP.ListeChaineeDouble
{
    public class ListechaineDouble<T>
    {
        public Element<T> Premier { get; set; }
        public Element<T> Dernier { get; set; }
        public int NbElement { get; set; }

        public void Ajouter(T pElement) 
        {
            Element<T> courant = new Element<T> { Valeur = pElement };
            if (Premier == null)
            {
                Premier = courant;
            }
            else
            {
                Dernier.Suivant = courant;
                courant.Precedent = Dernier;
            }
            Dernier = courant;
            NbElement++;
        }

        public void Ajouter(T pElement, int pIndice)
        {            
            if (pIndice >= NbElement)
                Ajouter(pElement);
            else 
            {
                Element<T> elem = new Element<T> { Valeur = pElement };
                if (pIndice == 0)
                {
                    elem.Suivant= Premier;
                    Premier.Precedent = elem;
                    Premier = elem;
                }
                else
                {
                    int i = 0;
                    Element<T> courant = Premier;
                    while (courant != null)
                    {
                        if (i < pIndice)
                        {                            
                            elem.Precedent = courant;
                            elem.Suivant = courant.Suivant;
                            courant.Suivant.Precedent = elem; 
                            courant.Suivant = elem;
                            break;
                        }
                        courant = courant.Suivant;
                    }
                }
                NbElement++;
            }
        }

        // -------------------------------------------------------------------
        public void Supprimer (T pElem)
        {
            Element<T> courant = Premier;
            while (courant != null)
            {
                if (courant.CompareTo(pElem) == 0)
                {
                    if (courant.Suivant != null)
                    {
                        courant.Precedent.Suivant = courant.Suivant;
                        courant.Suivant.Precedent = courant.Precedent;
                    }
                    else 
                    {
                        courant.Precedent.Suivant = null;
                        Dernier = courant.Precedent;
                    }
                    courant.Dispose();
                    NbElement--;
                    break;
                }
                courant = courant.Suivant;
            }
        }
    }
}
