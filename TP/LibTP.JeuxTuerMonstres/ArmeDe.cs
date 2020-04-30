using System;
using System.Collections.Generic;
using System.Text;

namespace LibJeux.TuerMonstres
{
    public class ArmeDe : Armes
    {
        public ArmeDe(int pNbAttaque, int pNbEsquive) : base (pNbAttaque, pNbEsquive)
        {

        }
        protected override int LancerAttaque()
        {
            return De.Lancer(PointAttque);
        }

        protected override int UtiliserEsquive()
        {
            return De.Lancer(PointEsquive);
        }
    }
}
