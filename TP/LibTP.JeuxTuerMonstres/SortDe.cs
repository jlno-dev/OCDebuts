using System;
using System.Collections.Generic;
using System.Text;

namespace LibJeux.TuerMonstres
{
    public class SortDe : Armes
    {
        public int DegatSort { get; protected set; }
        public SortDe(int pNbFaces) : base(pNbFaces, 0)
        {
            DegatSort = 5;
        }
        protected override int LancerAttaque()
        {
            int lanceDe = De.Lancer(PointAttque);
            if (lanceDe != PointAttque)
                return lanceDe * DegatSort;
            else
                return 0;
        }

        protected override int UtiliserEsquive()
        {
            return PointEsquive;
        }
    }
}
