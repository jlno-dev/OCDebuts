using System;
using System.Collections.Generic;
using System.Text;

namespace LibJeux.TuerMonstres
{
    public abstract class Armes
    {
        public int PointAttque { get; protected set; }
        public int PointEsquive { get; protected set;}
        public Armes(int pPtAttaque)
        {
            PointAttque = pPtAttaque;
            PointEsquive = 0;
        }
        public Armes(int pPtAttaque, int pPtEsquive)
        {
            PointAttque = pPtAttaque;
            PointEsquive = pPtEsquive;
        }

        public int Attaquer()
        {
            return LancerAttaque();
        }

        public int Esquiver()
        {
            return UtiliserEsquive();
        }

        protected abstract int LancerAttaque();

        protected abstract int UtiliserEsquive();

    }
}
